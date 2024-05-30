﻿namespace DVLI.Applications
{
	partial class frmEditTestType
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
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbFees = new Guna.UI2.WinForms.Guna2TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbDescription = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbTitle = new Guna.UI2.WinForms.Guna2TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbTestTypeID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(521, 41);
			this.panel1.TabIndex = 6;
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
			this.label.Size = new System.Drawing.Size(146, 25);
			this.label.TabIndex = 80;
			this.label.Text = "Edit TakeAppointment Type";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::DVLI.Properties.Resources.icons8_cancel_12;
			this.pictureBox1.Location = new System.Drawing.Point(473, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 41);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnSave
			// 
			this.btnSave.BorderColor = System.Drawing.Color.Transparent;
			this.btnSave.BorderRadius = 10;
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
			this.btnSave.Location = new System.Drawing.Point(194, 352);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(133, 48);
			this.btnSave.TabIndex = 219;
			this.btnSave.Text = "  Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tbFees);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.tbDescription);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbTitle);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.lbTestTypeID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.groupBox1.Location = new System.Drawing.Point(17, 59);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(466, 284);
			this.groupBox1.TabIndex = 218;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TakeAppointment Type Information";
			// 
			// tbFees
			// 
			this.tbFees.Animated = true;
			this.tbFees.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFees.DefaultText = "";
			this.tbFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFees.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.tbFees.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbFees.ForeColor = System.Drawing.Color.Black;
			this.tbFees.HoverState.BorderColor = System.Drawing.Color.Black;
			this.tbFees.Location = new System.Drawing.Point(138, 203);
			this.tbFees.Margin = new System.Windows.Forms.Padding(4);
			this.tbFees.Name = "tbFees";
			this.tbFees.PasswordChar = '\0';
			this.tbFees.PlaceholderText = "Fees";
			this.tbFees.SelectedText = "";
			this.tbFees.Size = new System.Drawing.Size(282, 48);
			this.tbFees.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(57, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Fees:";
			// 
			// tbDescription
			// 
			this.tbDescription.Animated = true;
			this.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbDescription.DefaultText = "";
			this.tbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbDescription.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbDescription.ForeColor = System.Drawing.Color.Black;
			this.tbDescription.HoverState.BorderColor = System.Drawing.Color.Black;
			this.tbDescription.Location = new System.Drawing.Point(138, 138);
			this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.PasswordChar = '\0';
			this.tbDescription.PlaceholderText = "Description";
			this.tbDescription.SelectedText = "";
			this.tbDescription.Size = new System.Drawing.Size(282, 48);
			this.tbDescription.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(3, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Description:";
			// 
			// tbTitle
			// 
			this.tbTitle.Animated = true;
			this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbTitle.DefaultText = "";
			this.tbTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbTitle.FocusedState.BorderColor = System.Drawing.Color.Black;
			this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbTitle.ForeColor = System.Drawing.Color.Black;
			this.tbTitle.HoverState.BorderColor = System.Drawing.Color.Black;
			this.tbTitle.Location = new System.Drawing.Point(138, 75);
			this.tbTitle.Margin = new System.Windows.Forms.Padding(4);
			this.tbTitle.Name = "tbTitle";
			this.tbTitle.PasswordChar = '\0';
			this.tbTitle.PlaceholderText = "Title";
			this.tbTitle.SelectedText = "";
			this.tbTitle.Size = new System.Drawing.Size(282, 48);
			this.tbTitle.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(57, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Title:";
			// 
			// lbTestTypeID
			// 
			this.lbTestTypeID.AutoSize = true;
			this.lbTestTypeID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTestTypeID.ForeColor = System.Drawing.Color.Black;
			this.lbTestTypeID.Location = new System.Drawing.Point(159, 33);
			this.lbTestTypeID.Name = "lbTestTypeID";
			this.lbTestTypeID.Size = new System.Drawing.Size(51, 23);
			this.lbTestTypeID.TabIndex = 11;
			this.lbTestTypeID.Text = "[???]";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(67, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 23);
			this.label1.TabIndex = 12;
			this.label1.Text = "ID:";
			// 
			// frmEditTestType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 409);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmEditTestType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmEditTestType";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private Guna.UI2.WinForms.Guna2TextBox tbFees;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2TextBox tbDescription;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox tbTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbTestTypeID;
		private System.Windows.Forms.Label label1;
	}
}