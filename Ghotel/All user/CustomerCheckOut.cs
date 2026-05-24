using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghotel.All_user
{
    public partial class CustomerCheckOut : UserControl
    {

        function fn = new function();
        string query;
        public CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,addrooms.room_number,addrooms.room_type,addrooms.bed,addrooms.price from customer inner join addrooms on customer.room_id=addrooms.room_id where checkout='NO' ";
            DataSet ds = fn.getData(query);
            CheckoutGrid.DataSource = ds.Tables[0];
        }

        private void Co_name_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin,addrooms.room_number,addrooms.room_type,addrooms.bed,addrooms.price from customer inner join addrooms on customer.room_id=addrooms.room_id where cname like '" + Co_name.Text + "%' and checkout='NO'";
            DataSet ds = fn.getData(query);
            CheckoutGrid.DataSource = ds.Tables[0];

        }
        int id;
        private void CheckoutGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void listName_TextChanged(object sender, EventArgs e)
        {

        }

        private void custom_checkoutBtn_Click(object sender, EventArgs e)
        {
            if (listName.Text != "" && id != 0)  
            {
                if (MessageBox.Show("Are you sure you want to check out this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)  // <-- Yes, hindi OK
                {
                    String cdate = CheckOutDate.Text;

                    query = "update customer set checkout='YES', checkoutdate='" + cdate + "' where cid=" + id + "; update addrooms set booked='NO' where room_number='" + CheckoutRoomNumber.Text + "'";
                    fn.setData(query, "Customer checked out successfully.");
                    query = "Delete from customer where cid=" + id ;
                    fn.setData(query, "Customer record deleted successfully.");
                    CustomerCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to check out.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            Co_name.Clear();
            listName.Clear();
            CheckoutRoomNumber.Clear();
            CheckOutDate.ResetText();
        }

        private void CheckoutGrid_Leave(object sender, EventArgs e)
        {
           // clearAll(); 
        }

        private void CheckoutGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CheckoutGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(CheckoutGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                listName.Text = CheckoutGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                CheckoutRoomNumber.Text = CheckoutGrid.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }
    }
}
