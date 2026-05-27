namespace Ghotel.All_user
{
    partial class Addroom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.roomgrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.RmTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTexbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomtypeTextbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BedTextbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddrmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Room";
            // 
            // roomgrid
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.roomgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.roomgrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.roomgrid.ColumnHeadersHeight = 4;
            this.roomgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomgrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.roomgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomgrid.Location = new System.Drawing.Point(19, 45);
            this.roomgrid.Margin = new System.Windows.Forms.Padding(2);
            this.roomgrid.Name = "roomgrid";
            this.roomgrid.RowHeadersVisible = false;
            this.roomgrid.RowHeadersWidth = 51;
            this.roomgrid.RowTemplate.Height = 24;
            this.roomgrid.Size = new System.Drawing.Size(826, 509);
            this.roomgrid.TabIndex = 1;
            this.roomgrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.roomgrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.roomgrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.roomgrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.roomgrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.roomgrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.roomgrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomgrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.roomgrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.roomgrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomgrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.roomgrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.roomgrid.ThemeStyle.HeaderStyle.Height = 4;
            this.roomgrid.ThemeStyle.ReadOnly = false;
            this.roomgrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.roomgrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.roomgrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomgrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomgrid.ThemeStyle.RowsStyle.Height = 24;
            this.roomgrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.roomgrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.roomgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomgrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(915, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Number";
            // 
            // RmTextbox
            // 
            this.RmTextbox.BackColor = System.Drawing.Color.White;
            this.RmTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RmTextbox.DefaultText = "";
            this.RmTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RmTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RmTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RmTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RmTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RmTextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RmTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RmTextbox.Location = new System.Drawing.Point(917, 153);
            this.RmTextbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RmTextbox.Name = "RmTextbox";
            this.RmTextbox.PlaceholderText = "";
            this.RmTextbox.SelectedText = "";
            this.RmTextbox.Size = new System.Drawing.Size(338, 29);
            this.RmTextbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RmTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(915, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(915, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bed";
            // 
            // PriceTexbox
            // 
            this.PriceTexbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTexbox.DefaultText = "";
            this.PriceTexbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceTexbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceTexbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTexbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceTexbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTexbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PriceTexbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceTexbox.Location = new System.Drawing.Point(917, 350);
            this.PriceTexbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PriceTexbox.Name = "PriceTexbox";
            this.PriceTexbox.PlaceholderText = "";
            this.PriceTexbox.SelectedText = "";
            this.PriceTexbox.Size = new System.Drawing.Size(338, 30);
            this.PriceTexbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PriceTexbox.TabIndex = 9;
            this.PriceTexbox.TextChanged += new System.EventHandler(this.PriceTexbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(915, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // RoomtypeTextbox
            // 
            this.RoomtypeTextbox.BackColor = System.Drawing.Color.Transparent;
            this.RoomtypeTextbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomtypeTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomtypeTextbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomtypeTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomtypeTextbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomtypeTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoomtypeTextbox.ItemHeight = 30;
            this.RoomtypeTextbox.Items.AddRange(new object[] {
            "econo",
            "premium",
            "deluxe"});
            this.RoomtypeTextbox.Location = new System.Drawing.Point(917, 219);
            this.RoomtypeTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.RoomtypeTextbox.Name = "RoomtypeTextbox";
            this.RoomtypeTextbox.Size = new System.Drawing.Size(339, 36);
            this.RoomtypeTextbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.RoomtypeTextbox.TabIndex = 10;
            // 
            // BedTextbox
            // 
            this.BedTextbox.BackColor = System.Drawing.Color.Transparent;
            this.BedTextbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BedTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BedTextbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BedTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BedTextbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BedTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.BedTextbox.ItemHeight = 30;
            this.BedTextbox.Items.AddRange(new object[] {
            "Single bed",
            "Double bed",
            "Triple bed"});
            this.BedTextbox.Location = new System.Drawing.Point(917, 289);
            this.BedTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.BedTextbox.Name = "BedTextbox";
            this.BedTextbox.Size = new System.Drawing.Size(330, 36);
            this.BedTextbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.BedTextbox.TabIndex = 11;
            // 
            // AddrmBtn
            // 
            this.AddrmBtn.BorderRadius = 23;
            this.AddrmBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.AddrmBtn.BorderThickness = 1;
            this.AddrmBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.AddrmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddrmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddrmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddrmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddrmBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddrmBtn.ForeColor = System.Drawing.Color.White;
            this.AddrmBtn.Location = new System.Drawing.Point(1042, 387);
            this.AddrmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddrmBtn.Name = "AddrmBtn";
            this.AddrmBtn.Size = new System.Drawing.Size(135, 37);
            this.AddrmBtn.TabIndex = 12;
            this.AddrmBtn.Text = "Add Room";
            this.AddrmBtn.Click += new System.EventHandler(this.AddrmBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Addroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddrmBtn);
            this.Controls.Add(this.BedTextbox);
            this.Controls.Add(this.RoomtypeTextbox);
            this.Controls.Add(this.PriceTexbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RmTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomgrid);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Addroom";
            this.Size = new System.Drawing.Size(1347, 683);
            this.Load += new System.EventHandler(this.Addroom_Load);
            this.Enter += new System.EventHandler(this.Addroom_Enter);
            this.Leave += new System.EventHandler(this.Addroom_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.roomgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView roomgrid;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox RmTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox PriceTexbox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox RoomtypeTextbox;
        private Guna.UI2.WinForms.Guna2ComboBox BedTextbox;
        private Guna.UI2.WinForms.Guna2Button AddrmBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
