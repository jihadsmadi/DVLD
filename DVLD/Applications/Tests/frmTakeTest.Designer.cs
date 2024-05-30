namespace DVLI
{
	partial class frmTakeTest
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
			this.gbTestDetails = new Guna.UI2.WinForms.Guna2GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbTrail = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbApplicant = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lbDClass = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbFees = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbDLAppID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.lbTestID = new System.Windows.Forms.Label();
			this.l = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pbTestPicture = new System.Windows.Forms.PictureBox();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.tbNotes = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.rbPass = new System.Windows.Forms.RadioButton();
			this.rbFail = new System.Windows.Forms.RadioButton();
			this.plTopBar.SuspendLayout();
			this.gbTestDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTestPicture)).BeginInit();
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
			this.plTopBar.Size = new System.Drawing.Size(518, 42);
			this.plTopBar.TabIndex = 4;
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
			this.lbHeader.Size = new System.Drawing.Size(102, 25);
			this.lbHeader.TabIndex = 80;
			this.lbHeader.Text = "Take Test";
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
			// gbTestDetails
			// 
			this.gbTestDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.gbTestDetails.BorderThickness = 3;
			this.gbTestDetails.Controls.Add(this.lbTestID);
			this.gbTestDetails.Controls.Add(this.pictureBox1);
			this.gbTestDetails.Controls.Add(this.l);
			this.gbTestDetails.Controls.Add(this.lbDate);
			this.gbTestDetails.Controls.Add(this.pictureBox6);
			this.gbTestDetails.Controls.Add(this.label6);
			this.gbTestDetails.Controls.Add(this.lbTrail);
			this.gbTestDetails.Controls.Add(this.pictureBox4);
			this.gbTestDetails.Controls.Add(this.label5);
			this.gbTestDetails.Controls.Add(this.lbApplicant);
			this.gbTestDetails.Controls.Add(this.pictureBox8);
			this.gbTestDetails.Controls.Add(this.label11);
			this.gbTestDetails.Controls.Add(this.lbDClass);
			this.gbTestDetails.Controls.Add(this.pictureBox3);
			this.gbTestDetails.Controls.Add(this.label3);
			this.gbTestDetails.Controls.Add(this.lbFees);
			this.gbTestDetails.Controls.Add(this.pictureBox5);
			this.gbTestDetails.Controls.Add(this.label7);
			this.gbTestDetails.Controls.Add(this.lbDLAppID);
			this.gbTestDetails.Controls.Add(this.pictureBox2);
			this.gbTestDetails.Controls.Add(this.label1);
			this.gbTestDetails.Controls.Add(this.pbTestPicture);
			this.gbTestDetails.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.gbTestDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTestDetails.ForeColor = System.Drawing.Color.White;
			this.gbTestDetails.Location = new System.Drawing.Point(12, 66);
			this.gbTestDetails.Name = "gbTestDetails";
			this.gbTestDetails.Size = new System.Drawing.Size(487, 466);
			this.gbTestDetails.TabIndex = 5;
			this.gbTestDetails.Text = "Vision TakeAppointment";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(54, 353);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 19);
			this.label6.TabIndex = 33;
			this.label6.Text = "Date:";
			// 
			// lbTrail
			// 
			this.lbTrail.AutoSize = true;
			this.lbTrail.BackColor = System.Drawing.Color.Transparent;
			this.lbTrail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTrail.ForeColor = System.Drawing.Color.Black;
			this.lbTrail.Location = new System.Drawing.Point(158, 318);
			this.lbTrail.Name = "lbTrail";
			this.lbTrail.Size = new System.Drawing.Size(45, 19);
			this.lbTrail.TabIndex = 32;
			this.lbTrail.Text = "[???]";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(53, 318);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 19);
			this.label5.TabIndex = 30;
			this.label5.Text = "Trial:";
			// 
			// lbApplicant
			// 
			this.lbApplicant.AutoSize = true;
			this.lbApplicant.BackColor = System.Drawing.Color.Transparent;
			this.lbApplicant.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbApplicant.ForeColor = System.Drawing.Color.Black;
			this.lbApplicant.Location = new System.Drawing.Point(158, 283);
			this.lbApplicant.Name = "lbApplicant";
			this.lbApplicant.Size = new System.Drawing.Size(45, 19);
			this.lbApplicant.TabIndex = 29;
			this.lbApplicant.Text = "[???]";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(35, 283);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 19);
			this.label11.TabIndex = 27;
			this.label11.Text = "Person:";
			// 
			// lbDClass
			// 
			this.lbDClass.AutoSize = true;
			this.lbDClass.BackColor = System.Drawing.Color.Transparent;
			this.lbDClass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDClass.ForeColor = System.Drawing.Color.Black;
			this.lbDClass.Location = new System.Drawing.Point(158, 248);
			this.lbDClass.Name = "lbDClass";
			this.lbDClass.Size = new System.Drawing.Size(45, 19);
			this.lbDClass.TabIndex = 26;
			this.lbDClass.Text = "[???]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(27, 248);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 19);
			this.label3.TabIndex = 24;
			this.label3.Text = "D. Class:";
			// 
			// lbFees
			// 
			this.lbFees.AutoSize = true;
			this.lbFees.BackColor = System.Drawing.Color.Transparent;
			this.lbFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbFees.ForeColor = System.Drawing.Color.Black;
			this.lbFees.Location = new System.Drawing.Point(158, 389);
			this.lbFees.Name = "lbFees";
			this.lbFees.Size = new System.Drawing.Size(45, 19);
			this.lbFees.TabIndex = 23;
			this.lbFees.Text = "[???]";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(54, 389);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 19);
			this.label7.TabIndex = 21;
			this.label7.Text = "Fees:";
			// 
			// lbDLAppID
			// 
			this.lbDLAppID.AutoSize = true;
			this.lbDLAppID.BackColor = System.Drawing.Color.Transparent;
			this.lbDLAppID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDLAppID.ForeColor = System.Drawing.Color.Red;
			this.lbDLAppID.Location = new System.Drawing.Point(158, 213);
			this.lbDLAppID.Name = "lbDLAppID";
			this.lbDLAppID.Size = new System.Drawing.Size(45, 19);
			this.lbDLAppID.TabIndex = 17;
			this.lbDLAppID.Text = "[???]";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(9, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 19);
			this.label1.TabIndex = 15;
			this.label1.Text = "D.L.App.ID:";
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.BackColor = System.Drawing.Color.Transparent;
			this.lbDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDate.ForeColor = System.Drawing.Color.Black;
			this.lbDate.Location = new System.Drawing.Point(158, 351);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(45, 19);
			this.lbDate.TabIndex = 35;
			this.lbDate.Text = "[???]";
			// 
			// lbTestID
			// 
			this.lbTestID.AutoSize = true;
			this.lbTestID.BackColor = System.Drawing.Color.Transparent;
			this.lbTestID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTestID.ForeColor = System.Drawing.Color.Black;
			this.lbTestID.Location = new System.Drawing.Point(158, 424);
			this.lbTestID.Name = "lbTestID";
			this.lbTestID.Size = new System.Drawing.Size(110, 19);
			this.lbTestID.TabIndex = 38;
			this.lbTestID.Text = "Not Taken Yet";
			// 
			// l
			// 
			this.l.AutoSize = true;
			this.l.BackColor = System.Drawing.Color.Transparent;
			this.l.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.l.ForeColor = System.Drawing.Color.Black;
			this.l.Location = new System.Drawing.Point(33, 424);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(75, 19);
			this.l.TabIndex = 36;
			this.l.Text = "Test ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(45, 555);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 19);
			this.label2.TabIndex = 38;
			this.label2.Text = "Result:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(45, 590);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 19);
			this.label4.TabIndex = 41;
			this.label4.Text = "Notes:";
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox9.Image = global::DVLI.Properties.Resources.icons8_Application_Form1;
			this.pictureBox9.Location = new System.Drawing.Point(121, 585);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(34, 29);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 42;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox7.Image = global::DVLI.Properties.Resources.icons8_test_1;
			this.pictureBox7.Location = new System.Drawing.Point(121, 550);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(34, 29);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 39;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::DVLI.Properties.Resources.icons8_id_button;
			this.pictureBox1.Location = new System.Drawing.Point(114, 419);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 29);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox6.Image = global::DVLI.Properties.Resources.icons8_schedule;
			this.pictureBox6.Location = new System.Drawing.Point(114, 348);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(34, 29);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 34;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.Image = global::DVLI.Properties.Resources.icons8_reminders1;
			this.pictureBox4.Location = new System.Drawing.Point(114, 313);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(34, 29);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 31;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox8.Image = global::DVLI.Properties.Resources.icons8_attendance1;
			this.pictureBox8.Location = new System.Drawing.Point(114, 278);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(34, 29);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 28;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = global::DVLI.Properties.Resources.icons8_car_insurance1;
			this.pictureBox3.Location = new System.Drawing.Point(114, 243);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(34, 29);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 25;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox5.Image = global::DVLI.Properties.Resources.icons8_average;
			this.pictureBox5.Location = new System.Drawing.Point(114, 384);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(34, 29);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 22;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::DVLI.Properties.Resources.icons8_id_button;
			this.pictureBox2.Location = new System.Drawing.Point(114, 208);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 29);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// pbTestPicture
			// 
			this.pbTestPicture.Image = global::DVLI.Properties.Resources.hand_drawn_eye_vector_1024x7711;
			this.pbTestPicture.Location = new System.Drawing.Point(110, 42);
			this.pbTestPicture.Name = "pbTestPicture";
			this.pbTestPicture.Size = new System.Drawing.Size(220, 161);
			this.pbTestPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTestPicture.TabIndex = 0;
			this.pbTestPicture.TabStop = false;
			// 
			// pbClose
			// 
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.pbClose.Image = global::DVLI.Properties.Resources.icons8_cancel_1;
			this.pbClose.Location = new System.Drawing.Point(475, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 42);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// tbNotes
			// 
			this.tbNotes.BorderColor = System.Drawing.Color.Black;
			this.tbNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbNotes.DefaultText = "";
			this.tbNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbNotes.ForeColor = System.Drawing.Color.Black;
			this.tbNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNotes.Location = new System.Drawing.Point(174, 585);
			this.tbNotes.Name = "tbNotes";
			this.tbNotes.PasswordChar = '\0';
			this.tbNotes.PlaceholderText = "";
			this.tbNotes.SelectedText = "";
			this.tbNotes.Size = new System.Drawing.Size(325, 93);
			this.tbNotes.TabIndex = 43;
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
			this.btnSave.Location = new System.Drawing.Point(387, 686);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(112, 45);
			this.btnSave.TabIndex = 122;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
			this.btnClose.Location = new System.Drawing.Point(13, 686);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 121;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// rbPass
			// 
			this.rbPass.AutoSize = true;
			this.rbPass.Font = new System.Drawing.Font("Tahoma", 11F);
			this.rbPass.Location = new System.Drawing.Point(174, 553);
			this.rbPass.Name = "rbPass";
			this.rbPass.Size = new System.Drawing.Size(56, 22);
			this.rbPass.TabIndex = 123;
			this.rbPass.TabStop = true;
			this.rbPass.Text = "Pass";
			this.rbPass.UseVisualStyleBackColor = true;
			// 
			// rbFail
			// 
			this.rbFail.AutoSize = true;
			this.rbFail.Font = new System.Drawing.Font("Tahoma", 11F);
			this.rbFail.Location = new System.Drawing.Point(236, 553);
			this.rbFail.Name = "rbFail";
			this.rbFail.Size = new System.Drawing.Size(46, 22);
			this.rbFail.TabIndex = 124;
			this.rbFail.TabStop = true;
			this.rbFail.Text = "Fail";
			this.rbFail.UseVisualStyleBackColor = true;
			// 
			// frmTakeTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 749);
			this.Controls.Add(this.rbFail);
			this.Controls.Add(this.rbPass);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.tbNotes);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gbTestDetails);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTakeTest";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmTakeTest";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			this.gbTestDetails.ResumeLayout(false);
			this.gbTestDetails.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbTestPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		public System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		public Guna.UI2.WinForms.Guna2GroupBox gbTestDetails;
		private System.Windows.Forms.Label lbTestID;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label l;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbTrail;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbApplicant;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lbDClass;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbFees;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbDLAppID;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbTestPicture;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox tbNotes;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private Guna.UI2.WinForms.Guna2Button btnClose;
		private System.Windows.Forms.RadioButton rbPass;
		private System.Windows.Forms.RadioButton rbFail;
	}
}