using Ghotel.All_user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghotel
{
    public partial class CustomerDashboard : Form
    {
        private string _username;
        private string _password;
        public CustomerDashboard(string username, string password)
        {
            InitializeComponent();
            _username = username;  
            _password = password;
        }
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.CustomerUsername = _username;
            uC_CustomerRegistration1.CustomerPassword = _password;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.Dock = DockStyle.Fill;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_CustomerRegistration1_Load(object sender, EventArgs e)
        {

        }
    }
}
