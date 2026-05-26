namespace Ghotel.All_user
{
    partial class CustomerCheckOut
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Co_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckoutGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.listName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckoutRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.custom_checkoutBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Check Out";
            // 
            // Co_name
            // 
            this.Co_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Co_name.DefaultText = "";
            this.Co_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Co_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Co_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Co_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Co_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Co_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Co_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Co_name.Location = new System.Drawing.Point(470, 91);
            this.Co_name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Co_name.Name = "Co_name";
            this.Co_name.PlaceholderText = "Enter Full Name";
            this.Co_name.SelectedText = "";
            this.Co_name.Size = new System.Drawing.Size(176, 29);
            this.Co_name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Co_name.TabIndex = 12;
            this.Co_name.TextChanged += new System.EventHandler(this.Co_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // CheckoutGrid
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.CheckoutGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckoutGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CheckoutGrid.ColumnHeadersHeight = 4;
            this.CheckoutGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckoutGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.CheckoutGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CheckoutGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CheckoutGrid.Location = new System.Drawing.Point(13, 145);
            this.CheckoutGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CheckoutGrid.Name = "CheckoutGrid";
            this.CheckoutGrid.ReadOnly = true;
            this.CheckoutGrid.RowHeadersVisible = false;
            this.CheckoutGrid.RowHeadersWidth = 51;
            this.CheckoutGrid.RowTemplate.Height = 24;
            this.CheckoutGrid.Size = new System.Drawing.Size(1381, 340);
            this.CheckoutGrid.TabIndex = 13;
            this.CheckoutGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CheckoutGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CheckoutGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CheckoutGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CheckoutGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CheckoutGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CheckoutGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CheckoutGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CheckoutGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CheckoutGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CheckoutGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CheckoutGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.CheckoutGrid.ThemeStyle.ReadOnly = true;
            this.CheckoutGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CheckoutGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CheckoutGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CheckoutGrid.ThemeStyle.RowsStyle.Height = 24;
            this.CheckoutGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CheckoutGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CheckoutGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckoutGrid_CellClick);
            this.CheckoutGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CheckoutGrid_CellContentClick_1);
            this.CheckoutGrid.Leave += new System.EventHandler(this.CheckoutGrid_Leave);
            // 
            // listName
            // 
            this.listName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listName.DefaultText = "";
            this.listName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.listName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.listName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.listName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.listName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listName.Location = new System.Drawing.Point(64, 544);
            this.listName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listName.Name = "listName";
            this.listName.PlaceholderText = "Enter Full Name";
            this.listName.ReadOnly = true;
            this.listName.SelectedText = "";
            this.listName.Size = new System.Drawing.Size(176, 29);
            this.listName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.listName.TabIndex = 15;
            this.listName.TextChanged += new System.EventHandler(this.listName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name:";
            // 
            // CheckoutRoomNumber
            // 
            this.CheckoutRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CheckoutRoomNumber.DefaultText = "";
            this.CheckoutRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CheckoutRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CheckoutRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CheckoutRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CheckoutRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckoutRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckoutRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CheckoutRoomNumber.Location = new System.Drawing.Point(497, 544);
            this.CheckoutRoomNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CheckoutRoomNumber.Name = "CheckoutRoomNumber";
            this.CheckoutRoomNumber.PlaceholderText = "Enter Full Name";
            this.CheckoutRoomNumber.ReadOnly = true;
            this.CheckoutRoomNumber.SelectedText = "";
            this.CheckoutRoomNumber.Size = new System.Drawing.Size(176, 29);
            this.CheckoutRoomNumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CheckoutRoomNumber.TabIndex = 17;
            this.CheckoutRoomNumber.TextChanged += new System.EventHandler(this.CheckoutRoomNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 522);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Room no.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(888, 522);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Check Out Date";
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.Checked = true;
            this.CheckOutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.CheckOutDate.Location = new System.Drawing.Point(854, 544);
            this.CheckOutDate.Margin = new System.Windows.Forms.Padding(2);
            this.CheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CheckOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(202, 29);
            this.CheckOutDate.TabIndex = 19;
            this.CheckOutDate.Value = new System.DateTime(2026, 5, 23, 3, 43, 48, 395);
            // 
            // custom_checkoutBtn
            // 
            this.custom_checkoutBtn.BorderRadius = 20;
            this.custom_checkoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.custom_checkoutBtn.CheckedState.FillColor = System.Drawing.Color.Aqua;
            this.custom_checkoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.custom_checkoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.custom_checkoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.custom_checkoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.custom_checkoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.custom_checkoutBtn.ForeColor = System.Drawing.Color.White;
            this.custom_checkoutBtn.Location = new System.Drawing.Point(1202, 544);
            this.custom_checkoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.custom_checkoutBtn.Name = "custom_checkoutBtn";
            this.custom_checkoutBtn.Size = new System.Drawing.Size(135, 37);
            this.custom_checkoutBtn.TabIndex = 20;
            this.custom_checkoutBtn.Text = "Check Out";
            this.custom_checkoutBtn.Click += new System.EventHandler(this.custom_checkoutBtn_Click);
            // 
            // CustomerCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.custom_checkoutBtn);
            this.Controls.Add(this.CheckOutDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckoutRoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckoutGrid);
            this.Controls.Add(this.Co_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerCheckOut";
            this.Size = new System.Drawing.Size(1414, 683);
            this.Load += new System.EventHandler(this.CustomerCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Co_name;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView CheckoutGrid;
        private Guna.UI2.WinForms.Guna2TextBox listName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox CheckoutRoomNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker CheckOutDate;
        private Guna.UI2.WinForms.Guna2Button custom_checkoutBtn;
    }
}
