namespace DVLI
{
	partial class frmDetainLicense
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetainLicense));
			this.plTopBar = new System.Windows.Forms.Panel();
			this.lbHeader = new System.Windows.Forms.Label();
			this.lbTodayDate = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbApplicationDate = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbRLApplicationID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbFineFees = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.lbLicenseID = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lbCreatedBy = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lbShowLicenseInfo = new System.Windows.Forms.Label();
			this.lbShowLicenseHistory = new System.Windows.Forms.Label();
			this.btnDetain = new Guna.UI2.WinForms.Guna2Button();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.uctlInternationalLicenseApplicationWithFilter1 = new DVLI.uctlInternationalLicenseApplicationWithFilter();
			this.plTopBar.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbFineFees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
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
			this.plTopBar.Size = new System.Drawing.Size(989, 42);
			this.plTopBar.TabIndex = 7;
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
			this.lbHeader.Size = new System.Drawing.Size(147, 25);
			this.lbHeader.TabIndex = 80;
			this.lbHeader.Text = "Detain License";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.IndianRed;
			this.label1.Location = new System.Drawing.Point(389, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 33);
			this.label1.TabIndex = 81;
			this.label1.Text = "Detain License";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbLicenseID);
			this.groupBox1.Controls.Add(this.pictureBox9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.lbCreatedBy);
			this.groupBox1.Controls.Add(this.pictureBox6);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.tbFineFees);
			this.groupBox1.Controls.Add(this.lbApplicationDate);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lbRLApplicationID);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.groupBox1.Location = new System.Drawing.Point(72, 681);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(847, 155);
			this.groupBox1.TabIndex = 82;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Detain Info";
			// 
			// lbApplicationDate
			// 
			this.lbApplicationDate.AutoSize = true;
			this.lbApplicationDate.BackColor = System.Drawing.Color.Transparent;
			this.lbApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbApplicationDate.ForeColor = System.Drawing.Color.Black;
			this.lbApplicationDate.Location = new System.Drawing.Point(214, 79);
			this.lbApplicationDate.Name = "lbApplicationDate";
			this.lbApplicationDate.Size = new System.Drawing.Size(45, 19);
			this.lbApplicationDate.TabIndex = 38;
			this.lbApplicationDate.Text = "[???]";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 19);
			this.label4.TabIndex = 36;
			this.label4.Text = "Application Date:";
			// 
			// lbRLApplicationID
			// 
			this.lbRLApplicationID.AutoSize = true;
			this.lbRLApplicationID.BackColor = System.Drawing.Color.Transparent;
			this.lbRLApplicationID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbRLApplicationID.ForeColor = System.Drawing.Color.Red;
			this.lbRLApplicationID.Location = new System.Drawing.Point(214, 44);
			this.lbRLApplicationID.Name = "lbRLApplicationID";
			this.lbRLApplicationID.Size = new System.Drawing.Size(45, 19);
			this.lbRLApplicationID.TabIndex = 35;
			this.lbRLApplicationID.Text = "[???]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 19);
			this.label2.TabIndex = 33;
			this.label2.Text = "Detain ID:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 115);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 19);
			this.label7.TabIndex = 30;
			this.label7.Text = "Fine Fees:";
			// 
			// tbFineFees
			// 
			this.tbFineFees.BackColor = System.Drawing.Color.Transparent;
			this.tbFineFees.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFineFees.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbFineFees.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.tbFineFees.Location = new System.Drawing.Point(218, 110);
			this.tbFineFees.Name = "tbFineFees";
			this.tbFineFees.Size = new System.Drawing.Size(125, 29);
			this.tbFineFees.TabIndex = 39;
			this.tbFineFees.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.tbFineFees.UpDownButtonForeColor = System.Drawing.Color.White;
			this.tbFineFees.UseTransparentBackground = true;
			// 
			// lbLicenseID
			// 
			this.lbLicenseID.AutoSize = true;
			this.lbLicenseID.BackColor = System.Drawing.Color.Transparent;
			this.lbLicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLicenseID.ForeColor = System.Drawing.Color.Black;
			this.lbLicenseID.Location = new System.Drawing.Point(766, 49);
			this.lbLicenseID.Name = "lbLicenseID";
			this.lbLicenseID.Size = new System.Drawing.Size(45, 19);
			this.lbLicenseID.TabIndex = 137;
			this.lbLicenseID.Text = "[???]";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(541, 49);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 19);
			this.label10.TabIndex = 135;
			this.label10.Text = "License ID:";
			// 
			// lbCreatedBy
			// 
			this.lbCreatedBy.AutoSize = true;
			this.lbCreatedBy.BackColor = System.Drawing.Color.Transparent;
			this.lbCreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCreatedBy.ForeColor = System.Drawing.Color.Black;
			this.lbCreatedBy.Location = new System.Drawing.Point(766, 86);
			this.lbCreatedBy.Name = "lbCreatedBy";
			this.lbCreatedBy.Size = new System.Drawing.Size(45, 19);
			this.lbCreatedBy.TabIndex = 134;
			this.lbCreatedBy.Text = "[???]";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(541, 86);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 19);
			this.label8.TabIndex = 132;
			this.label8.Text = "Created By:";
			// 
			// lbShowLicenseInfo
			// 
			this.lbShowLicenseInfo.AutoSize = true;
			this.lbShowLicenseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbShowLicenseInfo.Enabled = false;
			this.lbShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbShowLicenseInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbShowLicenseInfo.Location = new System.Drawing.Point(254, 868);
			this.lbShowLicenseInfo.Name = "lbShowLicenseInfo";
			this.lbShowLicenseInfo.Size = new System.Drawing.Size(138, 19);
			this.lbShowLicenseInfo.TabIndex = 137;
			this.lbShowLicenseInfo.Text = "Show License Info";
			this.lbShowLicenseInfo.Click += new System.EventHandler(this.lbShowLicenseInfo_Click);
			// 
			// lbShowLicenseHistory
			// 
			this.lbShowLicenseHistory.AutoSize = true;
			this.lbShowLicenseHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbShowLicenseHistory.Enabled = false;
			this.lbShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbShowLicenseHistory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbShowLicenseHistory.Location = new System.Drawing.Point(70, 868);
			this.lbShowLicenseHistory.Name = "lbShowLicenseHistory";
			this.lbShowLicenseHistory.Size = new System.Drawing.Size(159, 19);
			this.lbShowLicenseHistory.TabIndex = 136;
			this.lbShowLicenseHistory.Text = "Show License History";
			this.lbShowLicenseHistory.Click += new System.EventHandler(this.lbShowLicenseHistory_Click);
			// 
			// btnDetain
			// 
			this.btnDetain.Animated = true;
			this.btnDetain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.btnDetain.BorderRadius = 5;
			this.btnDetain.BorderThickness = 2;
			this.btnDetain.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDetain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnDetain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnDetain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnDetain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnDetain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.btnDetain.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnDetain.ForeColor = System.Drawing.Color.White;
			this.btnDetain.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnDetain.Image = global::DVLI.Properties.Resources.icons8_lock;
			this.btnDetain.ImageOffset = new System.Drawing.Point(-5, 0);
			this.btnDetain.Location = new System.Drawing.Point(808, 845);
			this.btnDetain.Name = "btnDetain";
			this.btnDetain.Size = new System.Drawing.Size(112, 45);
			this.btnDetain.TabIndex = 135;
			this.btnDetain.Text = "Detain";
			this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
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
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.ImageOffset = new System.Drawing.Point(-5, 0);
			this.btnClose.Location = new System.Drawing.Point(682, 845);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 134;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(722, 44);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(34, 29);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 136;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(722, 81);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(34, 29);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 133;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::DVLI.Properties.Resources.icons8_schedule;
			this.pictureBox2.Location = new System.Drawing.Point(170, 74);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 29);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 37;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DVLI.Properties.Resources.icons8_id_button;
			this.pictureBox1.Location = new System.Drawing.Point(170, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 29);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(170, 110);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(34, 29);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 31;
			this.pictureBox5.TabStop = false;
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(946, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 42);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// uctlInternationalLicenseApplicationWithFilter1
			// 
			this.uctlInternationalLicenseApplicationWithFilter1.License = null;
			this.uctlInternationalLicenseApplicationWithFilter1.Location = new System.Drawing.Point(72, 106);
			this.uctlInternationalLicenseApplicationWithFilter1.Name = "uctlInternationalLicenseApplicationWithFilter1";
			this.uctlInternationalLicenseApplicationWithFilter1.Size = new System.Drawing.Size(847, 529);
			this.uctlInternationalLicenseApplicationWithFilter1.TabIndex = 8;
			// 
			// frmDetainLicense
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 934);
			this.Controls.Add(this.lbShowLicenseInfo);
			this.Controls.Add(this.lbShowLicenseHistory);
			this.Controls.Add(this.btnDetain);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uctlInternationalLicenseApplicationWithFilter1);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmDetainLicense";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDetainLicense";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbFineFees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		public System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		private uctlInternationalLicenseApplicationWithFilter uctlInternationalLicenseApplicationWithFilter1;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private Guna.UI2.WinForms.Guna2NumericUpDown tbFineFees;
		private System.Windows.Forms.Label lbApplicationDate;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbRLApplicationID;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbLicenseID;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbCreatedBy;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbShowLicenseInfo;
		private System.Windows.Forms.Label lbShowLicenseHistory;
		private Guna.UI2.WinForms.Guna2Button btnDetain;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}