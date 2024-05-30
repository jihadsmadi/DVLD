namespace DVLI
{
	partial class frmNewLocalDrivingLicenseApplication
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewLocalDrivingLicenseApplication));
			this.plTopBar = new System.Windows.Forms.Panel();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.btnNext = new Guna.UI2.WinForms.Guna2Button();
			this.btnBack = new Guna.UI2.WinForms.Guna2Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.plContainerAboutAs = new System.Windows.Forms.Panel();
			this.plPersonalInf = new System.Windows.Forms.Panel();
			this.uctlPersonInfoWithFilter1 = new DVLI.uctlPersonInfoWithFilter();
			this.plLoginInfo = new System.Windows.Forms.Panel();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbLicenseClass = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbDLApplicationID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbCreatedByUser = new System.Windows.Forms.Label();
			this.lbApplicationFees = new System.Windows.Forms.Label();
			this.lbApplicationDate = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnApplicationInfo = new Guna.UI2.WinForms.Guna2Button();
			this.btnPersonalInfo = new Guna.UI2.WinForms.Guna2Button();
			this.lbHeader = new System.Windows.Forms.Label();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.panel7.SuspendLayout();
			this.plContainerAboutAs.SuspendLayout();
			this.plPersonalInf.SuspendLayout();
			this.plLoginInfo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.plTopBar.Controls.Add(this.lbHeader);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(1048, 40);
			this.plTopBar.TabIndex = 2;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(1005, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 40);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// btnClose
			// 
			this.btnClose.BorderColor = System.Drawing.Color.Transparent;
			this.btnClose.BorderRadius = 5;
			this.btnClose.BorderThickness = 2;
			this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
			this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnClose.ForeColor = System.Drawing.Color.White;
			this.btnClose.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(444, 622);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(133, 45);
			this.btnClose.TabIndex = 126;
			this.btnClose.Text = "  Close";
			this.btnClose.Visible = false;
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// btnNext
			// 
			this.btnNext.BorderColor = System.Drawing.Color.Transparent;
			this.btnNext.BorderRadius = 5;
			this.btnNext.BorderThickness = 2;
			this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
			this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnNext.ForeColor = System.Drawing.Color.White;
			this.btnNext.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.Location = new System.Drawing.Point(798, 621);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(133, 45);
			this.btnNext.TabIndex = 127;
			this.btnNext.Text = "  Next";
			this.btnNext.Click += new System.EventHandler(this.btnApplicationInfo_Click);
			// 
			// btnBack
			// 
			this.btnBack.BorderColor = System.Drawing.Color.Transparent;
			this.btnBack.BorderRadius = 5;
			this.btnBack.BorderThickness = 2;
			this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
			this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
			this.btnBack.Location = new System.Drawing.Point(72, 621);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(133, 45);
			this.btnBack.TabIndex = 128;
			this.btnBack.Text = "  Back";
			this.btnBack.Visible = false;
			this.btnBack.Click += new System.EventHandler(this.btnPersonalInfo_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.plContainerAboutAs);
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Location = new System.Drawing.Point(54, 58);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(932, 547);
			this.panel7.TabIndex = 125;
			// 
			// plContainerAboutAs
			// 
			this.plContainerAboutAs.Controls.Add(this.plPersonalInf);
			this.plContainerAboutAs.Controls.Add(this.plLoginInfo);
			this.plContainerAboutAs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plContainerAboutAs.Location = new System.Drawing.Point(0, 50);
			this.plContainerAboutAs.Name = "plContainerAboutAs";
			this.plContainerAboutAs.Size = new System.Drawing.Size(930, 495);
			this.plContainerAboutAs.TabIndex = 1;
			// 
			// plPersonalInf
			// 
			this.plPersonalInf.Controls.Add(this.uctlPersonInfoWithFilter1);
			this.plPersonalInf.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plPersonalInf.Location = new System.Drawing.Point(0, 0);
			this.plPersonalInf.Name = "plPersonalInf";
			this.plPersonalInf.Size = new System.Drawing.Size(930, 495);
			this.plPersonalInf.TabIndex = 2;
			// 
			// uctlPersonInfoWithFilter1
			// 
			this.uctlPersonInfoWithFilter1.Location = new System.Drawing.Point(38, 33);
			this.uctlPersonInfoWithFilter1.Name = "uctlPersonInfoWithFilter1";
			this.uctlPersonInfoWithFilter1.PersonID = -1;
			this.uctlPersonInfoWithFilter1.Size = new System.Drawing.Size(860, 417);
			this.uctlPersonInfoWithFilter1.TabIndex = 0;
			// 
			// plLoginInfo
			// 
			this.plLoginInfo.BackColor = System.Drawing.SystemColors.Control;
			this.plLoginInfo.Controls.Add(this.btnSave);
			this.plLoginInfo.Controls.Add(this.groupBox1);
			this.plLoginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plLoginInfo.Location = new System.Drawing.Point(0, 0);
			this.plLoginInfo.Name = "plLoginInfo";
			this.plLoginInfo.Size = new System.Drawing.Size(930, 495);
			this.plLoginInfo.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.BorderColor = System.Drawing.Color.Transparent;
			this.btnSave.BorderRadius = 5;
			this.btnSave.BorderThickness = 2;
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(55)))), ((int)(((byte)(63)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.Location = new System.Drawing.Point(389, 385);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(133, 45);
			this.btnSave.TabIndex = 216;
			this.btnSave.Text = "  Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbLicenseClass);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lbDLApplicationID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lbCreatedByUser);
			this.groupBox1.Controls.Add(this.lbApplicationFees);
			this.groupBox1.Controls.Add(this.lbApplicationDate);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F);
			this.groupBox1.Location = new System.Drawing.Point(152, 45);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(637, 294);
			this.groupBox1.TabIndex = 215;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Application Information";
			// 
			// cbLicenseClass
			// 
			this.cbLicenseClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbLicenseClass.Font = new System.Drawing.Font("Tahoma", 13F);
			this.cbLicenseClass.ForeColor = System.Drawing.Color.Black;
			this.cbLicenseClass.FormattingEnabled = true;
			this.cbLicenseClass.Location = new System.Drawing.Point(248, 133);
			this.cbLicenseClass.Name = "cbLicenseClass";
			this.cbLicenseClass.Size = new System.Drawing.Size(344, 29);
			this.cbLicenseClass.TabIndex = 223;
			this.cbLicenseClass.SelectedIndexChanged += new System.EventHandler(this.cbLicenseClass_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(73, 221);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 19);
			this.label4.TabIndex = 222;
			this.label4.Text = "Created By User:";
			// 
			// lbDLApplicationID
			// 
			this.lbDLApplicationID.AutoSize = true;
			this.lbDLApplicationID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDLApplicationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.lbDLApplicationID.Location = new System.Drawing.Point(244, 46);
			this.lbDLApplicationID.Name = "lbDLApplicationID";
			this.lbDLApplicationID.Size = new System.Drawing.Size(50, 19);
			this.lbDLApplicationID.TabIndex = 221;
			this.lbDLApplicationID.Text = "[???]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(63, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 19);
			this.label2.TabIndex = 221;
			this.label2.Text = "D.L Application ID:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(73, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(149, 19);
			this.label6.TabIndex = 217;
			this.label6.Text = "Application Fees:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(99, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 19);
			this.label3.TabIndex = 216;
			this.label3.Text = "License Class:";
			// 
			// lbCreatedByUser
			// 
			this.lbCreatedByUser.AutoSize = true;
			this.lbCreatedByUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCreatedByUser.ForeColor = System.Drawing.Color.Black;
			this.lbCreatedByUser.Location = new System.Drawing.Point(249, 221);
			this.lbCreatedByUser.Name = "lbCreatedByUser";
			this.lbCreatedByUser.Size = new System.Drawing.Size(45, 19);
			this.lbCreatedByUser.TabIndex = 215;
			this.lbCreatedByUser.Text = "[???]";
			// 
			// lbApplicationFees
			// 
			this.lbApplicationFees.AutoSize = true;
			this.lbApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbApplicationFees.ForeColor = System.Drawing.Color.Black;
			this.lbApplicationFees.Location = new System.Drawing.Point(249, 179);
			this.lbApplicationFees.Name = "lbApplicationFees";
			this.lbApplicationFees.Size = new System.Drawing.Size(45, 19);
			this.lbApplicationFees.TabIndex = 215;
			this.lbApplicationFees.Text = "[???]";
			// 
			// lbApplicationDate
			// 
			this.lbApplicationDate.AutoSize = true;
			this.lbApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbApplicationDate.ForeColor = System.Drawing.Color.Black;
			this.lbApplicationDate.Location = new System.Drawing.Point(244, 86);
			this.lbApplicationDate.Name = "lbApplicationDate";
			this.lbApplicationDate.Size = new System.Drawing.Size(45, 19);
			this.lbApplicationDate.TabIndex = 215;
			this.lbApplicationDate.Text = "[???]";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(73, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 19);
			this.label1.TabIndex = 215;
			this.label1.Text = "Application Date:";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.DarkGray;
			this.panel8.Controls.Add(this.btnApplicationInfo);
			this.panel8.Controls.Add(this.btnPersonalInfo);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(930, 50);
			this.panel8.TabIndex = 0;
			// 
			// btnApplicationInfo
			// 
			this.btnApplicationInfo.Animated = true;
			this.btnApplicationInfo.BorderColor = System.Drawing.Color.Transparent;
			this.btnApplicationInfo.BorderThickness = 2;
			this.btnApplicationInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnApplicationInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnApplicationInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnApplicationInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnApplicationInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnApplicationInfo.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnApplicationInfo.FillColor = System.Drawing.Color.SlateGray;
			this.btnApplicationInfo.FocusedColor = System.Drawing.Color.SkyBlue;
			this.btnApplicationInfo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnApplicationInfo.ForeColor = System.Drawing.Color.White;
			this.btnApplicationInfo.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnApplicationInfo.Location = new System.Drawing.Point(233, 0);
			this.btnApplicationInfo.Name = "btnApplicationInfo";
			this.btnApplicationInfo.Size = new System.Drawing.Size(233, 50);
			this.btnApplicationInfo.TabIndex = 1;
			this.btnApplicationInfo.Tag = "arabic";
			this.btnApplicationInfo.Text = "Application Info";
			this.btnApplicationInfo.Click += new System.EventHandler(this.btnApplicationInfo_Click);
			// 
			// btnPersonalInfo
			// 
			this.btnPersonalInfo.Animated = true;
			this.btnPersonalInfo.BorderColor = System.Drawing.Color.Transparent;
			this.btnPersonalInfo.BorderThickness = 2;
			this.btnPersonalInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPersonalInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnPersonalInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnPersonalInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnPersonalInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnPersonalInfo.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnPersonalInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.btnPersonalInfo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.btnPersonalInfo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPersonalInfo.ForeColor = System.Drawing.Color.White;
			this.btnPersonalInfo.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnPersonalInfo.Location = new System.Drawing.Point(0, 0);
			this.btnPersonalInfo.Name = "btnPersonalInfo";
			this.btnPersonalInfo.Size = new System.Drawing.Size(233, 50);
			this.btnPersonalInfo.TabIndex = 0;
			this.btnPersonalInfo.Tag = "eng";
			this.btnPersonalInfo.Text = "Personl Info";
			this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
			// 
			// lbHeader
			// 
			this.lbHeader.AutoSize = true;
			this.lbHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHeader.ForeColor = System.Drawing.Color.White;
			this.lbHeader.Location = new System.Drawing.Point(12, 9);
			this.lbHeader.Name = "lbHeader";
			this.lbHeader.Size = new System.Drawing.Size(288, 25);
			this.lbHeader.TabIndex = 81;
			this.lbHeader.Text = "Add New Local Driving Licens";
			this.lbHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// frmNewLocalDrivingLicenseApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1048, 689);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmNewLocalDrivingLicenseApplication";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmNewLocalDrivingLicenseApplication";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.panel7.ResumeLayout(false);
			this.plContainerAboutAs.ResumeLayout(false);
			this.plPersonalInf.ResumeLayout(false);
			this.plLoginInfo.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.PictureBox pbClose;
		private Guna.UI2.WinForms.Guna2Button btnClose;
		private Guna.UI2.WinForms.Guna2Button btnNext;
		private Guna.UI2.WinForms.Guna2Button btnBack;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel plContainerAboutAs;
		private System.Windows.Forms.Panel plPersonalInf;
		private uctlPersonInfoWithFilter uctlPersonInfoWithFilter1;
		private System.Windows.Forms.Panel plLoginInfo;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbDLApplicationID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel8;
		private Guna.UI2.WinForms.Guna2Button btnApplicationInfo;
		private Guna.UI2.WinForms.Guna2Button btnPersonalInfo;
		private System.Windows.Forms.Label lbApplicationFees;
		private System.Windows.Forms.Label lbApplicationDate;
		private System.Windows.Forms.Label lbCreatedByUser;
		private System.Windows.Forms.ComboBox cbLicenseClass;
		public System.Windows.Forms.Label lbHeader;
	}
}