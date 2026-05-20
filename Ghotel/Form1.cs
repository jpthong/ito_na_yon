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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserTextbox.Text == "admin" && PassTextBox.Text == "admin123")
            {
              Errorlbl.Visible = false;
              Dashboard ds = new Dashboard();
            this.Hide();
                ds.Show();
            }
            else
            {
                
               Errorlbl.Visible = true;
                PassTextBox.Clear();
            }
        }
    }
}
