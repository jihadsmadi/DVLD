namespace DVLI
{
	partial class frmChangePassword
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
			this.plTopBar = new System.Windows.Forms.Panel();
			this.label = new System.Windows.Forms.Label();
			this.lbTodayDate = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.uctlLoginInfo1 = new DVLI.uctlLoginInfo();
			this.tbCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.plTopBar.Controls.Add(this.label);
			this.plTopBar.Controls.Add(this.lbTodayDate);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(927, 41);
			this.plTopBar.TabIndex = 120;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.ForeColor = System.Drawing.Color.White;
			this.label.Location = new System.Drawing.Point(16, 8);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(178, 25);
			this.label.TabIndex = 79;
			this.label.Text = "Change Password";
			// 
			// lbTodayDate
			// 
			this.lbTodayDate.AutoSize = true;
			this.lbTodayDate.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTodayDate.ForeColor = System.Drawing.Color.White;
			this.lbTodayDate.Location = new System.Drawing.Point(1357, 9);
			this.lbTodayDate.Name = "lbTodayDate";
			this.lbTodayDate.Size = new System.Drawing.Size(117, 29);
			this.lbTodayDate.TabIndex = 2;
			this.lbTodayDate.Text = "1/1/2002";
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = global::DVLI.Properties.Resources.icons8_cancel_1;
			this.pbClose.Location = new System.Drawing.Point(884, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 41);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// uctlLoginInfo1
			// 
			this.uctlLoginInfo1.Location = new System.Drawing.Point(42, 52);
			this.uctlLoginInfo1.Name = "uctlLoginInfo1";
			this.uctlLoginInfo1.Size = new System.Drawing.Size(836, 410);
			this.uctlLoginInfo1.TabIndex = 121;
			// 
			// tbCurrentPassword
			// 
			this.tbCurrentPassword.Animated = true;
			this.tbCurrentPassword.BorderThickness = 2;
			this.tbCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbCurrentPassword.DefaultText = "";
			this.tbCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.tbCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbCurrentPassword.ForeColor = System.Drawing.Color.Black;
			this.tbCurrentPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbCurrentPassword.Location = new System.Drawing.Point(407, 487);
			this.tbCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbCurrentPassword.Name = "tbCurrentPassword";
			this.tbCurrentPassword.PasswordChar = '\0';
			this.tbCurrentPassword.PlaceholderText = "Current Password";
			this.tbCurrentPassword.SelectedText = "";
			this.tbCurrentPassword.Size = new System.Drawing.Size(192, 36);
			this.tbCurrentPassword.TabIndex = 122;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(240, 496);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 19);
			this.label1.TabIndex = 123;
			this.label1.Text = "Current Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(240, 540);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 19);
			this.label2.TabIndex = 125;
			this.label2.Text = "New Password:";
			// 
			// tbNewPassword
			// 
			this.tbNewPassword.Animated = true;
			this.tbNewPassword.BorderThickness = 2;
			this.tbNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbNewPassword.DefaultText = "";
			this.tbNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNewPassword.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.tbNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbNewPassword.ForeColor = System.Drawing.Color.Black;
			this.tbNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNewPassword.Location = new System.Drawing.Point(407, 531);
			this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbNewPassword.Name = "tbNewPassword";
			this.tbNewPassword.PasswordChar = '\0';
			this.tbNewPassword.PlaceholderText = "New Password";
			this.tbNewPassword.SelectedText = "";
			this.tbNewPassword.Size = new System.Drawing.Size(192, 36);
			this.tbNewPassword.TabIndex = 124;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(240, 584);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 19);
			this.label3.TabIndex = 127;
			this.label3.Text = "Confirm Password:";
			// 
			// tbConfirmPassword
			// 
			this.tbConfirmPassword.Animated = true;
			this.tbConfirmPassword.BorderThickness = 2;
			this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbConfirmPassword.DefaultText = "";
			this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbConfirmPassword.ForeColor = System.Drawing.Color.Black;
			this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbConfirmPassword.Location = new System.Drawing.Point(407, 575);
			this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbConfirmPassword.Name = "tbConfirmPassword";
			this.tbConfirmPassword.PasswordChar = '\0';
			this.tbConfirmPassword.PlaceholderText = "Confirm Password";
			this.tbConfirmPassword.SelectedText = "";
			this.tbConfirmPassword.Size = new System.Drawing.Size(192, 36);
			this.tbConfirmPassword.TabIndex = 126;
			// 
			// btnClose
			// 
			this.btnClose.Animated = true;
			this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.btnClose.BorderRadius = 5;
			this.btnClose.BorderThickness = 2;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnClose.Image = global::DVLI.Properties.Resources.icons8_cancel_11;
			this.btnClose.ImageOffset = new System.Drawing.Point(-5, 0);
			this.btnClose.Location = new System.Drawing.Point(42, 620);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 128;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Animated = true;
			this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.btnSave.BorderRadius = 5;
			this.btnSave.BorderThickness = 2;
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnSave.Image = global::DVLI.Properties.Resources.icons8_save_1;
			this.btnSave.ImageOffset = new System.Drawing.Point(-5, 0);
			this.btnSave.Location = new System.Drawing.Point(766, 620);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(112, 45);
			this.btnSave.TabIndex = 129;
			this.btnSave.Text = " Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmChangePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 677);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbConfirmPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbNewPassword);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbCurrentPassword);
			this.Controls.Add(this.uctlLoginInfo1);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmChangePassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmChangePassword";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		private uctlLoginInfo uctlLoginInfo1;
		private Guna.UI2.WinForms.Guna2TextBox tbCurrentPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox tbNewPassword;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
		private Guna.UI2.WinForms.Guna2Button btnClose;
		private Guna.UI2.WinForms.Guna2Button btnSave;
	}
}