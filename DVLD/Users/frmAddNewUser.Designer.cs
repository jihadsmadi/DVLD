namespace DVLI
{
	partial class frmAddNewUser
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
			this.plTopBar = new System.Windows.Forms.Panel();
			this.lbAddNewOrUpdate = new System.Windows.Forms.Label();
			this.lbTodayDate = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.plContainerAboutAs = new System.Windows.Forms.Panel();
			this.plPersonalInf = new System.Windows.Forms.Panel();
			this.uctlPersonInfoWithFilter1 = new DVLI.uctlPersonInfoWithFilter();
			this.plLoginInfo = new System.Windows.Forms.Panel();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbIsActive = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lbUserID = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnLoginInfo = new Guna.UI2.WinForms.Guna2Button();
			this.btnPersonalInfo = new Guna.UI2.WinForms.Guna2Button();
			this.btnNext = new Guna.UI2.WinForms.Guna2Button();
			this.btnBack = new Guna.UI2.WinForms.Guna2Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.panel7.SuspendLayout();
			this.plContainerAboutAs.SuspendLayout();
			this.plPersonalInf.SuspendLayout();
			this.plLoginInfo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.plTopBar.Controls.Add(this.lbAddNewOrUpdate);
			this.plTopBar.Controls.Add(this.lbTodayDate);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(1011, 41);
			this.plTopBar.TabIndex = 79;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// lbAddNewOrUpdate
			// 
			this.lbAddNewOrUpdate.AutoSize = true;
			this.lbAddNewOrUpdate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddNewOrUpdate.ForeColor = System.Drawing.Color.White;
			this.lbAddNewOrUpdate.Location = new System.Drawing.Point(16, 8);
			this.lbAddNewOrUpdate.Name = "lbAddNewOrUpdate";
			this.lbAddNewOrUpdate.Size = new System.Drawing.Size(146, 25);
			this.lbAddNewOrUpdate.TabIndex = 79;
			this.lbAddNewOrUpdate.Text = "Add New User";
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
			this.pbClose.Location = new System.Drawing.Point(968, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 41);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.plContainerAboutAs);
			this.panel7.Controls.Add(this.panel8);
			this.panel7.Location = new System.Drawing.Point(45, 77);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(932, 547);
			this.panel7.TabIndex = 81;
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
			this.uctlPersonInfoWithFilter1.Location = new System.Drawing.Point(26, 37);
			this.uctlPersonInfoWithFilter1.Name = "uctlPersonInfoWithFilter1";
			this.uctlPersonInfoWithFilter1.PersonID = 0;
			this.uctlPersonInfoWithFilter1.Size = new System.Drawing.Size(860, 417);
			this.uctlPersonInfoWithFilter1.TabIndex = 81;
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
			this.btnSave.Image = global::DVLI.Properties.Resources.icons8_save_3;
			this.btnSave.Location = new System.Drawing.Point(389, 376);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(133, 45);
			this.btnSave.TabIndex = 216;
			this.btnSave.Text = "  Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbIsActive);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.lbUserID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbConfirmPassword);
			this.groupBox1.Controls.Add(this.tbPassword);
			this.groupBox1.Controls.Add(this.tbUsername);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11F);
			this.groupBox1.Location = new System.Drawing.Point(206, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(519, 287);
			this.groupBox1.TabIndex = 215;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login Information";
			// 
			// cbIsActive
			// 
			this.cbIsActive.AutoSize = true;
			this.cbIsActive.Checked = true;
			this.cbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbIsActive.Location = new System.Drawing.Point(251, 221);
			this.cbIsActive.Name = "cbIsActive";
			this.cbIsActive.Size = new System.Drawing.Size(66, 22);
			this.cbIsActive.TabIndex = 223;
			this.cbIsActive.Text = "Active";
			this.cbIsActive.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(109, 220);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 19);
			this.label4.TabIndex = 222;
			this.label4.Text = "Is Active:";
			// 
			// lbUserID
			// 
			this.lbUserID.AutoSize = true;
			this.lbUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUserID.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.lbUserID.Location = new System.Drawing.Point(244, 46);
			this.lbUserID.Name = "lbUserID";
			this.lbUserID.Size = new System.Drawing.Size(50, 19);
			this.lbUserID.TabIndex = 221;
			this.lbUserID.Text = "[???]";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(125, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 19);
			this.label2.TabIndex = 221;
			this.label2.Text = "User ID:";
			// 
			// tbConfirmPassword
			// 
			this.tbConfirmPassword.Animated = true;
			this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbConfirmPassword.DefaultText = "";
			this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.tbConfirmPassword.Location = new System.Drawing.Point(248, 171);
			this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbConfirmPassword.Name = "tbConfirmPassword";
			this.tbConfirmPassword.PasswordChar = '*';
			this.tbConfirmPassword.PlaceholderText = "Confirm Password";
			this.tbConfirmPassword.SelectedText = "";
			this.tbConfirmPassword.Size = new System.Drawing.Size(205, 34);
			this.tbConfirmPassword.TabIndex = 222;
			this.tbConfirmPassword.Tag = "Confirm Password";
			this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
			// 
			// tbPassword
			// 
			this.tbPassword.Animated = true;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultText = "";
			this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.tbPassword.Location = new System.Drawing.Point(248, 126);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.PlaceholderText = "Password";
			this.tbPassword.SelectedText = "";
			this.tbPassword.Size = new System.Drawing.Size(205, 34);
			this.tbPassword.TabIndex = 221;
			this.tbPassword.Tag = "Password";
			this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
			// 
			// tbUsername
			// 
			this.tbUsername.Animated = true;
			this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUsername.DefaultText = "";
			this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbUsername.HoverState.BorderColor = System.Drawing.Color.LightSkyBlue;
			this.tbUsername.Location = new System.Drawing.Point(248, 81);
			this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbUsername.Name = "tbUsername";
			this.tbUsername.PasswordChar = '\0';
			this.tbUsername.PlaceholderText = "Username";
			this.tbUsername.SelectedText = "";
			this.tbUsername.Size = new System.Drawing.Size(205, 34);
			this.tbUsername.TabIndex = 220;
			this.tbUsername.Tag = "User Name";
			this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(73, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(162, 19);
			this.label6.TabIndex = 217;
			this.label6.Text = "Confirm Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(109, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 19);
			this.label3.TabIndex = 216;
			this.label3.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(109, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 19);
			this.label1.TabIndex = 215;
			this.label1.Text = "UserName:";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.DarkGray;
			this.panel8.Controls.Add(this.btnLoginInfo);
			this.panel8.Controls.Add(this.btnPersonalInfo);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(0, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(930, 50);
			this.panel8.TabIndex = 0;
			// 
			// btnLoginInfo
			// 
			this.btnLoginInfo.Animated = true;
			this.btnLoginInfo.BorderColor = System.Drawing.Color.Transparent;
			this.btnLoginInfo.BorderThickness = 2;
			this.btnLoginInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLoginInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLoginInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLoginInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLoginInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLoginInfo.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnLoginInfo.FillColor = System.Drawing.Color.SlateGray;
			this.btnLoginInfo.FocusedColor = System.Drawing.Color.SkyBlue;
			this.btnLoginInfo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoginInfo.ForeColor = System.Drawing.Color.White;
			this.btnLoginInfo.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnLoginInfo.Location = new System.Drawing.Point(233, 0);
			this.btnLoginInfo.Name = "btnLoginInfo";
			this.btnLoginInfo.Size = new System.Drawing.Size(233, 50);
			this.btnLoginInfo.TabIndex = 1;
			this.btnLoginInfo.Tag = "arabic";
			this.btnLoginInfo.Text = "LoginInfo";
			this.btnLoginInfo.Click += new System.EventHandler(this.btnLoginInfo_Click);
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
			this.btnPersonalInfo.FillColor = System.Drawing.Color.LightSkyBlue;
			this.btnPersonalInfo.FocusedColor = System.Drawing.Color.LightSkyBlue;
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
			this.btnNext.Image = global::DVLI.Properties.Resources.icons8_next;
			this.btnNext.Location = new System.Drawing.Point(789, 640);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(133, 45);
			this.btnNext.TabIndex = 82;
			this.btnNext.Text = "  Next";
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
			this.btnBack.Image = global::DVLI.Properties.Resources.icons8_double_left;
			this.btnBack.Location = new System.Drawing.Point(63, 640);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(133, 45);
			this.btnBack.TabIndex = 83;
			this.btnBack.Text = "  Back";
			this.btnBack.Visible = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
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
			this.btnClose.Image = global::DVLI.Properties.Resources.icons8_close;
			this.btnClose.Location = new System.Drawing.Point(435, 641);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(133, 45);
			this.btnClose.TabIndex = 82;
			this.btnClose.Text = "  Close";
			this.btnClose.Visible = false;
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// frmAddNewUser
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1011, 709);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAddNewUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAddNewUser";
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
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.Label lbAddNewOrUpdate;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel plContainerAboutAs;
		private System.Windows.Forms.Panel plPersonalInf;
		private uctlPersonInfoWithFilter uctlPersonInfoWithFilter1;
		private System.Windows.Forms.Panel plLoginInfo;
		private System.Windows.Forms.Panel panel8;
		private Guna.UI2.WinForms.Guna2Button btnLoginInfo;
		private Guna.UI2.WinForms.Guna2Button btnPersonalInfo;
		private Guna.UI2.WinForms.Guna2Button btnNext;
		private Guna.UI2.WinForms.Guna2Button btnBack;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbUsername;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label lbUserID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbIsActive;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}