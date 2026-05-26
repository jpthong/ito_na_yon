using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace Ghotel.All_user
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        long roomId;
        String query;
        long rid;

        // ── DISCOUNT & TAX VARIABLES ──
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

        public UC_CustomerRegistration(string text)
        {
            InitializeComponent();
            Text = text;
        }

        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        public void setComboBox(string query, ComboBox combo)
        {
            combo.Items.Clear();
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
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
            query = "SELECT room_number FROM addrooms WHERE bed = '" + ct_bed.Text.Trim() + "' AND room_type = '" + ct_rt.Text.Trim() + "' AND booked = 'NO'";
            setComboBox(query, ct_rn);
        }

        private void ct_bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct_rt.SelectedIndex = -1;
            ct_rn.Items.Clear();
        }

        private void ct_rn_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT price, room_id FROM addrooms WHERE room_number = " + ct_rn.Text.Trim();
            DataSet ds = fn.getData(query);
            ct_pr.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = long.Parse(ds.Tables[0].Rows[0][1].ToString());

            computeTotal();
        }

        // ── COMPUTATION METHOD ──
        private void computeTotal()
        {
            if (ct_pr.Text == "") return;

            originalPrice = decimal.Parse(ct_pr.Text);
            discountAmount = originalPrice * (discountPercent / 100);
            discountedPrice = originalPrice - discountAmount;
            vatAmount = discountedPrice * 0.12m;
            totalAmount = discountedPrice + vatAmount;
        }

        // ── DISCOUNT BUTTON ──
        private void DiscountBtn_Click(object sender, EventArgs e)
        {
            string promoCode = Discount_box.Text.Trim().ToLower();

            if (promoCode == "antech the best")
            {
                discountPercent = 50;
                MessageBox.Show("🎉 Promo code applied! You get 50% discount!",
                    "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (promoCode == "ghotel10")
            {
                discountPercent = 10;
                MessageBox.Show("🎉 Promo code applied! You get 10% discount!",
                    "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                discountPercent = 0;
                MessageBox.Show("❌ Invalid promo code! Please try again.",
                    "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            computeTotal();
        }
        private void AllocateBtn_Click(object sender, EventArgs e)
        {
            if (ct_name.Text != "" && ct_no.Text != "" && ct_nation.Text != "" &&
                ct_gen.Text != "" && birthTxt.Text != "" && ct_id.Text != "" &&
                ct_address.Text != "" && checkinTxt.Text != "" && ct_pr.Text != "" &&
                CustomerUsername != "" && CustomerPassword != "")
            {
                // ── Re-compute before saving ──
                computeTotal();

                String cname = ct_name.Text;
                Int64 contact = Int64.Parse(ct_no.Text);
                String nation = ct_nation.Text;
                String gender = ct_gen.Text;
                String dob = birthTxt.Value.ToString("yyyy-MM-dd");
                String id = ct_id.Text;
                String address = ct_address.Text;
                String checkin = checkinTxt.Value.ToString("yyyy-MM-dd");
                String username = CustomerUsername;
                String password = CustomerPassword;

                query = "INSERT INTO customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, room_id, cust_username, cust_password) VALUES ('"
                    + cname + "'," + contact + ",'" + nation + "','" + gender + "','"
                    + dob + "','" + id + "','" + address + "','" + checkin + "',"
                    + rid + ",'" + username + "','" + password + "')";
                fn.setData(query, "");

                query = "UPDATE addrooms SET booked = 'YES' WHERE room_number = " + ct_rn.Text.Trim();
                fn.setData(query, "");

                // ── Success message with details ──
                MessageBox.Show(
                    "🎉 Congratulations, " + ct_name.Text + "!\n\n" +
                    "Your room has been successfully allocated.\n\n" +
                    "📋 Booking Summary:\n" +
                    "──────────────────────────\n" +
                    "  Room No.   : " + ct_rn.Text + "\n" +
                    "  Room Type  : " + ct_rt.Text + "\n" +
                    "  Check In   : " + checkinTxt.Value.ToString("yyyy-MM-dd") + "\n" +
                    "  Total Bill : PHP " + totalAmount.ToString("F2") + "\n" +
                    "──────────────────────────\n\n" +
                    "Please proceed to payment below. 💳",
                    "Room Allocated Successfully!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // ── Show payment section ──
                paylbl.Visible = true;
                Payment_box.Visible = true;
                Payment_box.ReadOnly = false;
                Payment_box.Text = "";
                Payment_box.Focus();

                payBtn.Visible = true;

                // ── Lock booking fields after allocation ──
                ct_bed.Enabled = false;
                ct_rt.Enabled = false;
                ct_rn.Enabled = false;
                ct_name.Enabled = false;
                ct_no.Enabled = false;
                ct_nation.Enabled = false;
                ct_gen.Enabled = false;
                birthTxt.Enabled = false;
                ct_id.Enabled = false;
                ct_address.Enabled = false;
                checkinTxt.Enabled = false;
                AllocateBtn.Enabled = false;
                DiscountBtn.Enabled = false;
                Discount_box.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please fill all the fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            // ── CHECK kung may laman ang Payment_box ──
            if (Payment_box.Text == "")
            {
                MessageBox.Show("Please enter payment amount.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── CHECK kung valid number ──
            decimal paymentAmount;
            if (!decimal.TryParse(Payment_box.Text, out paymentAmount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── CHECK kung sapat ang bayad ──
            if (paymentAmount < totalAmount)
            {
                MessageBox.Show("Insufficient payment! Total is PHP " + totalAmount.ToString("F2"),
                    "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── Compute change ──
            decimal change = paymentAmount - totalAmount;

            // ── Save for receipt ──
            paidAmount = paymentAmount;
            changeAmount = change;

            // ── Show payment result ──
            DialogResult result = MessageBox.Show(
                "Payment Successful! ✅\n\n" +
                "Total:    PHP " + totalAmount.ToString("F2") + "\n" +
                "Paid:     PHP " + paymentAmount.ToString("F2") + "\n" +
                "Change:   PHP " + change.ToString("F2") + "\n\n" +
                "Would you like to print your receipt?",
                "Payment Successful",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                printDocument1.PrintPage += printDocument1_PrintPage;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                MessageBox.Show("Thank you! Please login to view your room details.",
                    "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form parentForm = this.ParentForm;
                Form1 form1 = new Form1();
                parentForm.Hide();
                form1.Show();
            }
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

            // ── HEADER ──
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

            // ── CUSTOMER INFO ──
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

            // ── ROOM DETAILS ──
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

            // ── PRICE BREAKDOWN ──
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

            // ── TOTAL ──
            string totalLabel = "TOTAL:  PHP " + totalAmount.ToString("F2");
            SizeF totalSize = g.MeasureString(totalLabel, boldMed);
            g.DrawString(totalLabel, boldMed, Brushes.Black, pageWidth - totalSize.Width - 50, y);
            y += 25;

            // ── PAID & CHANGE ──
            g.DrawString("Paid:", boldSmall, Brushes.Black, 300, y);
            g.DrawString("PHP " + paidAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;

            g.DrawString("Change:", boldSmall, Brushes.Black, 300, y);
            g.DrawString("PHP " + changeAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 40;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 15;

            // ── FOOTER ──
            string footer1 = "~ Thank you for staying ~";
            string footer2 = "~ G Hotel ~";
            SizeF f1 = g.MeasureString(footer1, normal);
            SizeF f2 = g.MeasureString(footer2, normal);
            g.DrawString(footer1, normal, Brushes.Black, (pageWidth - f1.Width) / 2, y); y += 22;
            g.DrawString(footer2, normal, Brushes.Black, (pageWidth - f2.Width) / 2, y);
        }

        private void ct_name_TextChanged(object sender, EventArgs e) { }
        private void Payment_box_TextChanged(object sender, EventArgs e) { }
        private void ct_pr_TextChanged(object sender, EventArgs e) { }
        private void Discount_box_TextChanged(object sender, EventArgs e) { }
        private void ct_username_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2Button1_Click(object sender, EventArgs e) { }
    }
}