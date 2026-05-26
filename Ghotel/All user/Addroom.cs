using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ghotel.All_user
{
    public partial class Addroom : UserControl
    {
        function fn = new function();
        String query;
        public Addroom()
        {
            InitializeComponent();
        }

        private void Addroom_Load(object sender, EventArgs e)
        {
            query = "select * from Addrooms";
            DataSet ds = fn.getData(query);
            roomgrid.DataSource = ds.Tables[0];
        }

        private void AddrmBtn_Click(object sender, EventArgs e)
        {
            if (RmTextbox.Text != "" && RoomtypeTextbox.Text != "" && BedTextbox.Text != "" && PriceTexbox.Text != "")
            {
                String roomno = RmTextbox.Text;
                String type = RoomtypeTextbox.Text;
                String bed = BedTextbox.Text;
                Int64 price = Int64.Parse(PriceTexbox.Text);
                Int64 roomnoInt = Int64.Parse(RmTextbox.Text);
                query = "INSERT INTO addrooms (room_number, room_type, bed, price) VALUES (" + roomnoInt + ",'" + type + "','" + bed + "'," + price + ")";

                fn.setData(query, "Room added.");
                Addroom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Please fill all the fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearAll();
            }
        }

        public void clearAll()
        {
            RmTextbox.Clear();
            RoomtypeTextbox.SelectedIndex = -1;
            BedTextbox.SelectedIndex = -1;
            PriceTexbox.Clear();

        }

        private void Addroom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void Addroom_Enter(object sender, EventArgs e)
        {
            Addroom_Load(this, null);
        }

        private void PriceTexbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





