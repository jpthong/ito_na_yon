using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Ghotel.All_user
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        long roomId;
        String query;     
        

        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }


        public void setComboBox(string query, ComboBox combo)
        {
            combo.Items.Clear();
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    combo.Items.Add(row[0].ToString().Trim());
                }
            }

            // DEBUG
            MessageBox.Show("Items loaded: " + combo.Items.Count, "Debug");
        }



        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void ct_rt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct_rn.Items.Clear();
            ct_pr.Clear();
            query = "SELECT room_number FROM addrooms WHERE bed = '" + ct_bed.Text.Trim() + "' AND room_type = '" + ct_rt.Text.Trim() + "' AND booked = 'NO'";
            setComboBox(query, ct_rn);
        }

        private void ct_bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct_rt.SelectedIndex = -1;
            
            ct_rn.Items.Clear();
            
        
            
        }


        long rid;
        private void ct_rn_SelectedIndexChanged(object sender, EventArgs e)
        {

            query = "SELECT price, room_id FROM addrooms WHERE room_number = " + ct_rn.Text.Trim();
            DataSet ds = fn.getData(query);
            ct_pr.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = long.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void ct_pr_TextChanged(object sender, EventArgs e) { }


        private void AllocateBtn_Click(object sender, EventArgs e)
        {
            if (ct_name.Text != "" && ct_no.Text != "" && ct_nation.Text != "" &&
    ct_gen.Text != "" && birthTxt.Text != "" && ct_id.Text != "" &&
    ct_address.Text != "" && checkinTxt.Text != "" && ct_pr.Text != "" &&
    ct_username.Text != "" && ct_password.Text != "")

            {
                    
                String cname = ct_name.Text;
                Int64 contact = Int64.Parse(ct_no.Text);
                String nation = ct_nation.Text;
                String gender = ct_gen.Text;
                String dob = birthTxt.Value.ToString("yyyy-MM-dd");
                String id = ct_id.Text;
                String address = ct_address.Text;
                String checkin = checkinTxt.Value.ToString("yyyy-MM-dd");
                String username = ct_username.Text;    
                String password = ct_password.Text;

                query = "INSERT INTO customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, room_id, cust_username, cust_password) VALUES ('" + cname + "'," + contact + ",'" + nation + "','" + gender + "','" + dob + "','" + id + "','" + address + "','" + checkin + "'," + rid + ",'"
                + username + "','"   
                + password + "')";
                fn.setData(query, "Customer Registered.");

                query = "UPDATE addrooms SET booked = 'YES' WHERE room_number = " + ct_rn.Text.Trim();
                fn.setData(query, "Room allocated.");

            }

            else
            {
                MessageBox.Show("Please fill all the fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

       

        // -------------------------------------------------------
        // CLEAR ALL FIELDS
        // -------------------------------------------------------
        /*
        public void clearAll()
        {
            ct_name.Clear();
            ct_no.Clear();
            ct_nation.Clear();
            ct_gen.SelectedIndex = -1;  
            birthTxt.Value = DateTime.Now;
            ct_id.Clear();
            ct_address.Clear();
            checkinTxt.Value = DateTime.Now;
            ct_rt.SelectedIndex = -1;
            ct_bed.SelectedIndex = -1;
            ct_rn.Items.Clear();
            ct_pr.Clear();
            roomId = 0;
        }
        */





    }
}