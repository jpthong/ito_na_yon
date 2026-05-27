using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using AForge.Video;
using AForge.Video.DirectShow;
using Newtonsoft.Json;
using Ghotel.All_user;

namespace Ghotel
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice camera;
        function fn = new function();
        string query;
        private readonly object _cameraLock = new object();

        public Form1()
        {
            InitializeComponent();
            PassTextBox.KeyPress += PassTextBox_KeyPress;
            this.AcceptButton = LoginBtn;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if (camera != null && camera.IsRunning)
            {
                camera.SignalToStop();
                camera.WaitForStop();
            }
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserTextbox.Text == "admin" && PassTextBox.Text == "admin123")
            {
                Errorlbl.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
                return;
            }

            query = "select * from employee where emp_username = '"
                  + UserTextbox.Text + "' and emp_password = '" + PassTextBox.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                Errorlbl.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
                return;
            }

            query = "select * from customer where cust_username = '"
                  + UserTextbox.Text + "' and cust_password = '" + PassTextBox.Text + "'";
            DataSet ds2 = fn.getData(query);

            if (ds2.Tables[0].Rows.Count != 0)
            {
                Errorlbl.Visible = false;
                CustomerRoomView cd = new CustomerRoomView(UserTextbox.Text);
                this.Hide();
                cd.Show();
                return;
            }

            Errorlbl.Visible = true;
            PassTextBox.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void customerSignUp_Click(object sender, EventArgs e)
        {
            CustomerSignIn csi = new CustomerSignIn();
            this.Hide();
            csi.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BringToFront();
        }

        private async void verifyFaceBtn_Click(object sender, EventArgs e)
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (camera == null || !camera.IsRunning)
            {
                MessageBox.Show("Please start the camera first before verifying.");
                return;
            }

            if (cameras.Count == 0)
            {
                MessageBox.Show("No camera found.");
                return;
            }

            verifyFaceBtn.Text = "Get Ready...";
            verifyFaceBtn.Enabled = false;

            for (int i = 3; i >= 1; i--)
            {
                verifyFaceBtn.Text = "Capturing in " + i;
                await Task.Delay(1000);
            }

            verifyFaceBtn.Text = "Verifying...";
            await CaptureAndVerify();

            verifyFaceBtn.Text = "Login with Face";
            verifyFaceBtn.Enabled = true;
        }

        private void FaceLogin_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                lock (_cameraLock)
                {
                    if (eventArgs.Frame == null) return;

                    Bitmap bitmapClone = new Bitmap(eventArgs.Frame);
                    bitmapClone.RotateFlip(RotateFlipType.RotateNoneFlipX);

                    if (pictureBox1.InvokeRequired)
                    {
                        pictureBox1.BeginInvoke(new MethodInvoker(() => UpdatePictureBox1(bitmapClone)));
                    }
                    else
                    {
                        UpdatePictureBox1(bitmapClone);
                    }
                }
            }
            catch (Exception) { }
        }

        private void UpdatePictureBox1(Bitmap bitmap)
        {
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = bitmap;
        }

        private async Task CaptureAndVerify()
        {
            try
            {
                if (camera != null && camera.IsRunning)
                {
                    camera.SignalToStop();
                    camera.WaitForStop();
                }

                string tempPath = Path.Combine(Path.GetTempPath(), "verify_temp.jpg");

                Bitmap snapshot = null;
                lock (_cameraLock)
                {
                    if (pictureBox1.Image == null)
                    {
                        MessageBox.Show("No image captured yet. Please try again.");
                        RestartCamera();
                        verifyFaceBtn.Text = "Login with Face";
                        verifyFaceBtn.Enabled = true;
                        return;
                    }

                    snapshot = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
                    using (Graphics g = Graphics.FromImage(snapshot))
                    {
                        g.DrawImage(pictureBox1.Image, 0, 0);
                    }
                }

                snapshot.Save(tempPath);

                using (HttpClient client = new HttpClient())
                using (MultipartFormDataContent form = new MultipartFormDataContent())
                {
                    byte[] imageData = File.ReadAllBytes(tempPath);
                    form.Add(new ByteArrayContent(imageData), "image", "verify.jpg");

                    HttpResponseMessage response = await client.PostAsync(
                        "http://127.0.0.1:5000/verify", form);

                    string json = await response.Content.ReadAsStringAsync();
                    dynamic result = JsonConvert.DeserializeObject(json);

                    if (result.status == "success")
                    {
                        string username = result.username.ToString();
                        query = "SELECT * FROM customer WHERE LOWER(cust_username) = LOWER('" + username + "')";
                        DataSet ds = fn.getData(query);

                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            Errorlbl.Visible = false;
                            CustomerRoomView cd = new CustomerRoomView(username);
                            this.Hide();
                            cd.Show();
                        }
                        else
                        {
                            MessageBox.Show("Face recognized but no account found. Please remove your eyeglasses, hat, or mask and try again.");
                            RestartCamera();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Face not recognized. Please try again.");
                        RestartCamera();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                RestartCamera();
            }
        }

        private void openCameraBtn_Click(object sender, EventArgs e)
        {
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (cameras.Count == 0)
            {
                MessageBox.Show("No camera found.");
                return;
            }

            camera = new VideoCaptureDevice(cameras[0].MonikerString);
            camera.NewFrame += FaceLogin_NewFrame;
            camera.Start();
        }

        private void RestartCamera()
        {
            try
            {
                if (cameras == null || cameras.Count == 0)
                    cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                camera = new VideoCaptureDevice(cameras[0].MonikerString);
                camera.NewFrame += FaceLogin_NewFrame;
                camera.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not restart camera: " + ex.Message);
            }
        }

        private void Errorlbl_Click(object sender, EventArgs e) { }
        private void PassTextBox_TextChanged(object sender, EventArgs e) { }

        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }

        private void UserTextbox_TextChanged(object sender, EventArgs e) { }

        private void regist_Click(object sender, EventArgs e)
        {
            Form wrapper = new Form();
            wrapper.WindowState = FormWindowState.Maximized;
            wrapper.Text = "Customer Registration";

            UC_CustomerRegistration uc = new UC_CustomerRegistration();
            uc.Dock = DockStyle.Fill;
            wrapper.Controls.Add(uc);

            this.Hide();
            wrapper.Show();
        }
    }
}