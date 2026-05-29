namespace Ghotel
{
    partial class ExistingCustomerCheckIn1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExistingCustomerCheckIn1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ct_rn = new System.Windows.Forms.ComboBox();
            this.ct_rt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AllocateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ct_bed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ct_pr = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paylbl = new System.Windows.Forms.Label();
            this.Payment_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.payBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DiscountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Discount_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.chgelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check-in";
            // 
            // ct_rn
            // 
            this.ct_rn.FormattingEnabled = true;
            this.ct_rn.Location = new System.Drawing.Point(1007, 179);
            this.ct_rn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_rn.Name = "ct_rn";
            this.ct_rn.Size = new System.Drawing.Size(235, 25);
            this.ct_rn.TabIndex = 35;
            this.ct_rn.SelectedIndexChanged += new System.EventHandler(this.ct_rn_SelectedIndexChanged);
            // 
            // ct_rt
            // 
            this.ct_rt.BackColor = System.Drawing.Color.Transparent;
            this.ct_rt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ct_rt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_rt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_rt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_rt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ct_rt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ct_rt.ItemHeight = 30;
            this.ct_rt.Items.AddRange(new object[] {
            "econo",
            "premium",
            "deluxe"});
            this.ct_rt.Location = new System.Drawing.Point(647, 177);
            this.ct_rt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_rt.Name = "ct_rt";
            this.ct_rt.Size = new System.Drawing.Size(235, 36);
            this.ct_rt.TabIndex = 34;
            this.ct_rt.SelectedIndexChanged += new System.EventHandler(this.ct_rt_SelectedIndexChanged);
            // 
            // AllocateBtn
            // 
            this.AllocateBtn.BorderRadius = 20;
            this.AllocateBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.AllocateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllocateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllocateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllocateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllocateBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.AllocateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AllocateBtn.ForeColor = System.Drawing.Color.White;
            this.AllocateBtn.Location = new System.Drawing.Point(240, 438);
            this.AllocateBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AllocateBtn.Name = "AllocateBtn";
            this.AllocateBtn.Size = new System.Drawing.Size(181, 48);
            this.AllocateBtn.TabIndex = 33;
            this.AllocateBtn.Text = "Allocate Room";
            this.AllocateBtn.Click += new System.EventHandler(this.AllocateBtn_Click_1);
            // 
            // ct_bed
            // 
            this.ct_bed.BackColor = System.Drawing.Color.Transparent;
            this.ct_bed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ct_bed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_bed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_bed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_bed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ct_bed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ct_bed.ItemHeight = 30;
            this.ct_bed.Items.AddRange(new object[] {
            "Single bed",
            "Double bed",
            "Triple bed"});
            this.ct_bed.Location = new System.Drawing.Point(241, 177);
            this.ct_bed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_bed.Name = "ct_bed";
            this.ct_bed.Size = new System.Drawing.Size(235, 36);
            this.ct_bed.TabIndex = 32;
            this.ct_bed.SelectedIndexChanged += new System.EventHandler(this.ct_bed_SelectedIndexChanged);
            // 
            // ct_pr
            // 
            this.ct_pr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ct_pr.DefaultText = "";
            this.ct_pr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ct_pr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ct_pr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_pr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_pr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_pr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ct_pr.ForeColor = System.Drawing.Color.Black;
            this.ct_pr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_pr.Location = new System.Drawing.Point(241, 344);
            this.ct_pr.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ct_pr.Name = "ct_pr";
            this.ct_pr.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ct_pr.PlaceholderText = "Price";
            this.ct_pr.ReadOnly = true;
            this.ct_pr.SelectedText = "";
            this.ct_pr.Size = new System.Drawing.Size(234, 38);
            this.ct_pr.TabIndex = 31;
            this.ct_pr.TextChanged += new System.EventHandler(this.ct_pr_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(235, 316);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1001, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Room No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(641, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Room Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(238, 146);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Bed:";
            // 
            // paylbl
            // 
            this.paylbl.AutoSize = true;
            this.paylbl.BackColor = System.Drawing.Color.White;
            this.paylbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paylbl.ForeColor = System.Drawing.Color.Black;
            this.paylbl.Location = new System.Drawing.Point(1013, 286);
            this.paylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paylbl.Name = "paylbl";
            this.paylbl.Size = new System.Drawing.Size(97, 17);
            this.paylbl.TabIndex = 44;
            this.paylbl.Text = "Payment here:";
            this.paylbl.Visible = false;
            // 
            // Payment_box
            // 
            this.Payment_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Payment_box.DefaultText = "";
            this.Payment_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Payment_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Payment_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Payment_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Payment_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Payment_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Payment_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Payment_box.Location = new System.Drawing.Point(1006, 333);
            this.Payment_box.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Payment_box.Name = "Payment_box";
            this.Payment_box.PlaceholderText = "";
            this.Payment_box.SelectedText = "";
            this.Payment_box.Size = new System.Drawing.Size(234, 38);
            this.Payment_box.TabIndex = 43;
            this.Payment_box.Visible = false;
            this.Payment_box.TextChanged += new System.EventHandler(this.Payment_box_TextChanged);
            // 
            // payBtn
            // 
            this.payBtn.BorderRadius = 20;
            this.payBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.payBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(1033, 392);
            this.payBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.payBtn.Name = "payBtn";
            this.payBtn.PressedDepth = 20;
            this.payBtn.Size = new System.Drawing.Size(181, 48);
            this.payBtn.TabIndex = 42;
            this.payBtn.Text = "Pay";
            this.payBtn.Visible = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // DiscountBtn
            // 
            this.DiscountBtn.BorderRadius = 20;
            this.DiscountBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.DiscountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiscountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiscountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiscountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiscountBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.DiscountBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DiscountBtn.ForeColor = System.Drawing.Color.White;
            this.DiscountBtn.Location = new System.Drawing.Point(646, 403);
            this.DiscountBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DiscountBtn.Name = "DiscountBtn";
            this.DiscountBtn.Size = new System.Drawing.Size(181, 48);
            this.DiscountBtn.TabIndex = 47;
            this.DiscountBtn.Text = "Discount";
            this.DiscountBtn.Click += new System.EventHandler(this.DiscountBtn_Click_1);
            // 
            // Discount_box
            // 
            this.Discount_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Discount_box.DefaultText = "";
            this.Discount_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Discount_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Discount_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Discount_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Discount_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Discount_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Discount_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Discount_box.Location = new System.Drawing.Point(646, 344);
            this.Discount_box.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Discount_box.Name = "Discount_box";
            this.Discount_box.PlaceholderText = "Enter Promo Discount";
            this.Discount_box.SelectedText = "";
            this.Discount_box.Size = new System.Drawing.Size(234, 38);
            this.Discount_box.TabIndex = 46;
            this.Discount_box.TextChanged += new System.EventHandler(this.Discount_box_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(651, 307);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 17);
            this.label18.TabIndex = 45;
            this.label18.Text = "Promo Discount:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // chgelbl
            // 
            this.chgelbl.AutoSize = true;
            this.chgelbl.BackColor = System.Drawing.Color.White;
            this.chgelbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgelbl.ForeColor = System.Drawing.Color.Black;
            this.chgelbl.Location = new System.Drawing.Point(651, 496);
            this.chgelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chgelbl.Name = "chgelbl";
            this.chgelbl.Size = new System.Drawing.Size(52, 17);
            this.chgelbl.TabIndex = 48;
            this.chgelbl.Text = "change";
            this.chgelbl.Visible = false;
            this.chgelbl.Click += new System.EventHandler(this.chgelbl_Click);
            // 
            // ExistingCustomerCheckIn1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.chgelbl);
            this.Controls.Add(this.DiscountBtn);
            this.Controls.Add(this.Discount_box);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.paylbl);
            this.Controls.Add(this.Payment_box);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.ct_rn);
            this.Controls.Add(this.ct_rt);
            this.Controls.Add(this.AllocateBtn);
            this.Controls.Add(this.ct_bed);
            this.Controls.Add(this.ct_pr);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ExistingCustomerCheckIn1";
            this.Size = new System.Drawing.Size(1797, 893);
            this.Load += new System.EventHandler(this.ExistingCustomerCheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ct_rn;
        private Guna.UI2.WinForms.Guna2ComboBox ct_rt;
        private Guna.UI2.WinForms.Guna2Button AllocateBtn;
        private Guna.UI2.WinForms.Guna2ComboBox ct_bed;
        private Guna.UI2.WinForms.Guna2TextBox ct_pr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label paylbl;
        private Guna.UI2.WinForms.Guna2TextBox Payment_box;
        private Guna.UI2.WinForms.Guna2Button payBtn;
        private Guna.UI2.WinForms.Guna2Button DiscountBtn;
        private Guna.UI2.WinForms.Guna2TextBox Discount_box;
        private System.Windows.Forms.Label label18;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label chgelbl;
    }
}
