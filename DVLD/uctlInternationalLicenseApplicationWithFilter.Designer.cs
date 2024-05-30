namespace DVLI
{
	partial class uctlInternationalLicenseApplicationWithFilter
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.uctlDriverLicenseInfo1 = new DVLI.uctlDriverLicenseInfo();
			this.label1 = new System.Windows.Forms.Label();
			this.gbFilterByLicenseID = new System.Windows.Forms.GroupBox();
			this.tbLicenseID = new Guna.UI2.WinForms.Guna2TextBox();
			this.pbSearchLicense = new System.Windows.Forms.Button();
			this.gbFilterByLicenseID.SuspendLayout();
			this.SuspendLayout();
			// 
			// uctlDriverLicenseInfo1
			// 
			this.uctlDriverLicenseInfo1.IsDetain = false;
			this.uctlDriverLicenseInfo1.License = null;
			this.uctlDriverLicenseInfo1.Location = new System.Drawing.Point(4, 167);
			this.uctlDriverLicenseInfo1.Name = "uctlDriverLicenseInfo1";
			this.uctlDriverLicenseInfo1.Person = null;
			this.uctlDriverLicenseInfo1.Size = new System.Drawing.Size(844, 362);
			this.uctlDriverLicenseInfo1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "LicenseID:";
			// 
			// gbFilterByLicenseID
			// 
			this.gbFilterByLicenseID.Controls.Add(this.pbSearchLicense);
			this.gbFilterByLicenseID.Controls.Add(this.tbLicenseID);
			this.gbFilterByLicenseID.Controls.Add(this.label1);
			this.gbFilterByLicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbFilterByLicenseID.Location = new System.Drawing.Point(13, 18);
			this.gbFilterByLicenseID.Name = "gbFilterByLicenseID";
			this.gbFilterByLicenseID.Size = new System.Drawing.Size(814, 113);
			this.gbFilterByLicenseID.TabIndex = 2;
			this.gbFilterByLicenseID.TabStop = false;
			this.gbFilterByLicenseID.Text = "Filter";
			// 
			// tbLicenseID
			// 
			this.tbLicenseID.BackColor = System.Drawing.Color.Transparent;
			this.tbLicenseID.BorderThickness = 2;
			this.tbLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbLicenseID.DefaultText = "";
			this.tbLicenseID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbLicenseID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbLicenseID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbLicenseID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbLicenseID.FillColor = System.Drawing.Color.WhiteSmoke;
			this.tbLicenseID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.tbLicenseID.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbLicenseID.ForeColor = System.Drawing.Color.Black;
			this.tbLicenseID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbLicenseID.Location = new System.Drawing.Point(146, 35);
			this.tbLicenseID.Name = "tbLicenseID";
			this.tbLicenseID.PasswordChar = '\0';
			this.tbLicenseID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.tbLicenseID.PlaceholderText = "License ID";
			this.tbLicenseID.SelectedText = "";
			this.tbLicenseID.Size = new System.Drawing.Size(422, 29);
			this.tbLicenseID.TabIndex = 2;
			// 
			// pbSearchLicense
			// 
			this.pbSearchLicense.Image = global::DVLI.Properties.Resources.icons8_identification_documents1;
			this.pbSearchLicense.Location = new System.Drawing.Point(606, 30);
			this.pbSearchLicense.Name = "pbSearchLicense";
			this.pbSearchLicense.Size = new System.Drawing.Size(38, 39);
			this.pbSearchLicense.TabIndex = 48;
			this.pbSearchLicense.UseVisualStyleBackColor = true;
			this.pbSearchLicense.Click += new System.EventHandler(this.pbSearchLicense_Click);
			// 
			// uctlInternationalLicenseApplicationWithFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbFilterByLicenseID);
			this.Controls.Add(this.uctlDriverLicenseInfo1);
			this.Name = "uctlInternationalLicenseApplicationWithFilter";
			this.Size = new System.Drawing.Size(847, 529);
			this.gbFilterByLicenseID.ResumeLayout(false);
			this.gbFilterByLicenseID.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private uctlDriverLicenseInfo uctlDriverLicenseInfo1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbFilterByLicenseID;
		private Guna.UI2.WinForms.Guna2TextBox tbLicenseID;
		private System.Windows.Forms.Button pbSearchLicense;
	}
}
