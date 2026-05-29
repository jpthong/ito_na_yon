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

        decimal discountPercent = 0;
        decimal originalPrice = 0;
        decimal discountAmount = 0;
        decimal discountedPrice = 0;
        decimal vatAmount = 0;
        decimal totalAmount = 0;
        decimal paidAmount = 0;
        decimal changeAmount = 0;

        public string CustomerUsername { get; set; }
        public string CustomerPassword { get; set; }

        public ExistingCustomerCheckIn1()
        {
            InitializeComponent();
        }

        public ExistingCustomerCheckIn1(string username, string password)
        {
            InitializeComponent();
            CustomerUsername = username;
            CustomerPassword = password;
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

        private void DiscountBtn_Click_1(object sender, EventArgs e)
        {
            string promoCode = Discount_box.Text.Trim().ToLower();

            if (promoCode == "antech the best")
            {
                discountPercent = 50;
                MessageBox.Show(
                    "🎉 Promo code applied!\n\nYou get 50% discount off your room price!",
                    "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (promoCode == "ghotel10")
            {
                discountPercent = 10;
                MessageBox.Show(
                    "🎉 Promo code applied!\n\nYou get 10% discount off your room price!",
                    "Discount Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                discountPercent = 0;
                MessageBox.Show(
                    "❌ Invalid promo code!\n\nThe code you entered does not exist.\nPlease try again.",
                    "Invalid Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            computeTotal();
        }

        private void AllocateBtn_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ct_rn.Text) && !string.IsNullOrEmpty(ct_pr.Text))
            {
                computeTotal();

                MessageBox.Show(
                    "✅ Room Allocated Successfully!\n\n" +
                    "📋 Booking Summary:\n" +
                    "──────────────────────────────\n" +
                    "  Room No.   : " + ct_rn.Text + "\n" +
                    "  Room Type  : " + ct_rt.Text + "\n" +
                    "  Bed Type   : " + ct_bed.Text + "\n" +
                    "  Room Price : PHP " + originalPrice.ToString("F2") + "\n" +
                    (discountPercent > 0 ?
                        "  Discount   : " + discountPercent + "% (-PHP " + discountAmount.ToString("F2") + ")\n" : "") +
                    "  VAT (12%)  : PHP " + vatAmount.ToString("F2") + "\n" +
                    "──────────────────────────────\n" +
                    "  TOTAL BILL : PHP " + totalAmount.ToString("F2") + "\n" +
                    "──────────────────────────────\n\n" +
                    "Please proceed to payment below. 💳",
                    "Room Allocated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                query = "UPDATE customer SET room_id = " + rid + " WHERE cid = (SELECT cid FROM customer ORDER BY cid DESC LIMIT 1)";
                fn.setData(query, null);

                query = "UPDATE customer SET checkout = 'NO' WHERE room_id = " + rid;
                fn.setData(query, null);

                query = "UPDATE customer SET checkoutdate = 'NO' WHERE room_id = " + rid;
                fn.setData(query, null);

                paylbl.Visible = true;
                Payment_box.Visible = true;
                Payment_box.ReadOnly = false;
                Payment_box.Text = "";
                Payment_box.Focus();
                payBtn.Visible = true;

                ToggleInputControls(false);
            }
            else
            {
                MessageBox.Show(
                    "⚠️ Incomplete Selection!\n\n" +
                    "Please make sure you have selected:\n" +
                    "  • Bed Type\n" +
                    "  • Room Type\n" +
                    "  • Room Number\n\n" +
                    "All fields are required before allocating a room.",
                    "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Payment_box.Text))
            {
                MessageBox.Show(
                    "⚠️ No Payment Entered!\n\n" +
                    "Please enter the payment amount to continue.",
                    "Payment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(Payment_box.Text, out decimal paymentAmount))
            {
                MessageBox.Show(
                    "❌ Invalid Amount!\n\n" +
                    "The value you entered is not a valid number.\n" +
                    "Please enter a correct payment amount.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (paymentAmount < totalAmount)
            {
                MessageBox.Show(
                    "❌ Insufficient Payment!\n\n" +
                    "The amount you entered is less than the total bill.\n\n" +
                    "  Total Due   : PHP " + totalAmount.ToString("F2") + "\n" +
                    "  You Entered : PHP " + paymentAmount.ToString("F2") + "\n" +
                    "  Short By    : PHP " + (totalAmount - paymentAmount).ToString("F2") + "\n\n" +
                    "Please enter the correct amount.",
                    "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            paidAmount = paymentAmount;
            changeAmount = paymentAmount - totalAmount;

            query = $"UPDATE addrooms SET booked = 'YES' WHERE room_number = '{ct_rn.Text.Trim().Replace("'", "''")}'";
            fn.setData(query, null);

            DialogResult result = MessageBox.Show(
                "💳 Payment Successful! ✅\n\n" +
                "──────────────────────────────\n" +
                "  Room No.   : " + ct_rn.Text + "\n" +
                "  Room Type  : " + ct_rt.Text + "\n" +
                "──────────────────────────────\n" +
                "  Total      : PHP " + totalAmount.ToString("F2") + "\n" +
                "  Paid       : PHP " + paymentAmount.ToString("F2") + "\n" +
                "  Change     : PHP " + changeAmount.ToString("F2") + "\n" +
                "──────────────────────────────\n\n" +
                "Would you like to print your receipt?",
                "Payment Successful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                printDocument1.PrintPage += printDocument1_PrintPage;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

            MessageBox.Show(
                "🏨 Thank You for Choosing G Hotel!\n\n" +
                "Your check-in has been completed successfully.\n" +
                "Please login to view your room details and enjoy your stay!",
                "Check-In Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form parentForm = this.ParentForm;
            Form1 form1 = new Form1();
            parentForm?.Hide();
            form1.Show();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float pageWidth = e.PageBounds.Width;
            int y = 40;

            Font boldHuge = new Font("Arial", 20, FontStyle.Bold);
            Font boldBig = new Font("Arial", 14, FontStyle.Bold);
            Font boldMed = new Font("Arial", 13, FontStyle.Bold);
            Font normal = new Font("Arial", 12, FontStyle.Regular);
            Font boldSmall = new Font("Arial", 12, FontStyle.Bold);
            Font italic = new Font("Arial", 11, FontStyle.Italic);

            string hotelName = "ANTECH HOTEL";
            SizeF nameSize = g.MeasureString(hotelName, boldHuge);
            g.DrawString(hotelName, boldHuge, Brushes.Black, (pageWidth - nameSize.Width) / 2, y);
            y += (int)nameSize.Height + 4;

            string addr = "Your Hotel Address Here";
            SizeF addrSize = g.MeasureString(addr, normal);
            g.DrawString(addr, normal, Brushes.Black, (pageWidth - addrSize.Width) / 2, y);
            y += (int)addrSize.Height + 4;

            string tel = "Tel: +63 XXX XXX XXXX";
            SizeF telSize = g.MeasureString(tel, normal);
            g.DrawString(tel, normal, Brushes.Black, (pageWidth - telSize.Width) / 2, y);
            y += (int)telSize.Height + 4;

            string receiptTitle = "OFFICIAL RECEIPT";
            SizeF rtSize = g.MeasureString(receiptTitle, boldBig);
            g.DrawString(receiptTitle, boldBig, Brushes.Black, (pageWidth - rtSize.Width) / 2, y);
            y += (int)rtSize.Height + 10;

            g.DrawLine(new Pen(Color.Black, 2), 40, y, pageWidth - 40, y); y += 12;

            g.DrawString("Date : " + DateTime.Now.ToString("MMMM dd, yyyy"), normal, Brushes.Black, 50, y); y += 24;
            g.DrawString("Time : " + DateTime.Now.ToString("hh:mm tt"), normal, Brushes.Black, 50, y); y += 24;
            y += 5;

            g.DrawLine(new Pen(Color.Black, 1), 40, y, pageWidth - 40, y); y += 12;

            g.DrawString("Room No.", boldSmall, Brushes.Black, 50, y);
            g.DrawString("Room Type", boldSmall, Brushes.Black, 220, y);
            g.DrawString("Bed", boldSmall, Brushes.Black, 420, y);
            g.DrawString("Price", boldSmall, Brushes.Black, pageWidth - 130, y);
            y += 26;

            g.DrawLine(new Pen(Color.Black, 1), 40, y, pageWidth - 40, y); y += 10;

            g.DrawString(ct_rn.Text, normal, Brushes.Black, 50, y);
            g.DrawString(ct_rt.Text, normal, Brushes.Black, 220, y);
            g.DrawString(ct_bed.Text, normal, Brushes.Black, 420, y);
            g.DrawString("PHP " + originalPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 130, y);
            y += 30;

            g.DrawLine(new Pen(Color.Black, 1), 40, y, pageWidth - 40, y); y += 12;

            g.DrawString("Original Price :", normal, Brushes.Black, 280, y);
            g.DrawString("PHP " + originalPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 130, y);
            y += 24;

            if (discountPercent > 0)
            {
                g.DrawString("Discount (" + discountPercent + "%) :", normal, Brushes.Red, 280, y);
                g.DrawString("-PHP " + discountAmount.ToString("F2"), normal, Brushes.Red, pageWidth - 130, y);
                y += 24;

                g.DrawString("Discounted Price :", normal, Brushes.Black, 280, y);
                g.DrawString("PHP " + discountedPrice.ToString("F2"), normal, Brushes.Black, pageWidth - 130, y);
                y += 24;
            }

            g.DrawString("VAT (12%) :", normal, Brushes.Black, 280, y);
            g.DrawString("PHP " + vatAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 130, y);
            y += 24;

            g.DrawLine(new Pen(Color.Black, 2), 40, y, pageWidth - 40, y); y += 12;

            string totalLabel = "TOTAL :   PHP " + totalAmount.ToString("F2");
            SizeF totalSize = g.MeasureString(totalLabel, boldMed);
            g.DrawString(totalLabel, boldMed, Brushes.Black, pageWidth - totalSize.Width - 40, y);
            y += 30;

            g.DrawString("Amount Paid :", boldSmall, Brushes.Black, 280, y);
            g.DrawString("PHP " + paidAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 130, y);
            y += 24;

            g.DrawString("Change :", boldSmall, Brushes.Black, 280, y);
            g.DrawString("PHP " + changeAmount.ToString("F2"), normal, Brushes.Black, pageWidth - 130, y);
            y += 40;

            g.DrawLine(new Pen(Color.Black, 2), 40, y, pageWidth - 40, y); y += 18;

            string footer1 = "~ Thank you for choosing G Hotel ~";
            string footer2 = "~ We hope to see you again! ~";
            SizeF f1 = g.MeasureString(footer1, italic);
            SizeF f2 = g.MeasureString(footer2, italic);
            g.DrawString(footer1, italic, Brushes.Black, (pageWidth - f1.Width) / 2, y); y += 24;
            g.DrawString(footer2, italic, Brushes.Black, (pageWidth - f2.Width) / 2, y);
        }

        private void ToggleInputControls(bool state)
        {
            ct_bed.Enabled = state;
            ct_rt.Enabled = state;
            ct_rn.Enabled = state;
            AllocateBtn.Enabled = state;
            DiscountBtn.Enabled = state;
            Discount_box.Enabled = state;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e) { }
        private void chgelbl_Click(object sender, EventArgs e) { }
        private void Payment_box_TextChanged(object sender, EventArgs e) { }
        private void ct_pr_TextChanged(object sender, EventArgs e) { }
        private void Discount_box_TextChanged(object sender, EventArgs e) { }
    }
}