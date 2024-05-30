namespace DVLI
{
	partial class frmInternationalDriverInfo
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
			this.lbHeader = new System.Windows.Forms.Label();
			this.lbTodayDate = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.uctlInternationlLicenseInfo1 = new DVLI.uctlInternationlLicenseInfo();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.plTopBar.Controls.Add(this.lbHeader);
			this.plTopBar.Controls.Add(this.lbTodayDate);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(889, 42);
			this.plTopBar.TabIndex = 6;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// lbHeader
			// 
			this.lbHeader.AutoSize = true;
			this.lbHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHeader.ForeColor = System.Drawing.Color.White;
			this.lbHeader.Location = new System.Drawing.Point(13, 9);
			this.lbHeader.Name = "lbHeader";
			this.lbHeader.Size = new System.Drawing.Size(312, 25);
			this.lbHeader.TabIndex = 80;
			this.lbHeader.Text = "International Driver Information";
			this.lbHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbTodayDate
			// 
			this.lbTodayDate.AutoSize = true;
			this.lbTodayDate.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTodayDate.ForeColor = System.Drawing.Color.White;
			this.lbTodayDate.Location = new System.Drawing.Point(1345, 9);
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
			this.pbClose.Location = new System.Drawing.Point(846, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 42);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(256, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(357, 29);
			this.label1.TabIndex = 82;
			this.label1.Text = "Driver International License Info";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DVLI.Properties.Resources.international_license_color_icon_vector_37381217;
			this.pictureBox1.Location = new System.Drawing.Point(329, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(211, 133);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 83;
			this.pictureBox1.TabStop = false;
			// 
			// uctlInternationlLicenseInfo1
			// 
			this.uctlInternationlLicenseInfo1.Location = new System.Drawing.Point(18, 233);
			this.uctlInternationlLicenseInfo1.Name = "uctlInternationlLicenseInfo1";
			this.uctlInternationlLicenseInfo1.Size = new System.Drawing.Size(847, 278);
			this.uctlInternationlLicenseInfo1.TabIndex = 84;
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
			this.btnClose.Location = new System.Drawing.Point(753, 549);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 120;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// frmInternationalDriverInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(889, 613);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.uctlInternationlLicenseInfo1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmInternationalDriverInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmInternationalDriverInfo";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		public System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label label1;
		private uctlInternationlLicenseInfo uctlInternationlLicenseInfo1;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}