namespace Ghotel
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Moving_panel = new System.Windows.Forms.Panel();
            this.CoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EmpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CdBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CrBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddrmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.DsExitBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.MiniBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.addroom1 = new Ghotel.All_user.Addroom();
            this.panel1.SuspendLayout();
            this.MovingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Moving_panel);
            this.panel1.Controls.Add(this.CoBtn);
            this.panel1.Controls.Add(this.EmpBtn);
            this.panel1.Controls.Add(this.CdBtn);
            this.panel1.Controls.Add(this.CrBtn);
            this.panel1.Controls.Add(this.AddrmBtn);
            this.panel1.Location = new System.Drawing.Point(68, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 130);
            this.panel1.TabIndex = 0;
            // 
            // Moving_panel
            // 
            this.Moving_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Moving_panel.Location = new System.Drawing.Point(35, 112);
            this.Moving_panel.Name = "Moving_panel";
            this.Moving_panel.Size = new System.Drawing.Size(199, 5);
            this.Moving_panel.TabIndex = 0;
            // 
            // CoBtn
            // 
            this.CoBtn.BorderRadius = 26;
            this.CoBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CoBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.CoBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.CoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CoBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoBtn.ForeColor = System.Drawing.Color.White;
            this.CoBtn.Location = new System.Drawing.Point(507, 21);
            this.CoBtn.Name = "CoBtn";
            this.CoBtn.Size = new System.Drawing.Size(236, 85);
            this.CoBtn.TabIndex = 8;
            this.CoBtn.Text = "Check out";
            this.CoBtn.Click += new System.EventHandler(this.CoBtn_Click);
            // 
            // EmpBtn
            // 
            this.EmpBtn.BorderRadius = 26;
            this.EmpBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.EmpBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.EmpBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.EmpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EmpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EmpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EmpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EmpBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpBtn.ForeColor = System.Drawing.Color.White;
            this.EmpBtn.Location = new System.Drawing.Point(1000, 21);
            this.EmpBtn.Name = "EmpBtn";
            this.EmpBtn.Size = new System.Drawing.Size(236, 85);
            this.EmpBtn.TabIndex = 4;
            this.EmpBtn.Text = "Employee";
            this.EmpBtn.Click += new System.EventHandler(this.EmpBtn_Click);
            // 
            // CdBtn
            // 
            this.CdBtn.BorderRadius = 26;
            this.CdBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CdBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.CdBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.CdBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CdBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CdBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CdBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CdBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdBtn.ForeColor = System.Drawing.Color.White;
            this.CdBtn.Location = new System.Drawing.Point(749, 21);
            this.CdBtn.Name = "CdBtn";
            this.CdBtn.Size = new System.Drawing.Size(236, 85);
            this.CdBtn.TabIndex = 3;
            this.CdBtn.Text = "Customer Details";
            this.CdBtn.Click += new System.EventHandler(this.CdBtn_Click);
            // 
            // CrBtn
            // 
            this.CrBtn.BorderRadius = 26;
            this.CrBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CrBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.CrBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.CrBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CrBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CrBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CrBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CrBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrBtn.ForeColor = System.Drawing.Color.White;
            this.CrBtn.Location = new System.Drawing.Point(265, 21);
            this.CrBtn.Name = "CrBtn";
            this.CrBtn.Size = new System.Drawing.Size(236, 85);
            this.CrBtn.TabIndex = 1;
            this.CrBtn.Text = "Customer Registration";
            this.CrBtn.Click += new System.EventHandler(this.CrBtn_Click);
            // 
            // AddrmBtn
            // 
            this.AddrmBtn.BorderRadius = 26;
            this.AddrmBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddrmBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.AddrmBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.AddrmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddrmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddrmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddrmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddrmBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddrmBtn.ForeColor = System.Drawing.Color.White;
            this.AddrmBtn.Location = new System.Drawing.Point(12, 21);
            this.AddrmBtn.Name = "AddrmBtn";
            this.AddrmBtn.Size = new System.Drawing.Size(236, 85);
            this.AddrmBtn.TabIndex = 0;
            this.AddrmBtn.Text = "Add Room";
            this.AddrmBtn.Click += new System.EventHandler(this.AddrmBtn_Click);
            // 
            // MovingPanel
            // 
            this.MovingPanel.Controls.Add(this.addroom1);
            this.MovingPanel.Location = new System.Drawing.Point(20, 149);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(1869, 730);
            this.MovingPanel.TabIndex = 1;
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
            this.DsExitBtn.Location = new System.Drawing.Point(7, 12);
            this.DsExitBtn.Name = "DsExitBtn";
            this.DsExitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DsExitBtn.Size = new System.Drawing.Size(55, 50);
            this.DsExitBtn.TabIndex = 6;
            this.DsExitBtn.Click += new System.EventHandler(this.DsExitBtn_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MiniBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MiniBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MiniBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MiniBtn.FillColor = System.Drawing.Color.Empty;
            this.MiniBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MiniBtn.ForeColor = System.Drawing.Color.White;
            this.MiniBtn.Image = ((System.Drawing.Image)(resources.GetObject("MiniBtn.Image")));
            this.MiniBtn.ImageSize = new System.Drawing.Size(100, 100);
            this.MiniBtn.Location = new System.Drawing.Point(7, 68);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.MiniBtn.Size = new System.Drawing.Size(55, 50);
            this.MiniBtn.TabIndex = 7;
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // addroom1
            // 
            this.addroom1.BackColor = System.Drawing.Color.White;
            this.addroom1.Location = new System.Drawing.Point(15, 3);
            this.addroom1.Name = "addroom1";
            this.addroom1.Size = new System.Drawing.Size(1927, 879);
            this.addroom1.TabIndex = 0;
            this.addroom1.Visible = false;
            this.addroom1.Load += new System.EventHandler(this.addroom1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1901, 984);
            this.Controls.Add(this.MiniBtn);
            this.Controls.Add(this.DsExitBtn);
            this.Controls.Add(this.MovingPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.MovingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2CircleButton DsExitBtn;
        private Guna.UI2.WinForms.Guna2CircleButton MiniBtn;
        private Guna.UI2.WinForms.Guna2Button AddrmBtn;
        private Guna.UI2.WinForms.Guna2Button EmpBtn;
        private Guna.UI2.WinForms.Guna2Button CdBtn;
        private Guna.UI2.WinForms.Guna2Button CrBtn;
        private Guna.UI2.WinForms.Guna2Button CoBtn;
        private System.Windows.Forms.Panel Moving_panel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_user.Addroom addroom1;
    }
}