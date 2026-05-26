namespace Ghotel.All_user
{
    partial class CustomerSignIn
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
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sgn_cmpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConfirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Sgn_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Username_sgn = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(541, 62);
            this.lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(350, 32);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Cutomer Sign in Account";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirm Password";
            // 
            // Sgn_cmpassword
            // 
            this.Sgn_cmpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sgn_cmpassword.DefaultText = "";
            this.Sgn_cmpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sgn_cmpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sgn_cmpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sgn_cmpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sgn_cmpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sgn_cmpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sgn_cmpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sgn_cmpassword.Location = new System.Drawing.Point(530, 436);
            this.Sgn_cmpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sgn_cmpassword.Name = "Sgn_cmpassword";
            this.Sgn_cmpassword.PlaceholderText = "Enter Password";
            this.Sgn_cmpassword.SelectedText = "";
            this.Sgn_cmpassword.Size = new System.Drawing.Size(235, 36);
            this.Sgn_cmpassword.TabIndex = 30;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BorderRadius = 20;
            this.ConfirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ConfirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ConfirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ConfirmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(530, 517);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(180, 45);
            this.ConfirmBtn.TabIndex = 31;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // Sgn_password
            // 
            this.Sgn_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sgn_password.DefaultText = "";
            this.Sgn_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sgn_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sgn_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sgn_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sgn_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sgn_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Sgn_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sgn_password.Location = new System.Drawing.Point(530, 310);
            this.Sgn_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sgn_password.Name = "Sgn_password";
            this.Sgn_password.PlaceholderText = "Enter Password";
            this.Sgn_password.SelectedText = "";
            this.Sgn_password.Size = new System.Drawing.Size(235, 36);
            this.Sgn_password.TabIndex = 32;
            // 
            // Username_sgn
            // 
            this.Username_sgn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_sgn.DefaultText = "";
            this.Username_sgn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username_sgn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username_sgn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_sgn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_sgn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_sgn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Username_sgn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_sgn.Location = new System.Drawing.Point(530, 191);
            this.Username_sgn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Username_sgn.Name = "Username_sgn";
            this.Username_sgn.PlaceholderText = "Enter Password";
            this.Username_sgn.SelectedText = "";
            this.Username_sgn.Size = new System.Drawing.Size(235, 36);
            this.Username_sgn.TabIndex = 33;
            this.Username_sgn.TextChanged += new System.EventHandler(this.Username_sgn_TextChanged);
            // 
            // CustomerSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 986);
            this.Controls.Add(this.Username_sgn);
            this.Controls.Add(this.Sgn_password);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.Sgn_cmpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CustomerSignIn";
            this.Text = "CustomerSignIn";
            this.Load += new System.EventHandler(this.CustomerSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox Sgn_cmpassword;
        private Guna.UI2.WinForms.Guna2Button ConfirmBtn;
        private Guna.UI2.WinForms.Guna2TextBox Sgn_password;
        private Guna.UI2.WinForms.Guna2TextBox Username_sgn;
    }
}