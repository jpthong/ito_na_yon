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
            if (cb_SortBy.SelectedIndex == 0)
            {
                query = "select cid, customer, mobile, nationality, gender, dob, idproof," +
                    " address, checkin, checkout, room_type, bed, " +
                    "price from customer inner join addrooms on customer.room_id = addrooms.room_id";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }

            else if (cb_SortBy.SelectedIndex == 1)
            {
                query = "select cid, customer, mobile, nationality, gender, dob, idproof," +
                    " address, checkin, checkout, room_type, bed, " +
                    "price from customer inner join addrooms on customer.room_id = addrooms.room_id where checkout is NULL";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }

            else if (cb_SortBy.SelectedIndex == 1)
            {
                query = "select cid, customer, mobile, nationality, gender, dob, idproof," +
                    " address, checkin, checkout, room_type, bed, " +
                    "price from customer inner join addrooms on customer.room_id = addrooms.room_id where checkout is not NULL";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }

        }
    }
}
