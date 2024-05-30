namespace DVLI
{
	partial class uctlLoginInfo
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbIsActive = new System.Windows.Forms.Label();
			this.lbUserName = new System.Windows.Forms.Label();
			this.lbUserID = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.uctlPersonInfo1 = new DVLI.uctlPersonInfo();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbIsActive);
			this.groupBox1.Controls.Add(this.lbUserName);
			this.groupBox1.Controls.Add(this.lbUserID);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
			this.groupBox1.Location = new System.Drawing.Point(4, 322);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(829, 79);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login Information";
			// 
			// lbIsActive
			// 
			this.lbIsActive.AutoSize = true;
			this.lbIsActive.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lbIsActive.Location = new System.Drawing.Point(614, 48);
			this.lbIsActive.Name = "lbIsActive";
			this.lbIsActive.Size = new System.Drawing.Size(45, 19);
			this.lbIsActive.TabIndex = 5;
			this.lbIsActive.Text = "[???]";
			// 
			// lbUserName
			// 
			this.lbUserName.AutoSize = true;
			this.lbUserName.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lbUserName.Location = new System.Drawing.Point(357, 48);
			this.lbUserName.Name = "lbUserName";
			this.lbUserName.Size = new System.Drawing.Size(45, 19);
			this.lbUserName.TabIndex = 6;
			this.lbUserName.Text = "[???]";
			// 
			// lbUserID
			// 
			this.lbUserID.AutoSize = true;
			this.lbUserID.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lbUserID.Location = new System.Drawing.Point(77, 48);
			this.lbUserID.Name = "lbUserID";
			this.lbUserID.Size = new System.Drawing.Size(45, 19);
			this.lbUserID.TabIndex = 7;
			this.lbUserID.Text = "[???]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(529, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "IsActive:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(256, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "UserName:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "UserID:";
			// 
			// uctlPersonInfo1
			// 
			this.uctlPersonInfo1.Location = new System.Drawing.Point(0, 1);
			this.uctlPersonInfo1.Name = "uctlPersonInfo1";
			this.uctlPersonInfo1.Size = new System.Drawing.Size(844, 313);
			this.uctlPersonInfo1.TabIndex = 1;
			// 
			// uctlLoginInfo
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.uctlPersonInfo1);
			this.Controls.Add(this.groupBox1);
			this.Name = "uctlLoginInfo";
			this.Size = new System.Drawing.Size(836, 410);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbIsActive;
		private System.Windows.Forms.Label lbUserName;
		private System.Windows.Forms.Label lbUserID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private uctlPersonInfo uctlPersonInfo1;
	}
}
