namespace DVLI
{
	partial class frmTestAppointments
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.plTopBar = new System.Windows.Forms.Panel();
			this.lbHeadar = new System.Windows.Forms.Label();
			this.lbTodayDate = new System.Windows.Forms.Label();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gvAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
			this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
			this.lbAppointmentRecordCount = new System.Windows.Forms.Label();
			this.uctlDLDApplicationCompleteInformation1 = new DVLI.uctlDLDApplicationCompleteInformation();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.btnReserveAppointment = new Guna.UI2.WinForms.Guna2Button();
			this.plTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvAppointments)).BeginInit();
			this.cmsAppointments.SuspendLayout();
			this.SuspendLayout();
			// 
			// plTopBar
			// 
			this.plTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.plTopBar.Controls.Add(this.lbHeadar);
			this.plTopBar.Controls.Add(this.lbTodayDate);
			this.plTopBar.Controls.Add(this.pbClose);
			this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.plTopBar.Location = new System.Drawing.Point(0, 0);
			this.plTopBar.Name = "plTopBar";
			this.plTopBar.Size = new System.Drawing.Size(956, 42);
			this.plTopBar.TabIndex = 2;
			this.plTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.plTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.plTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// lbHeadar
			// 
			this.lbHeadar.AutoSize = true;
			this.lbHeadar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbHeadar.ForeColor = System.Drawing.Color.White;
			this.lbHeadar.Location = new System.Drawing.Point(9, 7);
			this.lbHeadar.Name = "lbHeadar";
			this.lbHeadar.Size = new System.Drawing.Size(240, 25);
			this.lbHeadar.TabIndex = 80;
			this.lbHeadar.Text = "Vision Test Appointment";
			this.lbHeadar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
			this.pbClose.Location = new System.Drawing.Point(913, 0);
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
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 508);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(151, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Appointments:";
			// 
			// gvAppointments
			// 
			this.gvAppointments.AllowUserToAddRows = false;
			this.gvAppointments.AllowUserToDeleteRows = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			this.gvAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.gvAppointments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 12F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.gvAppointments.ColumnHeadersHeight = 50;
			this.gvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvAppointments.ContextMenuStrip = this.cmsAppointments;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvAppointments.DefaultCellStyle = dataGridViewCellStyle8;
			this.gvAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvAppointments.GridColor = System.Drawing.Color.Black;
			this.gvAppointments.Location = new System.Drawing.Point(28, 547);
			this.gvAppointments.Name = "gvAppointments";
			this.gvAppointments.ReadOnly = true;
			this.gvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 12F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.gvAppointments.RowHeadersVisible = false;
			this.gvAppointments.RowHeadersWidth = 25;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
			this.gvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.gvAppointments.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvAppointments.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvAppointments.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.gvAppointments.RowTemplate.Height = 60;
			this.gvAppointments.Size = new System.Drawing.Size(884, 252);
			this.gvAppointments.TabIndex = 46;
			this.gvAppointments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
			this.gvAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gvAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gvAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gvAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gvAppointments.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gvAppointments.ThemeStyle.GridColor = System.Drawing.Color.Black;
			this.gvAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.gvAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gvAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F);
			this.gvAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gvAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvAppointments.ThemeStyle.HeaderStyle.Height = 50;
			this.gvAppointments.ThemeStyle.ReadOnly = true;
			this.gvAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F);
			this.gvAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvAppointments.ThemeStyle.RowsStyle.Height = 60;
			this.gvAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// cmsAppointments
			// 
			this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.tsmTakeTest});
			this.cmsAppointments.Name = "contextMenuStrip1";
			this.cmsAppointments.Size = new System.Drawing.Size(138, 56);
			// 
			// tsmEdit
			// 
			this.tsmEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tsmEdit.Image = global::DVLI.Properties.Resources.icons8_autograph_1;
			this.tsmEdit.Name = "tsmEdit";
			this.tsmEdit.Size = new System.Drawing.Size(137, 26);
			this.tsmEdit.Text = "Edit";
			this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
			// 
			// tsmTakeTest
			// 
			this.tsmTakeTest.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tsmTakeTest.Image = global::DVLI.Properties.Resources.icons8_approval_11;
			this.tsmTakeTest.Name = "tsmTakeTest";
			this.tsmTakeTest.Size = new System.Drawing.Size(137, 26);
			this.tsmTakeTest.Text = "Take Test";
			this.tsmTakeTest.Click += new System.EventHandler(this.tsmTakeTest_Click);
			// 
			// lbAppointmentRecordCount
			// 
			this.lbAppointmentRecordCount.AutoSize = true;
			this.lbAppointmentRecordCount.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAppointmentRecordCount.ForeColor = System.Drawing.Color.Black;
			this.lbAppointmentRecordCount.Location = new System.Drawing.Point(24, 822);
			this.lbAppointmentRecordCount.Name = "lbAppointmentRecordCount";
			this.lbAppointmentRecordCount.Size = new System.Drawing.Size(97, 22);
			this.lbAppointmentRecordCount.TabIndex = 51;
			this.lbAppointmentRecordCount.Text = "# Records: 5";
			// 
			// uctlDLDApplicationCompleteInformation1
			// 
			this.uctlDLDApplicationCompleteInformation1.Location = new System.Drawing.Point(28, 46);
			this.uctlDLDApplicationCompleteInformation1.Name = "uctlDLDApplicationCompleteInformation1";
			this.uctlDLDApplicationCompleteInformation1.Size = new System.Drawing.Size(884, 459);
			this.uctlDLDApplicationCompleteInformation1.TabIndex = 3;
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
			this.btnClose.Location = new System.Drawing.Point(800, 805);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 118;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// btnReserveAppointment
			// 
			this.btnReserveAppointment.Animated = true;
			this.btnReserveAppointment.BackColor = System.Drawing.Color.Transparent;
			this.btnReserveAppointment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
			this.btnReserveAppointment.BorderRadius = 10;
			this.btnReserveAppointment.BorderThickness = 2;
			this.btnReserveAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnReserveAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnReserveAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnReserveAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnReserveAppointment.FillColor = System.Drawing.Color.White;
			this.btnReserveAppointment.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnReserveAppointment.ForeColor = System.Drawing.Color.Black;
			this.btnReserveAppointment.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnReserveAppointment.Image = global::DVLI.Properties.Resources.icons8_add;
			this.btnReserveAppointment.Location = new System.Drawing.Point(807, 503);
			this.btnReserveAppointment.Name = "btnReserveAppointment";
			this.btnReserveAppointment.Size = new System.Drawing.Size(105, 40);
			this.btnReserveAppointment.TabIndex = 52;
			this.btnReserveAppointment.Text = "Reserve";
			this.btnReserveAppointment.Click += new System.EventHandler(this.btnReserveAppointment_Click);
			this.btnReserveAppointment.MouseHover += new System.EventHandler(this.btnReserveAppointment_MouseHover);
			// 
			// frmTestAppointments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 853);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnReserveAppointment);
			this.Controls.Add(this.lbAppointmentRecordCount);
			this.Controls.Add(this.gvAppointments);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.uctlDLDApplicationCompleteInformation1);
			this.Controls.Add(this.plTopBar);
			this.Font = new System.Drawing.Font("Tahoma", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmTestAppointments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmViseionTestAppointments";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvAppointments)).EndInit();
			this.cmsAppointments.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		private uctlDLDApplicationCompleteInformation uctlDLDApplicationCompleteInformation1;
		private System.Windows.Forms.Label lbHeadar;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DataGridView gvAppointments;
		private System.Windows.Forms.Label lbAppointmentRecordCount;
		private Guna.UI2.WinForms.Guna2Button btnReserveAppointment;
		private Guna.UI2.WinForms.Guna2Button btnClose;
		private System.Windows.Forms.ContextMenuStrip cmsAppointments;
		private System.Windows.Forms.ToolStripMenuItem tsmEdit;
		private System.Windows.Forms.ToolStripMenuItem tsmTakeTest;
	}
}