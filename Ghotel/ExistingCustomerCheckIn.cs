using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ghotel
{
    public partial class ExistingCustomerCheckIn1 : UserControl
    {
        function fn = new function();
        long roomId;
        string query;
        long rid;

        // ← ADD THESE MISSING VARIABLES
        decimal discountPercent = 0;
        decimal originalPrice = 0;
        decimal discountAmount = 0;
        decimal discountedPrice = 0;
        decimal vatAmount = 0;
        decimal totalAmount = 0;
        decimal paidAmount = 0;
        decimal changeAmount = 0;

        public ExistingCustomerCheckIn1()
        {
            InitializeComponent();
        }

        public void setComboBox(string query, ComboBox combo)
        {
            combo.Items.Clear();
            DataSet ds = fn.getData(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    combo.Items.Add(row[0].ToString().Trim());
                }
            }
        }

        private void computeTotal()
        {
            if (string.IsNullOrEmpty(ct_pr.Text)) return;

            if (decimal.TryParse(ct_pr.Text, out originalPrice))
            {
                discountAmount = originalPrice * (discountPercent / 100);
                discountedPrice = originalPrice - discountAmount;
                vatAmount = discountedPrice * 0.12m;
                totalAmount = discountedPrice + vatAmount;
            }
        }

        private void ExistingCustomerCheckIn_Load(object sender, EventArgs e) { }

        private void ct_bed_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct_rt.SelectedIndex = -1;
            ct_rn.Items.Clear();
            ct_pr.Clear();
        }

        private void ct_rt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ct_rn.Items.Clear();
            ct_pr.Clear();

            if (string.IsNullOrEmpty(ct_bed.Text) || string.IsNullOrEmpty(ct_rt.Text)) return;

            string bedType = ct_bed.Text.Trim().Replace("'", "''");
            string roomType = ct_rt.Text.Trim().Replace("'", "''");

            query = $"SELECT room_number FROM addrooms WHERE bed = '{bedType}' AND room_type = '{roomType}' AND booked = 'NO'";
            setComboBox(query, ct_rn);
        }

        private void ct_rn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ct_rn.Text)) return;

            string selectedRoom = ct_rn.Text.Trim().Replace("'", "''");
            string detailQuery = $"SELECT price, room_id FROM addrooms WHERE room_number = '{selectedRoom}'";
            DataSet ds = fn.getData(detailQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ct_pr.Text = ds.Tables[0].Rows[0][0].ToString();
                rid = long.Parse(ds.Tables[0].Rows[0][1].ToString());
                computeTotal();
            }
        }

        // ← ADD THIS DISCOUNT BUTTON
       

        // ← ADD THIS ALLOCATE BUTTON
        

        private void ct_pr_TextChanged(object sender, EventArgs e) { }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float pageWidth = e.PageBounds.Width;
            int y = 50;

            Font boldBig = new Font("Arial", 16, FontStyle.Bold);
            Font boldMed = new Font("Arial", 11, FontStyle.Bold);
            Font normal = new Font("Arial", 10, FontStyle.Regular);
            Font boldSmall = new Font("Arial", 10, FontStyle.Bold);

            string hotelName = "G Hotel";
            SizeF nameSize = g.MeasureString(hotelName, boldBig);
            g.DrawString(hotelName, boldBig, Brushes.Black, (pageWidth - nameSize.Width) / 2, y);
            y += (int)nameSize.Height + 2;

            string addr = "Your Hotel Address Here";
            SizeF addrSize = g.MeasureString(addr, normal);
            g.DrawString(addr, normal, Brushes.Black, (pageWidth - addrSize.Width) / 2, y);
            y += (int)addrSize.Height + 2;

            string tel = "Tel: +63 XXX XXX XXXX";
            SizeF telSize = g.MeasureString(tel, normal);
            g.DrawString(tel, normal, Brushes.Black, (pageWidth - telSize.Width) / 2, y);
            y += (int)telSize.Height + 15;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            g.DrawString("Room No.", boldSmall, Brushes.Black, 50, y);
            g.DrawString("Room Type", boldSmall, Brushes.Black, 200, y);
            g.DrawString("Price", boldSmall, Brushes.Black, pageWidth - 150, y);
            y += 22;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            g.DrawString(ct_rn.Text, normal, Brushes.Black, 50, y);
            g.DrawString(ct_rt.Text, normal, Brushes.Black, 200, y);
            g.DrawString(originalPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y);
            y += 30;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            g.DrawString("Original Price:", normal, Brushes.Black, 300, y);
            g.DrawString("PHP " + originalPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;

            if (discountPercent > 0)
            {
                g.DrawString("Promo Discount (" + discountPercent + "%):", normal, Brushes.Red, 300, y);
                g.DrawString("-PHP " + discountAmount.ToString("F2"), normal, Brushes.Red, pageWidth - 150, y); y += 22;
                g.DrawString("Discounted Price:", normal, Brushes.Black, 300, y);
                g.DrawString("PHP " + discountedPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;
            }

            g.DrawString("VAT (12%):", normal, Brushes.Black, 300, y);
            g.DrawString("PHP " + vatAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 10;

            string totalLabel = "TOTAL:  PHP " + totalAmount.ToString("F2");
            SizeF totalSize = g.MeasureString(totalLabel, boldMed);
            g.DrawString(totalLabel, boldMed, Brushes.Black, pageWidth - totalSize.Width - 50, y);
            y += 25;

            g.DrawString("Paid:", boldSmall, Brushes.Black, 300, y);
            g.DrawString("PHP " + paidAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 22;

            g.DrawString("Change:", boldSmall, Brushes.Black, 300, y);
            g.DrawString("PHP " + changeAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 150, y); y += 40;

            g.DrawLine(Pens.Black, 50, y, pageWidth - 50, y); y += 15;

            string footer1 = "~ Thank you for staying ~";
            string footer2 = "~ G Hotel ~";
            SizeF f1 = g.MeasureString(footer1, normal);
            SizeF f2 = g.MeasureString(footer2, normal);
            g.DrawString(footer1, normal, Brushes.Black, (pageWidth - f1.Width) / 2, y); y += 22;
            g.DrawString(footer2, normal, Brushes.Black, (pageWidth - f2.Width) / 2, y);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e) { }

        private void chgelbl_Click(object sender, EventArgs e) { }

        private void Payment_box_TextChanged(object sender, EventArgs e) { }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Payment_box.Text))
            {
                MessageBox.Show("Please enter payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Payment_box.Text, out decimal paymentAmount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (paymentAmount < totalAmount)
            {
                MessageBox.Show(
                    "Insufficient payment! Total is PHP " + totalAmount.ToString("F2"),
                    "Insufficient Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            paidAmount = paymentAmount;
            changeAmount = paymentAmount - totalAmount;

            // UPDATE ROOM STATUS
            query = $"UPDATE addrooms SET booked = 'YES' WHERE room_number = '{ct_rn.Text.Trim().Replace("'", "''")}'";
            fn.setData(query, null);


            DialogResult result = MessageBox.Show(
                "Payment Successful! ✅\n\n" +
                "Total: PHP " + totalAmount.ToString("F2") + "\n" +
                "Paid: PHP " + paymentAmount.ToString("F2") + "\n" +
                "Change: PHP " + changeAmount.ToString("F2") + "\n\n" +
                "Would you like to print your receipt?",
                "Payment Successful",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                printDocument1.PrintPage += printDocument1_PrintPage;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

            MessageBox.Show("Thank you! Please login to view your room details.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form parentForm = this.ParentForm;
            Form1 form1 = new Form1();
            parentForm?.Hide();
            form1.Show();
        }

        // ← ADD THIS HELPER
        private void ToggleInputControls(bool state)
        {
            ct_bed.Enabled = state;
            ct_rt.Enabled = state;
            ct_rn.Enabled = state;
            AllocateBtn.Enabled = state;
            DiscountBtn.Enabled = state;
            Discount_box.Enabled = state;
        }

        private void AllocateBtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ct_rn.Text) && !string.IsNullOrEmpty(ct_pr.Text))
            {
                computeTotal();

                MessageBox.Show(
                    "Room allocation successful.\n\n" +
                    "📋 Booking Summary:\n" +
                    "──────────────────────────\n" +
                    "Room No.   : " + ct_rn.Text + "\n" +
                    "Room Type  : " + ct_rt.Text + "\n" +
                    "Total Bill : PHP " + totalAmount.ToString("F2") + "\n" +
                    "──────────────────────────\n\n" +
                    "Proceed to payment.",
                    "Room Allocated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                paylbl.Visible = true;
                Payment_box.Visible = true;
                Payment_box.ReadOnly = false;
                Payment_box.Text = "";
                payBtn.Visible = true;

                ToggleInputControls(false);
            }
            else
            {
                MessageBox.Show(
                    "Please select Bed, Room Type, and Room Number first.",
                    "Incomplete Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void DiscountBtn_Click_1(object sender, EventArgs e)
        {
            string promoCode = Discount_box.Text.Trim().ToLower();

            if (promoCode == "antech the best")
            {
                discountPercent = 50;
                MessageBox.Show("🎉 Promo code applied! You get 50% discount!", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (promoCode == "ghotel10")
            {
                discountPercent = 10;
                MessageBox.Show("🎉 Promo code applied! You get 10% discount!", "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                discountPercent = 0;
                MessageBox.Show("❌ Invalid promo code! Please try again.", "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            computeTotal();
        }

        private void Discount_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}