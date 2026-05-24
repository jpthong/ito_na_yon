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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void DsExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CrBtn_Click(object sender, EventArgs e)
        {
            Moving_panel.Left = CrBtn.Left+18;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        private void AddrmBtn_Click(object sender, EventArgs e)
        {
            Moving_panel.Left = AddrmBtn.Left+18;  
            addroom1.BringToFront();
            addroom1.Visible = true;
        }

        private void CoBtn_Click(object sender, EventArgs e)
        {

            Moving_panel.Left = CoBtn.Left + 18;
            customerCheckOut1.Visible = true; 
            customerCheckOut1.BringToFront();

        }

        private void CdBtn_Click(object sender, EventArgs e)
        {
            uC_CustomerDetails11.Visible = true;
            Moving_panel.Left = CdBtn.Left + 18;
            uC_CustomerDetails11.BringToFront();
        }

        private void EmpBtn_Click(object sender, EventArgs e)
        {   
           uc_Employee1.Visible = true;
            Moving_panel.Left = EmpBtn.Left+18;
           uc_Employee1.BringToFront();
        }

        private void MiniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addroom1_Load(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addroom1.Visible = false;
           uC_CustomerRegistration1.Visible = false;
            uc_Employee1.Visible = false;
            customerCheckOut1.Visible = false;
            AddrmBtn.PerformClick();
        }
        /*
private void guna2Button3_Click(object sender, EventArgs e)
{

}
*/

    }
}
