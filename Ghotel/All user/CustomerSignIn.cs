using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghotel.All_user
{
    public partial class CustomerSignIn : Form
    {
        function fn = new function();
        public CustomerSignIn()
        {
            InitializeComponent();
        }

        private void ct_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerSignIn_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (Sgn_password.Text != Sgn_cmpassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ── Check username only ──
            string query = "select * from customer where cust_username = '"
                   + Username_sgn.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Username already exists! Please choose another.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Pumunta sa CustomerRegistrationForm
            MessageBox.Show("Registration successful! Please allocate your room.",
    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CustomerDashboard cd = new CustomerDashboard(Username_sgn.Text, Sgn_cmpassword.Text);
            this.Hide();
            cd.Show();
        }
        private void ct_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_sgn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
