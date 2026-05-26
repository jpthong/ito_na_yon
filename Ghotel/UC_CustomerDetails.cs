using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ghotel
{
    public partial class uC_CustomerDetails1 : UserControl
    {

        function fn = new function();
        String query;
        public uC_CustomerDetails1()
        {
            InitializeComponent();
        }

        private void UC_CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void cb_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baseQuery = "SELECT cid, cname, mobile, nationality, gender, dob, idproof, " +
                               "address, checkin, checkout, checkoutdate, room_type, bed, price " +
                               "FROM customer INNER JOIN addrooms ON customer.room_id = addrooms.room_id";

            if (cb_SortBy.SelectedIndex == 0)
            {
                query = baseQuery; // All customers
            }
            else if (cb_SortBy.SelectedIndex == 1)
            {
                query = baseQuery + " WHERE checkout = 'NO'"; // Currently checked in
            }
            else if (cb_SortBy.SelectedIndex == 2)
            {
                query = baseQuery + " WHERE checkout = 'YES'"; // Checked out
            }

            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
