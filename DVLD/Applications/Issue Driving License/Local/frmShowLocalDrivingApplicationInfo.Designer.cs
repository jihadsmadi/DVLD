namespace DVLI
{
	partial class frmShowLocalDrivingApplicationInfo
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.uctlPersonInfo1 = new DVLI.uctlPersonInfo();
			this.uctlDLDApplicationCompleteInformation1 = new DVLI.uctlDLDApplicationCompleteInformation();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.panel1.Controls.Add(this.label);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(908, 41);
			this.panel1.TabIndex = 5;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseMove);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plTopBar_MouseUp);
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label.ForeColor = System.Drawing.Color.White;
			this.label.Location = new System.Drawing.Point(12, 6);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(286, 25);
			this.label.TabIndex = 80;
			this.label.Text = "Local Application Information";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::DVLI.Properties.Resources.icons8_cancel_12;
			this.pictureBox1.Location = new System.Drawing.Point(860, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 41);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
			this.btnClose.Location = new System.Drawing.Point(772, 842);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 130;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// uctlPersonInfo1
			// 
			this.uctlPersonInfo1.Location = new System.Drawing.Point(17, 47);
			this.uctlPersonInfo1.Name = "uctlPersonInfo1";
			this.uctlPersonInfo1.Size = new System.Drawing.Size(844, 313);
			this.uctlPersonInfo1.TabIndex = 7;
			// 
			// uctlDLDApplicationCompleteInformation1
			// 
			this.uctlDLDApplicationCompleteInformation1.Location = new System.Drawing.Point(12, 366);
			this.uctlDLDApplicationCompleteInformation1.Name = "uctlDLDApplicationCompleteInformation1";
			this.uctlDLDApplicationCompleteInformation1.Size = new System.Drawing.Size(884, 469);
			this.uctlDLDApplicationCompleteInformation1.TabIndex = 6;
			// 
			// frmShowLocalDrivingApplicationInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(908, 891);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.uctlPersonInfo1);
			this.Controls.Add(this.uctlDLDApplicationCompleteInformation1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmShowLocalDrivingApplicationInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmShowLocalDrivingApplicationInfo";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.PictureBox pictureBox1;
		private uctlDLDApplicationCompleteInformation uctlDLDApplicationCompleteInformation1;
		private uctlPersonInfo uctlPersonInfo1;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}