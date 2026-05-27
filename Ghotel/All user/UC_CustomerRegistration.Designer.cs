using System;

namespace Ghotel.All_user
{
    partial class UC_CustomerRegistration
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CustomerRegistration));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.birthTxt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkinTxt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ct_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.ct_no = new Guna.UI2.WinForms.Guna2TextBox();
            this.ct_nation = new Guna.UI2.WinForms.Guna2TextBox();
            this.ct_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.ct_pr = new Guna.UI2.WinForms.Guna2TextBox();
            this.ct_gen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ct_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.ct_bed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AllocateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ct_rt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ct_rn = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.payBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Payment_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Discount_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.DiscountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.paylbl = new System.Windows.Forms.Label();
            this.chgelbl = new System.Windows.Forms.Label();
            this.startCameraBtn = new System.Windows.Forms.Button();
            this.captureBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Registration";
            // 
            // birthTxt
            // 
            this.birthTxt.Checked = true;
            this.birthTxt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.birthTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.birthTxt.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.birthTxt.Location = new System.Drawing.Point(26, 387);
            this.birthTxt.Margin = new System.Windows.Forms.Padding(2);
            this.birthTxt.MaxDate = new System.DateTime(2026, 5, 27, 0, 0, 0, 0);
            this.birthTxt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.birthTxt.Name = "birthTxt";
            this.birthTxt.Size = new System.Drawing.Size(188, 22);
            this.birthTxt.TabIndex = 2;
            this.birthTxt.Value = new System.DateTime(2026, 5, 22, 4, 21, 23, 167);
            // 
            // checkinTxt
            // 
            this.checkinTxt.Checked = true;
            this.checkinTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkinTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkinTxt.Location = new System.Drawing.Point(270, 226);
            this.checkinTxt.Margin = new System.Windows.Forms.Padding(2);
            this.checkinTxt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkinTxt.MinDate = new System.DateTime(2026, 5, 26, 0, 0, 0, 0);
            this.checkinTxt.Name = "checkinTxt";
            this.checkinTxt.Size = new System.Drawing.Size(188, 18);
            this.checkinTxt.TabIndex = 2;
            this.checkinTxt.Value = new System.DateTime(2026, 5, 26, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nationality:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 354);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "ID Proof:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 146);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(283, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Check In:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bed:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(505, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Room Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(505, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Room No.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(505, 289);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Price:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 146);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Mobile No.";
            // 
            // ct_name
            // 
            this.ct_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ct_name.DefaultText = "";
            this.ct_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ct_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ct_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ct_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_name.Location = new System.Drawing.Point(26, 94);
            this.ct_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_name.Name = "ct_name";
            this.ct_name.PlaceholderText = "Enter Full Name";
            this.ct_name.SelectedText = "";
            this.ct_name.Size = new System.Drawing.Size(176, 29);
            this.ct_name.TabIndex = 10;
            this.ct_name.TextChanged += new System.EventHandler(this.ct_name_TextChanged);
            // 
            // ct_no
            // 
            this.ct_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ct_no.DefaultText = "";
            this.ct_no.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ct_no.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ct_no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_no.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_no.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_no.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ct_no.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_no.Location = new System.Drawing.Point(26, 175);
            this.ct_no.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_no.Name = "ct_no";
            this.ct_no.PlaceholderText = "Enter Contact No.";
            this.ct_no.SelectedText = "";
            this.ct_no.Size = new System.Drawing.Size(176, 29);
            this.ct_no.TabIndex = 11;
            // 
            // ct_nation
            // 
            this.ct_nation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ct_nation.DefaultText = "";
            this.ct_nation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ct_nation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ct_nation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_nation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_nation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_nation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ct_nation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_nation.Location = new System.Drawing.Point(26, 250);
            this.ct_nation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_nation.Name = "ct_nation";
            this.ct_nation.PlaceholderText = "Enter Nationality";
            this.ct_nation.SelectedText = "";
            this.ct_nation.Size = new System.Drawing.Size(176, 29);
            this.ct_nation.TabIndex = 12;
            // 
            // ct_id
            // 
            this.ct_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ct_id.DefaultText = "";
            this.ct_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ct_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ct_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ct_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_id.Location = new System.Drawing.Point(271, 96);
            this.ct_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_id.Name = "ct_id";
            this.ct_id.PlaceholderText = "Enter ID";
            this.ct_id.SelectedText = "";
            this.ct_id.Size = new System.Drawing.Size(176, 29);
            this.ct_id.TabIndex = 13;
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
            this.ct_pr.Location = new System.Drawing.Point(509, 310);
            this.ct_pr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_pr.Name = "ct_pr";
            this.ct_pr.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ct_pr.PlaceholderText = "Price";
            this.ct_pr.ReadOnly = true;
            this.ct_pr.SelectedText = "";
            this.ct_pr.Size = new System.Drawing.Size(176, 29);
            this.ct_pr.TabIndex = 18;
            this.ct_pr.TextChanged += new System.EventHandler(this.ct_pr_TextChanged);
            // 
            // ct_gen
            // 
            this.ct_gen.BackColor = System.Drawing.Color.Transparent;
            this.ct_gen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ct_gen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct_gen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_gen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_gen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ct_gen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ct_gen.ItemHeight = 30;
            this.ct_gen.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.ct_gen.Location = new System.Drawing.Point(26, 310);
            this.ct_gen.Margin = new System.Windows.Forms.Padding(2);
            this.ct_gen.Name = "ct_gen";
            this.ct_gen.Size = new System.Drawing.Size(177, 36);
            this.ct_gen.TabIndex = 19;
            // 
            // ct_address
            // 
            this.ct_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ct_address.DefaultText = "";
            this.ct_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ct_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ct_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ct_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ct_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ct_address.Location = new System.Drawing.Point(273, 173);
            this.ct_address.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ct_address.Name = "ct_address";
            this.ct_address.PlaceholderText = "Enter Full Address";
            this.ct_address.SelectedText = "";
            this.ct_address.Size = new System.Drawing.Size(176, 29);
            this.ct_address.TabIndex = 20;
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
            this.ct_bed.Location = new System.Drawing.Point(508, 96);
            this.ct_bed.Margin = new System.Windows.Forms.Padding(2);
            this.ct_bed.Name = "ct_bed";
            this.ct_bed.Size = new System.Drawing.Size(177, 36);
            this.ct_bed.TabIndex = 23;
            this.ct_bed.SelectedIndexChanged += new System.EventHandler(this.ct_bed_SelectedIndexChanged);
            // 
            // AllocateBtn
            // 
            this.AllocateBtn.BorderRadius = 30;
            this.AllocateBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.AllocateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllocateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllocateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllocateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllocateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AllocateBtn.ForeColor = System.Drawing.Color.White;
            this.AllocateBtn.Location = new System.Drawing.Point(509, 372);
            this.AllocateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AllocateBtn.Name = "AllocateBtn";
            this.AllocateBtn.Size = new System.Drawing.Size(135, 37);
            this.AllocateBtn.TabIndex = 24;
            this.AllocateBtn.Text = "Allocate Room";
            this.AllocateBtn.Click += new System.EventHandler(this.AllocateBtn_Click);
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
            this.ct_rt.Location = new System.Drawing.Point(509, 175);
            this.ct_rt.Margin = new System.Windows.Forms.Padding(2);
            this.ct_rt.Name = "ct_rt";
            this.ct_rt.Size = new System.Drawing.Size(177, 36);
            this.ct_rt.TabIndex = 25;
            this.ct_rt.SelectedIndexChanged += new System.EventHandler(this.ct_rt_SelectedIndexChanged);
            // 
            // ct_rn
            // 
            this.ct_rn.FormattingEnabled = true;
            this.ct_rn.Location = new System.Drawing.Point(509, 249);
            this.ct_rn.Margin = new System.Windows.Forms.Padding(2);
            this.ct_rn.Name = "ct_rn";
            this.ct_rn.Size = new System.Drawing.Size(177, 21);
            this.ct_rn.TabIndex = 26;
            this.ct_rn.SelectedIndexChanged += new System.EventHandler(this.ct_rn_SelectedIndexChanged);
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
            // 
            // payBtn
            // 
            this.payBtn.BorderRadius = 30;
            this.payBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.payBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(603, 495);
            this.payBtn.Margin = new System.Windows.Forms.Padding(2);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(135, 37);
            this.payBtn.TabIndex = 31;
            this.payBtn.Text = "Pay";
            this.payBtn.Visible = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
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
            this.Payment_box.Location = new System.Drawing.Point(387, 495);
            this.Payment_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Payment_box.Name = "Payment_box";
            this.Payment_box.PlaceholderText = "";
            this.Payment_box.SelectedText = "";
            this.Payment_box.Size = new System.Drawing.Size(176, 29);
            this.Payment_box.TabIndex = 33;
            this.Payment_box.Visible = false;
            this.Payment_box.TextChanged += new System.EventHandler(this.Payment_box_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(287, 299);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 18);
            this.label18.TabIndex = 37;
            this.label18.Text = "Promo Discount:";
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
            this.Discount_box.Location = new System.Drawing.Point(282, 327);
            this.Discount_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Discount_box.Name = "Discount_box";
            this.Discount_box.PlaceholderText = "Enter Promo Discount";
            this.Discount_box.SelectedText = "";
            this.Discount_box.Size = new System.Drawing.Size(176, 29);
            this.Discount_box.TabIndex = 39;
            this.Discount_box.TextChanged += new System.EventHandler(this.Discount_box_TextChanged);
            // 
            // DiscountBtn
            // 
            this.DiscountBtn.BorderRadius = 30;
            this.DiscountBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.DiscountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DiscountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DiscountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DiscountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DiscountBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DiscountBtn.ForeColor = System.Drawing.Color.White;
            this.DiscountBtn.Location = new System.Drawing.Point(282, 372);
            this.DiscountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DiscountBtn.Name = "DiscountBtn";
            this.DiscountBtn.Size = new System.Drawing.Size(135, 37);
            this.DiscountBtn.TabIndex = 40;
            this.DiscountBtn.Text = "Discount";
            this.DiscountBtn.Click += new System.EventHandler(this.DiscountBtn_Click);
            // 
            // paylbl
            // 
            this.paylbl.AutoSize = true;
            this.paylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paylbl.Location = new System.Drawing.Point(392, 459);
            this.paylbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paylbl.Name = "paylbl";
            this.paylbl.Size = new System.Drawing.Size(103, 18);
            this.paylbl.TabIndex = 41;
            this.paylbl.Text = "Payment here:";
            this.paylbl.Visible = false;
            // 
            // chgelbl
            // 
            this.chgelbl.AutoSize = true;
            this.chgelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgelbl.Location = new System.Drawing.Point(384, 551);
            this.chgelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chgelbl.Name = "chgelbl";
            this.chgelbl.Size = new System.Drawing.Size(56, 18);
            this.chgelbl.TabIndex = 42;
            this.chgelbl.Text = "change";
            this.chgelbl.Visible = false;
            // 
            // startCameraBtn
            // 
            this.startCameraBtn.Location = new System.Drawing.Point(825, 404);
            this.startCameraBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startCameraBtn.Name = "startCameraBtn";
            this.startCameraBtn.Size = new System.Drawing.Size(162, 32);
            this.startCameraBtn.TabIndex = 32;
            this.startCameraBtn.Text = "Start Camera";
            this.startCameraBtn.UseVisualStyleBackColor = true;
            this.startCameraBtn.Click += new System.EventHandler(this.startCameraBtn_Click);
            // 
            // captureBtn
            // 
            this.captureBtn.Location = new System.Drawing.Point(1058, 404);
            this.captureBtn.Margin = new System.Windows.Forms.Padding(2);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(162, 32);
            this.captureBtn.TabIndex = 33;
            this.captureBtn.Text = "Capture Camera";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(769, 96);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(500, 287);
            this.pictureBox.TabIndex = 31;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // UC_CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Ghotel.Properties.Resources.last1;
            this.Controls.Add(this.chgelbl);
            this.Controls.Add(this.paylbl);
            this.Controls.Add(this.DiscountBtn);
            this.Controls.Add(this.Discount_box);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Payment_box);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.captureBtn);
            this.Controls.Add(this.startCameraBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ct_rn);
            this.Controls.Add(this.ct_rt);
            this.Controls.Add(this.AllocateBtn);
            this.Controls.Add(this.ct_bed);
            this.Controls.Add(this.ct_address);
            this.Controls.Add(this.ct_gen);
            this.Controls.Add(this.ct_pr);
            this.Controls.Add(this.ct_id);
            this.Controls.Add(this.ct_nation);
            this.Controls.Add(this.ct_no);
            this.Controls.Add(this.ct_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkinTxt);
            this.Controls.Add(this.birthTxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_CustomerRegistration";
            this.Size = new System.Drawing.Size(1347, 607);
            this.Load += new System.EventHandler(this.UC_CustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker checkinTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker birthTxt;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2ComboBox ct_gen;
        private Guna.UI2.WinForms.Guna2TextBox ct_pr;
        private Guna.UI2.WinForms.Guna2TextBox ct_id;
        private Guna.UI2.WinForms.Guna2TextBox ct_nation;
        private Guna.UI2.WinForms.Guna2TextBox ct_no;
        private Guna.UI2.WinForms.Guna2TextBox ct_name;
        private Guna.UI2.WinForms.Guna2ComboBox ct_bed;
        private Guna.UI2.WinForms.Guna2TextBox ct_address;
        private Guna.UI2.WinForms.Guna2Button AllocateBtn;
        private Guna.UI2.WinForms.Guna2ComboBox ct_rt;
        private System.Windows.Forms.ComboBox ct_rn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button payBtn;
        private Guna.UI2.WinForms.Guna2TextBox Payment_box;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox Discount_box;
        private Guna.UI2.WinForms.Guna2Button DiscountBtn;
        private System.Windows.Forms.Label paylbl;
        private System.Windows.Forms.Label chgelbl;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.Button startCameraBtn;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
