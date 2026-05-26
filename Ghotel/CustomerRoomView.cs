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
    public partial class CustomerRoomView : Form
    {
       

        public CustomerRoomView(string username)
        {
            InitializeComponent();
            labelCustomerName.Text = username;
            uC_CustomerRoomView1.UserTextbox = username;
        }

        private void CustomerRoomView_Load(object sender, EventArgs e)
        {
            
        }

        private void DsExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uC_CustomerRoomView1_Load(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void uC_CustomerRoomView1_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_CustomerRoomView1_Load_2(object sender, EventArgs e)
        {

        }
    }
}