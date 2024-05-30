namespace DVLI
{
	partial class frmIssueDriverLicenseForTheFirstTime
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
			this.tbNotes = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.uctlDLDApplicationCompleteInformation1 = new DVLI.uctlDLDApplicationCompleteInformation();
			this.plTopBar.SuspendLayout();
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
			this.plTopBar.Size = new System.Drawing.Size(943, 42);
			this.plTopBar.TabIndex = 5;
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
			this.lbHeader.Size = new System.Drawing.Size(299, 25);
			this.lbHeader.TabIndex = 80;
			this.lbHeader.Text = "Issue Driver License First Time";
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
			this.pbClose.Location = new System.Drawing.Point(900, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(43, 42);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 0;
			this.pbClose.TabStop = false;
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// tbNotes
			// 
			this.tbNotes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbNotes.Location = new System.Drawing.Point(141, 565);
			this.tbNotes.Name = "tbNotes";
			this.tbNotes.Size = new System.Drawing.Size(756, 98);
			this.tbNotes.TabIndex = 7;
			this.tbNotes.Text = "";
			this.tbNotes.TextChanged += new System.EventHandler(this.tbNotes_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(51, 563);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 19);
			this.label1.TabIndex = 8;
			this.label1.Text = "Notes:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
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
			this.btnSave.Image = global::DVLI.Properties.Resources.icons8_Travel_Insurance2;
			this.btnSave.ImageOffset = new System.Drawing.Point(-5, 0);
			this.btnSave.Location = new System.Drawing.Point(789, 673);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(112, 45);
			this.btnSave.TabIndex = 124;
			this.btnSave.Text = "Issue";
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
			this.btnClose.Location = new System.Drawing.Point(663, 673);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 123;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// uctlDLDApplicationCompleteInformation1
			// 
			this.uctlDLDApplicationCompleteInformation1.Location = new System.Drawing.Point(25, 70);
			this.uctlDLDApplicationCompleteInformation1.Name = "uctlDLDApplicationCompleteInformation1";
			this.uctlDLDApplicationCompleteInformation1.Size = new System.Drawing.Size(884, 469);
			this.uctlDLDApplicationCompleteInformation1.TabIndex = 6;
			// 
			// frmIssueDriverLicenseForTheFirstTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 758);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbNotes);
			this.Controls.Add(this.uctlDLDApplicationCompleteInformation1);
			this.Controls.Add(this.plTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmIssueDriverLicenseForTheFirstTime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmIssueDriverLicenseForTheFirstTime";
			this.plTopBar.ResumeLayout(false);
			this.plTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel plTopBar;
		public System.Windows.Forms.Label lbHeader;
		private System.Windows.Forms.Label lbTodayDate;
		private System.Windows.Forms.PictureBox pbClose;
		private uctlDLDApplicationCompleteInformation uctlDLDApplicationCompleteInformation1;
		private System.Windows.Forms.RichTextBox tbNotes;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}