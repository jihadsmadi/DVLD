namespace DVLI
{
	partial class uctlPersonInfoWithFilter
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
			this.btnSearchPerson = new System.Windows.Forms.Button();
			this.pbAddNewPerson = new System.Windows.Forms.PictureBox();
			this.tbFilterBy = new Guna.UI2.WinForms.Guna2TextBox();
			this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.uctlPersonInfo1 = new DVLI.uctlPersonInfo();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAddNewPerson)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearchPerson);
			this.groupBox1.Controls.Add(this.pbAddNewPerson);
			this.groupBox1.Controls.Add(this.tbFilterBy);
			this.groupBox1.Controls.Add(this.cbFilterBy);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(844, 80);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = " Filter";
			// 
			// btnSearchPerson
			// 
			this.btnSearchPerson.BackColor = System.Drawing.Color.Transparent;
			this.btnSearchPerson.Image = global::DVLI.Properties.Resources.icons8_find_user_male_skin_type_7;
			this.btnSearchPerson.Location = new System.Drawing.Point(713, 31);
			this.btnSearchPerson.Name = "btnSearchPerson";
			this.btnSearchPerson.Size = new System.Drawing.Size(38, 32);
			this.btnSearchPerson.TabIndex = 46;
			this.btnSearchPerson.UseVisualStyleBackColor = false;
			this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
			// 
			// pbAddNewPerson
			// 
			this.pbAddNewPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbAddNewPerson.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbAddNewPerson.Image = global::DVLI.Properties.Resources.icons8_add_user_male_skin_type_7;
			this.pbAddNewPerson.Location = new System.Drawing.Point(757, 31);
			this.pbAddNewPerson.Name = "pbAddNewPerson";
			this.pbAddNewPerson.Size = new System.Drawing.Size(38, 32);
			this.pbAddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbAddNewPerson.TabIndex = 45;
			this.pbAddNewPerson.TabStop = false;
			this.pbAddNewPerson.Click += new System.EventHandler(this.pbAddNewPerson_Click);
			// 
			// tbFilterBy
			// 
			this.tbFilterBy.Animated = true;
			this.tbFilterBy.BorderColor = System.Drawing.Color.Black;
			this.tbFilterBy.BorderRadius = 12;
			this.tbFilterBy.BorderThickness = 2;
			this.tbFilterBy.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbFilterBy.DefaultText = "";
			this.tbFilterBy.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbFilterBy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbFilterBy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFilterBy.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbFilterBy.FocusedState.BorderColor = System.Drawing.Color.LightBlue;
			this.tbFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbFilterBy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbFilterBy.Location = new System.Drawing.Point(343, 27);
			this.tbFilterBy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbFilterBy.Name = "tbFilterBy";
			this.tbFilterBy.PasswordChar = '\0';
			this.tbFilterBy.PlaceholderForeColor = System.Drawing.Color.Gray;
			this.tbFilterBy.PlaceholderText = "";
			this.tbFilterBy.SelectedText = "";
			this.tbFilterBy.Size = new System.Drawing.Size(195, 36);
			this.tbFilterBy.TabIndex = 0;
			// 
			// cbFilterBy
			// 
			this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
			this.cbFilterBy.BorderColor = System.Drawing.Color.Black;
			this.cbFilterBy.BorderRadius = 15;
			this.cbFilterBy.BorderThickness = 2;
			this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFilterBy.FocusedColor = System.Drawing.Color.LightBlue;
			this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.LightBlue;
			this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 14.25F);
			this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbFilterBy.ItemHeight = 30;
			this.cbFilterBy.Items.AddRange(new object[] {
            "NationalNo",
            "PersonID"});
			this.cbFilterBy.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
			this.cbFilterBy.Location = new System.Drawing.Point(128, 27);
			this.cbFilterBy.Name = "cbFilterBy";
			this.cbFilterBy.Size = new System.Drawing.Size(195, 36);
			this.cbFilterBy.Sorted = true;
			this.cbFilterBy.TabIndex = 44;
			this.cbFilterBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Yu Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(23, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 27);
			this.label6.TabIndex = 43;
			this.label6.Text = "Find By:";
			// 
			// uctlPersonInfo1
			// 
			this.uctlPersonInfo1.Location = new System.Drawing.Point(3, 105);
			this.uctlPersonInfo1.Name = "uctlPersonInfo1";
			this.uctlPersonInfo1.Size = new System.Drawing.Size(844, 313);
			this.uctlPersonInfo1.TabIndex = 1;
			// 
			// uctlPersonInfoWithFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.uctlPersonInfo1);
			this.Controls.Add(this.groupBox1);
			this.Name = "uctlPersonInfoWithFilter";
			this.Size = new System.Drawing.Size(860, 417);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbAddNewPerson)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pbAddNewPerson;
		private Guna.UI2.WinForms.Guna2TextBox tbFilterBy;
		private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
		private System.Windows.Forms.Label label6;
		private uctlPersonInfo uctlPersonInfo1;
		private System.Windows.Forms.Button btnSearchPerson;
	}
}
