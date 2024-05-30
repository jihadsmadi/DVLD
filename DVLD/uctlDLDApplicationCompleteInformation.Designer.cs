namespace DVLI
{
	partial class uctlDLDApplicationCompleteInformation
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
			this.uctlDrivingLicenseApplicationInfo1 = new DVLI.uctlDrivingLicenseApplicationInfo();
			this.uctlApplicationBasicInfo1 = new DVLI.uctlApplicationBasicInfo();
			this.SuspendLayout();
			// 
			// uctlDrivingLicenseApplicationInfo1
			// 
			this.uctlDrivingLicenseApplicationInfo1.Location = new System.Drawing.Point(0, 3);
			this.uctlDrivingLicenseApplicationInfo1.Name = "uctlDrivingLicenseApplicationInfo1";
			this.uctlDrivingLicenseApplicationInfo1.Size = new System.Drawing.Size(861, 146);
			this.uctlDrivingLicenseApplicationInfo1.TabIndex = 1;
			// 
			// uctlApplicationBasicInfo1
			// 
			this.uctlApplicationBasicInfo1.Location = new System.Drawing.Point(0, 169);
			this.uctlApplicationBasicInfo1.Name = "uctlApplicationBasicInfo1";
			this.uctlApplicationBasicInfo1.Size = new System.Drawing.Size(879, 292);
			this.uctlApplicationBasicInfo1.TabIndex = 0;
			// 
			// uctlDLDApplicationCompleteInformation
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.uctlDrivingLicenseApplicationInfo1);
			this.Controls.Add(this.uctlApplicationBasicInfo1);
			this.Name = "uctlDLDApplicationCompleteInformation";
			this.Size = new System.Drawing.Size(884, 469);
			this.ResumeLayout(false);

		}

		#endregion

		private uctlApplicationBasicInfo uctlApplicationBasicInfo1;
		private uctlDrivingLicenseApplicationInfo uctlDrivingLicenseApplicationInfo1;
	}
}
