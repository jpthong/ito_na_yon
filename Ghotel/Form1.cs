using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ghotel.All_user;  

namespace Ghotel
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;

        public Form1()
        {
            InitializeComponent();
            PassTextBox.KeyPress += PassTextBox_KeyPress;
            this.AcceptButton = LoginBtn; 
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            // Admin hardcoded
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

            // Nothing matched
            Errorlbl.Visible = true;
            PassTextBox.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerSignUp_Click(object sender, EventArgs e)
        {
                CustomerSignIn csi = new CustomerSignIn();
                this.Hide();
                csi.Show();
            /*
            Errorlbl.Visible = false;
            CustomerDashboard cd = new CustomerDashboard();
            this.Hide();
            cd.Show();
            return;
            */
        }

        private void Errorlbl_Click(object sender, EventArgs e)
        {

        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }

        private void UserTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void regist_Click(object sender, EventArgs e)
        {
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
}