namespace Ghotel
{
    partial class CustomerRoomView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRoomView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.DsExitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_CustomerRoomView1 = new Ghotel.UC_CustomerRoomView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_CustomerRoomView1);
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1347, 683);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Customer,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(192, 50);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(0, 24);
            this.labelCustomerName.TabIndex = 2;
            // 
            // DsExitBtn
            // 
            this.DsExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DsExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DsExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DsExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DsExitBtn.FillColor = System.Drawing.Color.Empty;
            this.DsExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DsExitBtn.ForeColor = System.Drawing.Color.White;
            this.DsExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("DsExitBtn.Image")));
            this.DsExitBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.DsExitBtn.Location = new System.Drawing.Point(0, -3);
            this.DsExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DsExitBtn.Name = "DsExitBtn";
            this.DsExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DsExitBtn.Size = new System.Drawing.Size(41, 41);
            this.DsExitBtn.TabIndex = 7;
            this.DsExitBtn.Click += new System.EventHandler(this.DsExitBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // uC_CustomerRoomView1
            // 
            this.uC_CustomerRoomView1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.uC_CustomerRoomView1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerRoomView1.Name = "uC_CustomerRoomView1";
            this.uC_CustomerRoomView1.Size = new System.Drawing.Size(1347, 683);
            this.uC_CustomerRoomView1.TabIndex = 0;
            this.uC_CustomerRoomView1.UserTextbox = null;
            // 
            // CustomerRoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 640);
            this.Controls.Add(this.DsExitBtn);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerRoomView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRoomView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerRoomView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCustomerName;
        private Guna.UI2.WinForms.Guna2CircleButton DsExitBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private UC_CustomerRoomView uC_CustomerRoomView1;
    }
}