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
    public partial class UC_CustomerRoomView : UserControl
    {
        string query;
        function fn = new function();

        public string UserTextbox { get; set; }

        public UC_CustomerRoomView()
        {
            InitializeComponent();
        }

        private void UC_CustomerRoomView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            if (string.IsNullOrEmpty(UserTextbox)) return;

            query = "SELECT " +
                    "customer.cid, " +
                    "customer.cname, " +
                    "customer.mobile, " +
                    "customer.nationality, " +
                    "customer.gender, " +
                    "customer.dob, " +
                    "customer.idproof, " +
                    "customer.address, " +
                    "customer.checkin, " +
                    "customer.checkout, " +
                    "customer.checkoutdate, " +
                    "addrooms.room_number, " +
                    "addrooms.booked, " +
                    "addrooms.room_type, " +
                    "addrooms.bed, " +
                    "addrooms.price " +
                    "FROM customer " +
                    "INNER JOIN addrooms ON customer.room_id = addrooms.room_id " +
                    "WHERE customer.cust_username = '" + UserTextbox + "' " +
                    "ORDER BY customer.cid DESC";

            DataSet ds = fn.getData(query);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                guna2DataGridView1.DataSource = null;
                guna2DataGridView1.Refresh();
                guna2DataGridView1.DataSource = ds.Tables[0];
                guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                guna2DataGridView1.Refresh();
            }
            else
            {
                guna2DataGridView1.DataSource = null;
                MessageBox.Show(
                    "No room details found for this account.",
                    "No Data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            parentForm?.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void doneBtn_Click_1(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            parentForm?.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}