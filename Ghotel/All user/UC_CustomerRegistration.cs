using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Ghotel.All_user
{
    public partial class UC_CustomerRegistration : UserControl
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice camera;
        private string capturedImagePath = "";
        private readonly object _cameraLock = new object();
        private bool faceCaptured = false; // ← NEW FLAG

        function fn = new function();
        long roomId;
        string query;
        long rid;

        decimal discountPercent = 0;
        decimal originalPrice = 0;
        decimal discountAmount = 0;
        decimal discountedPrice = 0;
        decimal vatAmount = 0;
        decimal totalAmount = 0;
        decimal paidAmount = 0;
        decimal changeAmount = 0;

        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }

        public UC_CustomerRegistration(string username, string password)
        {
            InitializeComponent();
            CustomerUsername = username;
            CustomerPassword = password;
        }

        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(string query, ComboBox combo)
        {
            combo.Items.Clear();
            DataSet ds = fn.getData(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    combo.Items.Add(row[0].ToString().Trim());
                }
            }
        }

        private void UC_CustomerRegistration_Load(object sender, EventArgs e) { }

        private void ct_rt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct_rn.Items.Clear();
            ct_pr.Clear();

            if (string.IsNullOrEmpty(ct_bed.Text) || string.IsNullOrEmpty(ct_rt.Text)) return;

            string bedType = ct_bed.Text.Trim().Replace("'", "''");
            string roomType = ct_rt.Text.Trim().Replace("'", "''");

            query = $"SELECT room_number FROM addrooms WHERE bed = '{bedType}' AND room_type = '{roomType}' AND booked = 'NO'";
            setComboBox(query, ct_rn);
        }

        private void ct_bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct_rt.SelectedIndex = -1;
            ct_rn.Items.Clear();
            ct_pr.Clear();
        }

        private void ct_rn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ct_rn.Text)) return;

            string selectedRoom = ct_rn.Text.Trim().Replace("'", "''");
            string detailQuery = $"SELECT price, room_id FROM addrooms WHERE room_number = '{selectedRoom}'";
            DataSet ds = fn.getData(detailQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ct_pr.Text = ds.Tables[0].Rows[0][0].ToString();
                rid = long.Parse(ds.Tables[0].Rows[0][1].ToString());
                computeTotal();
            }
        }

        private void computeTotal()
        {
            if (string.IsNullOrEmpty(ct_pr.Text)) return;

            if (decimal.TryParse(ct_pr.Text, out originalPrice))
            {
                discountAmount = originalPrice * (discountPercent / 100);
                discountedPrice = originalPrice - discountAmount;
                vatAmount = discountedPrice * 0.12m;
                totalAmount = discountedPrice + vatAmount;
            }
        }

        private void DiscountBtn_Click(object sender, EventArgs e)
        {
            string promoCode = Discount_box.Text.Trim().ToLower();

            if (promoCode == "antech the best")
            {
                discountPercent = 50;
                MessageBox.Show("🎉 Promo code applied! You get 50% discount!", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (promoCode == "ghotel10")
            {
                discountPercent = 10;
                MessageBox.Show("🎉 Promo code applied! You get 10% discount!", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                discountPercent = 0;
                MessageBox.Show("❌ Invalid promo code! Please try again.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            computeTotal();
        }

        private void AllocateBtn_Click(object sender, EventArgs e)
        {
            // CHECK IF FACE IS CAPTURED
            if (!faceCaptured)
            {
                MessageBox.Show(
                    "⚠️ Please capture your face photo first before allocating a room.",
                    "Face Capture Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // CHECK REQUIRED FIELDS
            if (!string.IsNullOrEmpty(ct_name.Text) &&
                !string.IsNullOrEmpty(ct_no.Text) &&
                !string.IsNullOrEmpty(ct_nation.Text) &&
                !string.IsNullOrEmpty(ct_gen.Text) &&
                !string.IsNullOrEmpty(ct_id.Text) &&
                !string.IsNullOrEmpty(ct_address.Text) &&
                !string.IsNullOrEmpty(ct_pr.Text))
            {
                computeTotal();

                string checkin = checkinTxt.Value.ToString("yyyy-MM-dd");

                MessageBox.Show(
                    "🎉 Congratulations, " + ct_name.Text + "!\n\n" +
                    "Room allocation successful.\n\n" +
                    "📋 Booking Summary:\n" +
                    "──────────────────────────\n" +
                    "Room No.   : " + ct_rn.Text + "\n" +
                    "Room Type  : " + ct_rt.Text + "\n" +
                    "Check In   : " + checkin + "\n" +
                    "Total Bill : PHP " + totalAmount.ToString("F2") + "\n" +
                    "──────────────────────────\n\n" +
                    "Proceed to payment.",
                    "Room Allocated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // SHOW PAYMENT
                paylbl.Visible = true;
                Payment_box.Visible = true;
                Payment_box.ReadOnly = false;
                Payment_box.Text = "";

                // SHOW PAY BUTTON
                payBtn.Visible = true;

                // DISABLE INPUTS
                ToggleInputControls(false);
            }
            else
            {
                MessageBox.Show(
                    "All fields must be completely filled out before allocation.",
                    "Incomplete Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void StartHardwareCamera()
        {
            try
            {
                StopCameraSafely();

                cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (cameras != null && cameras.Count > 0)
                {
                    camera = new VideoCaptureDevice(cameras[0].MonikerString);
                    camera.NewFrame += Camera_NewFrame;
                    camera.Start();
                }
                else
                {
                    MessageBox.Show("No camera detected. Please connect a camera and try again.",
                        "No Camera", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera initialization error: " + ex.Message,
                    "Hardware Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void startCameraBtn_Click(object sender, EventArgs e)
        {
            StartHardwareCamera();
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                lock (_cameraLock)
                {
                    if (eventArgs.Frame == null) return;

                    Bitmap bitmapClone = new Bitmap(eventArgs.Frame);
                    bitmapClone.RotateFlip(RotateFlipType.RotateNoneFlipX);

                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke(new MethodInvoker(() => UpdatePictureBox(bitmapClone)));
                    }
                    else
                    {
                        UpdatePictureBox(bitmapClone);
                    }
                }
            }
            catch (Exception)
            {
                // Gracefully catch background frame drops
            }
        }

        private void UpdatePictureBox(Bitmap bmp)
        {
            lock (_cameraLock)
            {
                if (pictureBox.Image != null)
                {
                    Image oldImage = pictureBox.Image;
                    pictureBox.Image = null;
                    oldImage.Dispose();
                }
                pictureBox.Image = bmp;
            }
        }

        private async void captureBtn_Click(object sender, EventArgs e)
        {
            // Validate name and contact filled
            if (string.IsNullOrEmpty(ct_name.Text) || string.IsNullOrEmpty(ct_no.Text))
            {
                MessageBox.Show("Please fill in Name and Contact Number first.",
                    "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate camera has image
            if (pictureBox.Image == null)
            {
                MessageBox.Show("No camera image detected. Please start the camera first.",
                    "No Camera Feed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate room has been allocated first
            if (string.IsNullOrEmpty(CustomerUsername))
            {
                MessageBox.Show("Please allocate a room first before capturing your face.",
                    "Allocate First", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                StopCameraSafely();

                // Save image locally
                capturedImagePath = Path.Combine(Path.GetTempPath(), CustomerUsername + "_face.jpg");
                using (Bitmap snapshot = new Bitmap(pictureBox.Image))
                {
                    snapshot.Save(capturedImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                // Upload to Flask face recognition server
                using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
                using (System.Net.Http.MultipartFormDataContent form = new System.Net.Http.MultipartFormDataContent())
                {
                    byte[] imageData = File.ReadAllBytes(capturedImagePath);
                    form.Add(new System.Net.Http.ByteArrayContent(imageData), "image", "face.jpg");
                    form.Add(new System.Net.Http.StringContent(CustomerUsername), "username");

                    System.Net.Http.HttpResponseMessage response = await client.PostAsync(
                        "http://127.0.0.1:5000/register-face", form);

                    string json = await response.Content.ReadAsStringAsync();
                    dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                    if (result.status == "success")
                    {
                        // ── Face captured successfully ──────────────────────
                        faceCaptured = true;

                        // Update face_image path in the database
                        string uname = CustomerUsername.Replace("'", "''");
                        string imagePath = capturedImagePath.Replace("'", "''");
                        query = $"UPDATE customer SET face_image = '{imagePath}' " +
                                $"WHERE cust_username = '{uname}' " +
                                $"ORDER BY cid DESC LIMIT 1";
                        fn.setData(query, null);

                        // NOW show the pay button
                        payBtn.Visible = true;
                        Payment_box.Focus();

                        MessageBox.Show(
                            "✅ Face captured and registered successfully!\n\n" +
                            "You may now proceed to payment. 💳",
                            "Face Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        faceCaptured = false;
                        MessageBox.Show(
                            "❌ Face registration failed on server.\n" +
                            "Please try capturing again.",
                            "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                faceCaptured = false;
                MessageBox.Show("Error capturing image: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            // REQUIRE FACE
            if (!faceCaptured)
            {
                MessageBox.Show(
                    "⚠️ Please capture your face photo first before proceeding to payment.",
                    "Face Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // CHECK PAYMENT
            if (string.IsNullOrEmpty(Payment_box.Text))
            {
                MessageBox.Show(
                    "Please enter payment amount.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // VALIDATE PAYMENT
            if (!decimal.TryParse(Payment_box.Text, out decimal paymentAmount))
            {
                MessageBox.Show(
                    "Please enter a valid amount.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // CHECK IF ENOUGH PAYMENT
            if (paymentAmount < totalAmount)
            {
                MessageBox.Show(
                    "Insufficient payment! Total is PHP " + totalAmount.ToString("F2"),
                    "Insufficient Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // PAYMENT SUCCESS
            paidAmount = paymentAmount;
            changeAmount = paymentAmount - totalAmount;

            // GET DATA
            string cname = ct_name.Text.Replace("'", "''");
            string mobile = ct_no.Text.Replace("'", "''");
            string nation = ct_nation.Text.Replace("'", "''");
            string gender = ct_gen.Text.Replace("'", "''");
            string dob = birthTxt.Value.ToString("yyyy-MM-dd");
            string id = ct_id.Text.Replace("'", "''");
            string address = ct_address.Text.Replace("'", "''");
            string checkin = checkinTxt.Value.ToString("yyyy-MM-dd");

            // INSERT CUSTOMER ONLY AFTER PAYMENT
            query = $"INSERT INTO customer " +
                    $"(cname, mobile, nationality, gender, dob, idproof, address, checkin, room_id, cust_username, cust_password, face_image) " +
                    $"VALUES " +
                    $"('{cname}', '{mobile}', '{nation}', '{gender}', '{dob}', '{id}', '{address}', '{checkin}', {rid}, '{CustomerUsername}', '{CustomerPassword}', '{capturedImagePath}')";

            fn.setData(query, null);

            // UPDATE ROOM STATUS
            query = $"UPDATE addrooms SET booked = 'YES' " +
                    $"WHERE room_number = '{ct_rn.Text.Trim().Replace("'", "''")}'";

            fn.setData(query, null);

            // SUCCESS MESSAGE
            DialogResult result = MessageBox.Show(
                "Payment Successful! ✅\n\n" +
                "Total: PHP " + totalAmount.ToString("F2") + "\n" +
                "Paid: PHP " + paymentAmount.ToString("F2") + "\n" +
                "Change: PHP " + changeAmount.ToString("F2") + "\n\n" +
                "Would you like to print your receipt?",
                "Payment Successful",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            // PRINT RECEIPT
            if (result == DialogResult.OK)
            {
                printDocument1.PrintPage += printDocument1_PrintPage;

                printPreviewDialog1.Document = printDocument1;

                printPreviewDialog1.ShowDialog();
            }

            MessageBox.Show(
                "Thank you! Please login to view your room details.",
                "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Form parentForm = this.ParentForm;

            Form1 form1 = new Form1();

            parentForm?.Hide();

            form1.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float pageWidth = e.PageBounds.Width;
            int y = 50;

            Font boldBig = new Font("Arial", 16, FontStyle.Bold);
            Font boldMed = new Font("Arial", 11, FontStyle.Bold);
            Font normal = new Font("Arial", 10, FontStyle.Regular);
            Font boldSmall = new Font("Arial", 10, FontStyle.Bold);

            string hotelName = "G Hotel";
            SizeF nameSize = g.MeasureString(hotelName, boldBig);
            g.DrawString(hotelName, boldBig, Brushes.Black, (pageWidth - nameSize.Width) / 2, y);
            y += (int)nameSize.Height + 2;

            string addr = "Your Hotel Address Here";
            SizeF addrSize = g.MeasureString(addr, normal);
            g.DrawString(addr, normal, Brushes.Black, (pageWidth - addrSize.Width) / 2, y);
            y += (int)addrSize.Height + 2;

            string tel = "Tel: +63 XXX XXX XXXX";
            SizeF telSize = g.MeasureString(tel, normal);
            g.DrawString(tel, normal, Brushes.Black, (pageWidth - telSize.Width) / 2, y);
            y += (int)telSize.Height + 15;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            g.DrawString("Customer Name : " + ct_name.Text, normal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Mobile No     : " + ct_no.Text, normal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Nationality   : " + ct_nation.Text, normal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Gender        : " + ct_gen.Text, normal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Date of Birth : " + birthTxt.Value.ToString("yyyy-MM-dd"), normal, Brushes.Black, 50, y); y += 22;
            g.DrawString("ID Proof      : " + ct_id.Text, normal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Address       : " + ct_address.Text, normal, Brushes.Black, 50, y); y += 22;
            g.DrawString("Check In      : " + checkinTxt.Value.ToString("yyyy-MM-dd"), normal, Brushes.Black, 50, y); y += 22;
            y += 5;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            g.DrawString("Room No.", boldSmall, Brushes.Black, 50, y);
            g.DrawString("Room Type", boldSmall, Brushes.Black, 200, y);
            g.DrawString("Price", boldSmall, Brushes.Black, pageWidth - 150, y);
            y += 22;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            g.DrawString(ct_rn.Text, normal, Brushes.Black, 50, y);
            g.DrawString(ct_rt.Text, normal, Brushes.Black, 200, y);
            g.DrawString(originalPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y);
            y += 30;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            g.DrawString("Original Price:", normal, Brushes.Black, 300, y);
            g.DrawString("PHP " + originalPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;

            if (discountPercent > 0)
            {
                g.DrawString("Promo Discount (" + discountPercent + "%):", normal, Brushes.Red, 300, y);
                g.DrawString("-PHP " + discountAmount.ToString("F2"), normal, Brushes.Red, pageWidth - 150, y); y += 22;
                g.DrawString("Discounted Price:", normal, Brushes.Black, 300, y);
                g.DrawString("PHP " + discountedPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;
            }

            g.DrawString("VAT (12%):", normal, Brushes.Black, 300, y);
            g.DrawString("PHP " + vatAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            string totalLabel = "TOTAL:  PHP " + totalAmount.ToString("F2");
            SizeF totalSize = g.MeasureString(totalLabel, boldMed);
            g.DrawString(totalLabel, boldMed, Brushes.Black, pageWidth - totalSize.Width - 50, y);
            y += 25;

            g.DrawString("Paid:", boldSmall, Brushes.Black, 300, y);
            g.DrawString("PHP " + paidAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;

            g.DrawString("Change:", boldSmall, Brushes.Black, 300, y);
            g.DrawString("PHP " + changeAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 40;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 15;

            string footer1 = "~ Thank you for staying ~";
            string footer2 = "~ G Hotel ~";
            SizeF f1 = g.MeasureString(footer1, normal);
            SizeF f2 = g.MeasureString(footer2, normal);
            g.DrawString(footer1, normal, Brushes.Black, (pageWidth - f1.Width) / 2, y); y += 22;
            g.DrawString(footer2, normal, Brushes.Black, (pageWidth - f2.Width) / 2, y);
        }

        private void StopCameraSafely()
        {
            if (camera != null && camera.IsRunning)
            {
                camera.SignalToStop();
                camera.WaitForStop();
                camera = null;
            }
        }

        private void ToggleInputControls(bool state)
        {
            ct_bed.Enabled = state;
            ct_rt.Enabled = state;
            ct_rn.Enabled = state;
            ct_name.Enabled = state;
            ct_no.Enabled = state;
            ct_nation.Enabled = state;
            ct_gen.Enabled = state;
            birthTxt.Enabled = state;
            ct_id.Enabled = state;
            ct_address.Enabled = state;
            checkinTxt.Enabled = state;
            AllocateBtn.Enabled = state;
            DiscountBtn.Enabled = state;
            Discount_box.Enabled = state;
        }

        private void pictureBox_Click(object sender, EventArgs e) { pictureBox.BringToFront(); }
        private void ct_name_TextChanged(object sender, EventArgs e) { }
        private void Payment_box_TextChanged(object sender, EventArgs e) { }
        private void ct_pr_TextChanged(object sender, EventArgs e) { }
        private void Discount_box_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2Button1_Click(object sender, EventArgs e) { }
    }
}