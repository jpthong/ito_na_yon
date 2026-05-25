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
            query = "SELECT cid, cname, mobile, nationality, gender, dob, idproof, " +
        "address, checkin, checkout, room_type, bed, price " +
        "FROM customer INNER JOIN addrooms ON customer.room_id = addrooms.room_id " +
        "WHERE customer.cust_username = '" + UserTextbox + "'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        public void LoadData()
        {
           
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            parentForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void doneBtn_Click_1(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            parentForm.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}