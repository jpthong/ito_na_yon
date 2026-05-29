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
        function fn = new function();
        string query;

        public CustomerRoomView(string username)
        {
            InitializeComponent();
            labelCustomerName.Text = username;
            uC_CustomerRoomView1.UserTextbox = username;
        }

        private void CustomerRoomView_Load(object sender, EventArgs e)
        {
            uC_CustomerRoomView1.LoadData();
        }

        private void DsExitBtn_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Close();
        }

        private void uC_CustomerRoomView1_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void uC_CustomerRoomView1_Load_2(object sender, EventArgs e)
        {
            uC_CustomerRoomView1.BringToFront();
        }

        private void checkInBtn_Click(object sender, EventArgs e)
        {
            ExistingCustomerCheckIn.Visible = true;
            uC_CustomerRoomView1.Visible = false;
            BringToFront();
        }

        private void roomDetailsBtn_Click(object sender, EventArgs e)
        {
            uC_CustomerRoomView1.Visible = true;
            uC_CustomerRoomView1.LoadData(); // ← REFRESH WHEN SWITCHING TO ROOM DETAILS
            ExistingCustomerCheckIn.Visible = false;
            BringToFront();
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            string username = labelCustomerName.Text;

            // CHECK IF MAY ACTIVE BOOKING
            string checkQuery = "SELECT cid, room_id FROM customer " +
                                "WHERE cust_username = '" + username + "' " +
                                "AND checkout = 'NO' " +
                                "ORDER BY cid DESC LIMIT 1";
            DataSet ds = fn.getData(checkQuery);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show(
                    "No active booking found for this account.",
                    "No Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // CONFIRM CHECKOUT
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to check out?\n\nCheckout Date: " + DateTime.Now.ToString("yyyy-MM-dd"),
                "Confirm Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            string today = DateTime.Now.ToString("yyyy-MM-dd");
            long roomId = long.Parse(ds.Tables[0].Rows[0]["room_id"].ToString());

            // UPDATE CHECKOUT TO YES + SET CHECKOUT DATE
            query = "UPDATE customer SET checkout = 'YES', checkoutdate = '" + today + "' " +
                    "WHERE cust_username = '" + username + "' " +
                    "AND checkout = 'NO' " +
                    "ORDER BY cid DESC LIMIT 1";
            fn.setData(query, null);

            // UPDATE ROOM TO AVAILABLE
            query = "UPDATE addrooms SET booked = 'NO' WHERE room_id = " + roomId;
            fn.setData(query, null);

            MessageBox.Show(
                "✅ Checkout Successful!\n\n" +
                "Checkout Date: " + today + "\n\n" +
                "Thank you for staying at G Hotel!",
                "Checkout Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // REFRESH ROOM DETAILS VIEW
            uC_CustomerRoomView1.LoadData();
            uC_CustomerRoomView1.Visible = true;
            ExistingCustomerCheckIn.Visible = false;
        }

        private void ExistingCustomerCheckIn_Load(object sender, EventArgs e) { }
    }
}