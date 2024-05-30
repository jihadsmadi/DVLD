namespace DVLI
{
	partial class frmReplacementLicnese
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbLostLicense = new System.Windows.Forms.RadioButton();
			this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
			this.uctlInternationalLicenseApplicationWithFilter1 = new DVLI.uctlInternationalLicenseApplicationWithFilter();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbOldLicenseID = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lbReplacedLicenseID = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lbCreatedBy = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.lbApplicationDate = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbLRApplicationID = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lbApplicationFees = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lbShowLicenseInfo = new System.Windows.Forms.Label();
			this.lbShowLicenseHistory = new System.Windows.Forms.Label();
			this.btnIssueReplacemetn = new Guna.UI2.WinForms.Guna2Button();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
			this.plTopBar.Size = new System.Drawing.Size(1044, 42);
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
			this.lbHeader.Size = new System.Drawing.Size(341, 25);
			this.lbHeader.TabIndex = 80;
			this.lbHeader.Text = "Replacement For Damaged Licnese";
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
			this.pbClose.Location = new System.Drawing.Point(1001, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 42);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbLostLicense);
			this.groupBox1.Controls.Add(this.rbDamagedLicense);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.groupBox1.Location = new System.Drawing.Point(853, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(167, 107);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Replacement For";
			// 
			// rbLostLicense
			// 
			this.rbLostLicense.AutoSize = true;
			this.rbLostLicense.Font = new System.Drawing.Font("Tahoma", 10F);
			this.rbLostLicense.Location = new System.Drawing.Point(21, 62);
			this.rbLostLicense.Name = "rbLostLicense";
			this.rbLostLicense.Size = new System.Drawing.Size(100, 21);
			this.rbLostLicense.TabIndex = 10;
			this.rbLostLicense.Text = "Lost License";
			this.rbLostLicense.UseVisualStyleBackColor = true;
			this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
			// 
			// rbDamagedLicense
			// 
			this.rbDamagedLicense.AutoSize = true;
			this.rbDamagedLicense.Checked = true;
			this.rbDamagedLicense.Font = new System.Drawing.Font("Tahoma", 10F);
			this.rbDamagedLicense.Location = new System.Drawing.Point(21, 28);
			this.rbDamagedLicense.Name = "rbDamagedLicense";
			this.rbDamagedLicense.Size = new System.Drawing.Size(133, 21);
			this.rbDamagedLicense.TabIndex = 9;
			this.rbDamagedLicense.TabStop = true;
			this.rbDamagedLicense.Text = "Damaged License";
			this.rbDamagedLicense.UseVisualStyleBackColor = true;
			this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
			// 
			// uctlInternationalLicenseApplicationWithFilter1
			// 
			this.uctlInternationalLicenseApplicationWithFilter1.License = null;
			this.uctlInternationalLicenseApplicationWithFilter1.Location = new System.Drawing.Point(6, 46);
			this.uctlInternationalLicenseApplicationWithFilter1.Name = "uctlInternationalLicenseApplicationWithFilter1";
			this.uctlInternationalLicenseApplicationWithFilter1.Size = new System.Drawing.Size(847, 529);
			this.uctlInternationalLicenseApplicationWithFilter1.TabIndex = 9;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lbOldLicenseID);
			this.groupBox2.Controls.Add(this.pictureBox9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.lbReplacedLicenseID);
			this.groupBox2.Controls.Add(this.pictureBox8);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.lbCreatedBy);
			this.groupBox2.Controls.Add(this.pictureBox6);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.lbApplicationDate);
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.lbLRApplicationID);
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.lbApplicationFees);
			this.groupBox2.Controls.Add(this.pictureBox5);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
			this.groupBox2.Location = new System.Drawing.Point(6, 582);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(847, 150);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Application Info For License Replacement";
			// 
			// lbOldLicenseID
			// 
			this.lbOldLicenseID.AutoSize = true;
			this.lbOldLicenseID.BackColor = System.Drawing.Color.Transparent;
			this.lbOldLicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbOldLicenseID.ForeColor = System.Drawing.Color.Black;
			this.lbOldLicenseID.Location = new System.Drawing.Point(726, 64);
			this.lbOldLicenseID.Name = "lbOldLicenseID";
			this.lbOldLicenseID.Size = new System.Drawing.Size(45, 19);
			this.lbOldLicenseID.TabIndex = 140;
			this.lbOldLicenseID.Text = "[???]";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = global::DVLI.Properties.Resources.icons8_car_insurance2;
			this.pictureBox9.Location = new System.Drawing.Point(682, 59);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(34, 29);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 139;
			this.pictureBox9.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(501, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(131, 19);
			this.label10.TabIndex = 138;
			this.label10.Text = "Old License ID:";
			// 
			// lbReplacedLicenseID
			// 
			this.lbReplacedLicenseID.AutoSize = true;
			this.lbReplacedLicenseID.BackColor = System.Drawing.Color.Transparent;
			this.lbReplacedLicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbReplacedLicenseID.ForeColor = System.Drawing.Color.Red;
			this.lbReplacedLicenseID.Location = new System.Drawing.Point(726, 29);
			this.lbReplacedLicenseID.Name = "lbReplacedLicenseID";
			this.lbReplacedLicenseID.Size = new System.Drawing.Size(45, 19);
			this.lbReplacedLicenseID.TabIndex = 137;
			this.lbReplacedLicenseID.Text = "[???]";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = global::DVLI.Properties.Resources.icons8_car_insurance1;
			this.pictureBox8.Location = new System.Drawing.Point(682, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(34, 29);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 136;
			this.pictureBox8.TabStop = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(501, 29);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(179, 19);
			this.label9.TabIndex = 135;
			this.label9.Text = "Replaced License ID:";
			// 
			// lbCreatedBy
			// 
			this.lbCreatedBy.AutoSize = true;
			this.lbCreatedBy.BackColor = System.Drawing.Color.Transparent;
			this.lbCreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCreatedBy.ForeColor = System.Drawing.Color.Black;
			this.lbCreatedBy.Location = new System.Drawing.Point(726, 102);
			this.lbCreatedBy.Name = "lbCreatedBy";
			this.lbCreatedBy.Size = new System.Drawing.Size(45, 19);
			this.lbCreatedBy.TabIndex = 134;
			this.lbCreatedBy.Text = "[???]";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::DVLI.Properties.Resources.icons8_account_1;
			this.pictureBox6.Location = new System.Drawing.Point(682, 97);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(34, 29);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 133;
			this.pictureBox6.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(501, 102);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 19);
			this.label8.TabIndex = 132;
			this.label8.Text = "Created By:";
			// 
			// lbApplicationDate
			// 
			this.lbApplicationDate.AutoSize = true;
			this.lbApplicationDate.BackColor = System.Drawing.Color.Transparent;
			this.lbApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbApplicationDate.ForeColor = System.Drawing.Color.Black;
			this.lbApplicationDate.Location = new System.Drawing.Point(216, 65);
			this.lbApplicationDate.Name = "lbApplicationDate";
			this.lbApplicationDate.Size = new System.Drawing.Size(45, 19);
			this.lbApplicationDate.TabIndex = 38;
			this.lbApplicationDate.Text = "[???]";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::DVLI.Properties.Resources.icons8_schedule;
			this.pictureBox2.Location = new System.Drawing.Point(172, 60);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 29);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 37;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 19);
			this.label4.TabIndex = 36;
			this.label4.Text = "Application Date:";
			// 
			// lbLRApplicationID
			// 
			this.lbLRApplicationID.AutoSize = true;
			this.lbLRApplicationID.BackColor = System.Drawing.Color.Transparent;
			this.lbLRApplicationID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLRApplicationID.ForeColor = System.Drawing.Color.Red;
			this.lbLRApplicationID.Location = new System.Drawing.Point(216, 30);
			this.lbLRApplicationID.Name = "lbLRApplicationID";
			this.lbLRApplicationID.Size = new System.Drawing.Size(45, 19);
			this.lbLRApplicationID.TabIndex = 35;
			this.lbLRApplicationID.Text = "[???]";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DVLI.Properties.Resources.icons8_id_button;
			this.pictureBox1.Location = new System.Drawing.Point(172, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 29);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 19);
			this.label1.TabIndex = 33;
			this.label1.Text = "L.R..Application ID:";
			// 
			// lbApplicationFees
			// 
			this.lbApplicationFees.AutoSize = true;
			this.lbApplicationFees.BackColor = System.Drawing.Color.Transparent;
			this.lbApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbApplicationFees.ForeColor = System.Drawing.Color.Black;
			this.lbApplicationFees.Location = new System.Drawing.Point(216, 99);
			this.lbApplicationFees.Name = "lbApplicationFees";
			this.lbApplicationFees.Size = new System.Drawing.Size(45, 19);
			this.lbApplicationFees.TabIndex = 32;
			this.lbApplicationFees.Text = "[???]";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::DVLI.Properties.Resources.icons8_average;
			this.pictureBox5.Location = new System.Drawing.Point(172, 94);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(34, 29);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 31;
			this.pictureBox5.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 99);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(143, 19);
			this.label7.TabIndex = 30;
			this.label7.Text = "Application Fees";
			// 
			// lbShowLicenseInfo
			// 
			this.lbShowLicenseInfo.AutoSize = true;
			this.lbShowLicenseInfo.Enabled = false;
			this.lbShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbShowLicenseInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbShowLicenseInfo.Location = new System.Drawing.Point(219, 748);
			this.lbShowLicenseInfo.Name = "lbShowLicenseInfo";
			this.lbShowLicenseInfo.Size = new System.Drawing.Size(174, 19);
			this.lbShowLicenseInfo.TabIndex = 137;
			this.lbShowLicenseInfo.Text = "Show New License Info";
			this.lbShowLicenseInfo.Click += new System.EventHandler(this.lbShowLicenseInfo_Click);
			// 
			// lbShowLicenseHistory
			// 
			this.lbShowLicenseHistory.AutoSize = true;
			this.lbShowLicenseHistory.Enabled = false;
			this.lbShowLicenseHistory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbShowLicenseHistory.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lbShowLicenseHistory.Location = new System.Drawing.Point(35, 748);
			this.lbShowLicenseHistory.Name = "lbShowLicenseHistory";
			this.lbShowLicenseHistory.Size = new System.Drawing.Size(159, 19);
			this.lbShowLicenseHistory.TabIndex = 136;
			this.lbShowLicenseHistory.Text = "Show License History";
			this.lbShowLicenseHistory.Click += new System.EventHandler(this.lbShowLicenseHistory_Click);
			// 
			// btnIssueReplacemetn
			// 
			this.btnIssueReplacemetn.Animated = true;
			this.btnIssueReplacemetn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.btnIssueReplacemetn.BorderRadius = 5;
			this.btnIssueReplacemetn.BorderThickness = 2;
			this.btnIssueReplacemetn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnIssueReplacemetn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnIssueReplacemetn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnIssueReplacemetn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnIssueReplacemetn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnIssueReplacemetn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.btnIssueReplacemetn.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnIssueReplacemetn.ForeColor = System.Drawing.Color.White;
			this.btnIssueReplacemetn.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnIssueReplacemetn.Image = global::DVLI.Properties.Resources.icons8_Travel_Insurance2;
			this.btnIssueReplacemetn.ImageOffset = new System.Drawing.Point(-5, 0);
			this.btnIssueReplacemetn.Location = new System.Drawing.Point(649, 738);
			this.btnIssueReplacemetn.Name = "btnIssueReplacemetn";
			this.btnIssueReplacemetn.Size = new System.Drawing.Size(204, 45);
			this.btnIssueReplacemetn.TabIndex = 135;
			this.btnIssueReplacemetn.Text = "Issue Replacement";
			this.btnIssueReplacemetn.Click += new System.EventHandler(this.btnIssueReplacemetn_Click);
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
			this.btnClose.Location = new System.Drawing.Point(523, 738);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 134;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// frmReplacementLicnese
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1044, 789);
			this.Controls.Add(this.lbShowLicenseInfo);
			this.Controls.Add(this.lbShowLicenseHistory);
			this.Controls.Add(this.btnIssueReplacemetn);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.uctlInternationalLicenseApplicationWithFilter1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmReplacementLicnese";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmReplacementLicnese";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		public System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbLostLicense;
		private System.Windows.Forms.RadioButton rbDamagedLicense;
		private uctlInternationalLicenseApplicationWithFilter uctlInternationalLicenseApplicationWithFilter1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbApplicationDate;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbLRApplicationID;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbApplicationFees;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbOldLicenseID;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbReplacedLicenseID;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lbCreatedBy;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbShowLicenseInfo;
		private System.Windows.Forms.Label lbShowLicenseHistory;
		private Guna.UI2.WinForms.Guna2Button btnIssueReplacemetn;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}