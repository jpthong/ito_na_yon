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
    public partial class uc_Employee : UserControl
    {
        function fn = new function();
        string query;
        public uc_Employee()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void uc_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (tb_emp_name.Text != "" && tb_emp_mobile.Text != "" && cb_emp_gender.Text != "" && tb_emp_email.Text != "" && tb_emp_username.Text != "" && tb_emp_username.Text != "")
            {
                string name = tb_emp_name.Text;
                Int64 mobile = Int64.Parse(tb_emp_mobile.Text);
                string gender = cb_emp_gender.Text;
                string email = tb_emp_email.Text;
                string username = tb_emp_username.Text;
                string password = tb_emp_password.Text;

                query = "INSERT INTO employee (emp_name, emp_mobile, emp_gender, emp_email, emp_username, emp_password) " +
                    "VALUES ('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + password + "')";

                fn.setData(query, "Employee Added.");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }

            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);

            }


        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation...!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from employee where emp_id = " + tb_emp_id.Text + "";
                fn.setData(query, "Employee Deleted.");
                tabControl1_SelectedIndexChanged(this, null);
            }

        }
        private void uc_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        public void getMaxID()
        {
            query = "select max(emp_id) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelEmp_id.Text = (num + 1).ToString();

            }
        }

        public void clearAll()
        {
            tb_emp_name.Clear();
            tb_emp_mobile.Clear();
            cb_emp_gender.SelectedIndex = -1;
            tb_emp_email.Clear();
            tb_emp_username.Clear();
            tb_emp_password.Clear();

        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
