namespace DVLI
{
	partial class frmLicenseHistory
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.plTopBar = new System.Windows.Forms.Panel();
			this.lbHeader = new System.Windows.Forms.Label();
			this.lbTodayDate = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.tabControlLocal = new System.Windows.Forms.TabControl();
			this.tabPageLocal = new System.Windows.Forms.TabPage();
			this.lbLocalRecordCount = new System.Windows.Forms.Label();
			this.gvLocalLicense = new Guna.UI2.WinForms.Guna2DataGridView();
			this.tabPageInternational = new System.Windows.Forms.TabPage();
			this.lbInternationRecordCount = new System.Windows.Forms.Label();
			this.gvInternationallicenses = new Guna.UI2.WinForms.Guna2DataGridView();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.cmsLocalDrivingLicenseInHistoryLicenses = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.tsmShowPersonInfoInDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmShowLicenseDetailsInDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.uctlPersonInfo1 = new DVLI.uctlPersonInfo();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.guna2GroupBox1.SuspendLayout();
			this.tabControlLocal.SuspendLayout();
			this.tabPageLocal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvLocalLicense)).BeginInit();
			this.tabPageInternational.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvInternationallicenses)).BeginInit();
			this.cmsLocalDrivingLicenseInHistoryLicenses.SuspendLayout();
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
			this.plTopBar.Size = new System.Drawing.Size(1156, 42);
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
			this.lbHeader.Size = new System.Drawing.Size(151, 25);
			this.lbHeader.TabIndex = 80;
			this.lbHeader.Text = "License History";
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
			this.pbClose.Location = new System.Drawing.Point(1113, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 42);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DVLI.Properties.Resources.istockphoto_838089762_612x612;
			this.pictureBox1.Location = new System.Drawing.Point(18, 65);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(230, 313);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.tabControlLocal);
			this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
			this.guna2GroupBox1.Location = new System.Drawing.Point(18, 417);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(1102, 376);
			this.guna2GroupBox1.TabIndex = 9;
			this.guna2GroupBox1.Text = "Driver Licenses";
			// 
			// tabControlLocal
			// 
			this.tabControlLocal.Controls.Add(this.tabPageLocal);
			this.tabControlLocal.Controls.Add(this.tabPageInternational);
			this.tabControlLocal.Location = new System.Drawing.Point(22, 58);
			this.tabControlLocal.Name = "tabControlLocal";
			this.tabControlLocal.SelectedIndex = 0;
			this.tabControlLocal.Size = new System.Drawing.Size(1065, 290);
			this.tabControlLocal.TabIndex = 0;
			// 
			// tabPageLocal
			// 
			this.tabPageLocal.Controls.Add(this.lbLocalRecordCount);
			this.tabPageLocal.Controls.Add(this.gvLocalLicense);
			this.tabPageLocal.Location = new System.Drawing.Point(4, 34);
			this.tabPageLocal.Name = "tabPageLocal";
			this.tabPageLocal.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLocal.Size = new System.Drawing.Size(1057, 252);
			this.tabPageLocal.TabIndex = 0;
			this.tabPageLocal.Text = "Local";
			this.tabPageLocal.UseVisualStyleBackColor = true;
			// 
			// lbLocalRecordCount
			// 
			this.lbLocalRecordCount.AutoSize = true;
			this.lbLocalRecordCount.BackColor = System.Drawing.Color.Transparent;
			this.lbLocalRecordCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLocalRecordCount.ForeColor = System.Drawing.Color.Black;
			this.lbLocalRecordCount.Location = new System.Drawing.Point(6, 225);
			this.lbLocalRecordCount.Name = "lbLocalRecordCount";
			this.lbLocalRecordCount.Size = new System.Drawing.Size(97, 22);
			this.lbLocalRecordCount.TabIndex = 51;
			this.lbLocalRecordCount.Text = "# Records: 5";
			// 
			// gvLocalLicense
			// 
			this.gvLocalLicense.AllowUserToAddRows = false;
			this.gvLocalLicense.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.gvLocalLicense.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvLocalLicense.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gvLocalLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvLocalLicense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvLocalLicense.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gvLocalLicense.ColumnHeadersHeight = 80;
			this.gvLocalLicense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvLocalLicense.ContextMenuStrip = this.cmsLocalDrivingLicenseInHistoryLicenses;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvLocalLicense.DefaultCellStyle = dataGridViewCellStyle3;
			this.gvLocalLicense.Dock = System.Windows.Forms.DockStyle.Top;
			this.gvLocalLicense.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvLocalLicense.GridColor = System.Drawing.Color.Black;
			this.gvLocalLicense.Location = new System.Drawing.Point(3, 3);
			this.gvLocalLicense.Name = "gvLocalLicense";
			this.gvLocalLicense.ReadOnly = true;
			this.gvLocalLicense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvLocalLicense.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.gvLocalLicense.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.gvLocalLicense.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.gvLocalLicense.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvLocalLicense.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvLocalLicense.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.gvLocalLicense.RowTemplate.Height = 60;
			this.gvLocalLicense.Size = new System.Drawing.Size(1051, 219);
			this.gvLocalLicense.TabIndex = 46;
			this.gvLocalLicense.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
			this.gvLocalLicense.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gvLocalLicense.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gvLocalLicense.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvLocalLicense.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gvLocalLicense.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gvLocalLicense.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gvLocalLicense.ThemeStyle.GridColor = System.Drawing.Color.Black;
			this.gvLocalLicense.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.gvLocalLicense.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gvLocalLicense.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvLocalLicense.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gvLocalLicense.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvLocalLicense.ThemeStyle.HeaderStyle.Height = 80;
			this.gvLocalLicense.ThemeStyle.ReadOnly = true;
			this.gvLocalLicense.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvLocalLicense.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvLocalLicense.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvLocalLicense.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.gvLocalLicense.ThemeStyle.RowsStyle.Height = 60;
			this.gvLocalLicense.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvLocalLicense.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// tabPageInternational
			// 
			this.tabPageInternational.Controls.Add(this.lbInternationRecordCount);
			this.tabPageInternational.Controls.Add(this.gvInternationallicenses);
			this.tabPageInternational.Location = new System.Drawing.Point(4, 34);
			this.tabPageInternational.Name = "tabPageInternational";
			this.tabPageInternational.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageInternational.Size = new System.Drawing.Size(1057, 252);
			this.tabPageInternational.TabIndex = 1;
			this.tabPageInternational.Text = "International";
			this.tabPageInternational.UseVisualStyleBackColor = true;
			// 
			// lbInternationRecordCount
			// 
			this.lbInternationRecordCount.AutoSize = true;
			this.lbInternationRecordCount.BackColor = System.Drawing.Color.Transparent;
			this.lbInternationRecordCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbInternationRecordCount.ForeColor = System.Drawing.Color.Black;
			this.lbInternationRecordCount.Location = new System.Drawing.Point(4, 225);
			this.lbInternationRecordCount.Name = "lbInternationRecordCount";
			this.lbInternationRecordCount.Size = new System.Drawing.Size(97, 22);
			this.lbInternationRecordCount.TabIndex = 52;
			this.lbInternationRecordCount.Text = "# Records: 5";
			// 
			// gvInternationallicenses
			// 
			this.gvInternationallicenses.AllowUserToAddRows = false;
			this.gvInternationallicenses.AllowUserToDeleteRows = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			this.gvInternationallicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.gvInternationallicenses.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gvInternationallicenses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvInternationallicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvInternationallicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.gvInternationallicenses.ColumnHeadersHeight = 80;
			this.gvInternationallicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvInternationallicenses.DefaultCellStyle = dataGridViewCellStyle8;
			this.gvInternationallicenses.Dock = System.Windows.Forms.DockStyle.Top;
			this.gvInternationallicenses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvInternationallicenses.GridColor = System.Drawing.Color.Black;
			this.gvInternationallicenses.Location = new System.Drawing.Point(3, 3);
			this.gvInternationallicenses.Name = "gvInternationallicenses";
			this.gvInternationallicenses.ReadOnly = true;
			this.gvInternationallicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvInternationallicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.gvInternationallicenses.RowHeadersVisible = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
			this.gvInternationallicenses.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.gvInternationallicenses.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvInternationallicenses.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvInternationallicenses.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.gvInternationallicenses.RowTemplate.Height = 60;
			this.gvInternationallicenses.Size = new System.Drawing.Size(1051, 219);
			this.gvInternationallicenses.TabIndex = 47;
			this.gvInternationallicenses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
			this.gvInternationallicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gvInternationallicenses.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gvInternationallicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvInternationallicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gvInternationallicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gvInternationallicenses.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gvInternationallicenses.ThemeStyle.GridColor = System.Drawing.Color.Black;
			this.gvInternationallicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.gvInternationallicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gvInternationallicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvInternationallicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gvInternationallicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvInternationallicenses.ThemeStyle.HeaderStyle.Height = 80;
			this.gvInternationallicenses.ThemeStyle.ReadOnly = true;
			this.gvInternationallicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvInternationallicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvInternationallicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvInternationallicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
			this.gvInternationallicenses.ThemeStyle.RowsStyle.Height = 60;
			this.gvInternationallicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvInternationallicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
			this.btnClose.Location = new System.Drawing.Point(1008, 799);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 120;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// cmsLocalDrivingLicenseInHistoryLicenses
			// 
			this.cmsLocalDrivingLicenseInHistoryLicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.cmsLocalDrivingLicenseInHistoryLicenses.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.cmsLocalDrivingLicenseInHistoryLicenses.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsLocalDrivingLicenseInHistoryLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.tsmShowPersonInfoInDetainedLicenses,
            this.tsmShowLicenseDetailsInDetainedLicense,
            this.toolStripSeparator10});
			this.cmsLocalDrivingLicenseInHistoryLicenses.Name = "cmsPeople";
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.ColorTable = null;
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.RoundedEdges = true;
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.cmsLocalDrivingLicenseInHistoryLicenses.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.cmsLocalDrivingLicenseInHistoryLicenses.Size = new System.Drawing.Size(289, 116);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(285, 6);
			// 
			// tsmShowPersonInfoInDetainedLicenses
			// 
			this.tsmShowPersonInfoInDetainedLicenses.AutoSize = false;
			this.tsmShowPersonInfoInDetainedLicenses.ForeColor = System.Drawing.Color.White;
			this.tsmShowPersonInfoInDetainedLicenses.Image = global::DVLI.Properties.Resources.icons8_customer;
			this.tsmShowPersonInfoInDetainedLicenses.Name = "tsmShowPersonInfoInDetainedLicenses";
			this.tsmShowPersonInfoInDetainedLicenses.Size = new System.Drawing.Size(345, 50);
			this.tsmShowPersonInfoInDetainedLicenses.Text = "     Show Person Info";
			this.tsmShowPersonInfoInDetainedLicenses.Click += new System.EventHandler(this.tsmShowPersonInfoInDetainedLicenses_Click);
			// 
			// tsmShowLicenseDetailsInDetainedLicense
			// 
			this.tsmShowLicenseDetailsInDetainedLicense.AutoSize = false;
			this.tsmShowLicenseDetailsInDetainedLicense.ForeColor = System.Drawing.Color.White;
			this.tsmShowLicenseDetailsInDetainedLicense.Image = global::DVLI.Properties.Resources.icons8_view2;
			this.tsmShowLicenseDetailsInDetainedLicense.Name = "tsmShowLicenseDetailsInDetainedLicense";
			this.tsmShowLicenseDetailsInDetainedLicense.Size = new System.Drawing.Size(345, 50);
			this.tsmShowLicenseDetailsInDetainedLicense.Text = "     Show License Details";
			this.tsmShowLicenseDetailsInDetainedLicense.Click += new System.EventHandler(this.tsmShowLicenseDetailsInDetainedLicense_Click);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(285, 6);
			// 
			// uctlPersonInfo1
			// 
			this.uctlPersonInfo1.Location = new System.Drawing.Point(276, 65);
			this.uctlPersonInfo1.Name = "uctlPersonInfo1";
			this.uctlPersonInfo1.Size = new System.Drawing.Size(844, 313);
			this.uctlPersonInfo1.TabIndex = 8;
			// 
			// frmLicenseHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1156, 847);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.uctlPersonInfo1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLicenseHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLicenseHistory";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.guna2GroupBox1.ResumeLayout(false);
			this.tabControlLocal.ResumeLayout(false);
			this.tabPageLocal.ResumeLayout(false);
			this.tabPageLocal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvLocalLicense)).EndInit();
			this.tabPageInternational.ResumeLayout(false);
			this.tabPageInternational.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvInternationallicenses)).EndInit();
			this.cmsLocalDrivingLicenseInHistoryLicenses.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		public System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.PictureBox pictureBox1;
		private uctlPersonInfo uctlPersonInfo1;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private System.Windows.Forms.TabControl tabControlLocal;
		private System.Windows.Forms.TabPage tabPageLocal;
		private System.Windows.Forms.TabPage tabPageInternational;
		private Guna.UI2.WinForms.Guna2DataGridView gvLocalLicense;
		private Guna.UI2.WinForms.Guna2DataGridView gvInternationallicenses;
		private Guna.UI2.WinForms.Guna2Button btnClose;
		private System.Windows.Forms.Label lbLocalRecordCount;
		private System.Windows.Forms.Label lbInternationRecordCount;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsLocalDrivingLicenseInHistoryLicenses;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripMenuItem tsmShowPersonInfoInDetainedLicenses;
		private System.Windows.Forms.ToolStripMenuItem tsmShowLicenseDetailsInDetainedLicense;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
	}
}