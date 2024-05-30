namespace DVLI.Applications
{
	partial class frmManageTestTypes
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label = new System.Windows.Forms.Label();
			this.lbTestTypesRecordCont = new System.Windows.Forms.Label();
			this.gvTestTypes = new Guna.UI2.WinForms.Guna2DataGridView();
			this.cmsTestTypes = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tsmEditTestType = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvTestTypes)).BeginInit();
			this.cmsTestTypes.SuspendLayout();
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
			this.panel1.Size = new System.Drawing.Size(796, 41);
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
			this.label.Size = new System.Drawing.Size(192, 25);
			this.label.TabIndex = 80;
			this.label.Text = "Manage TakeAppointment Types";
			// 
			// lbTestTypesRecordCont
			// 
			this.lbTestTypesRecordCont.AutoSize = true;
			this.lbTestTypesRecordCont.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTestTypesRecordCont.ForeColor = System.Drawing.Color.Black;
			this.lbTestTypesRecordCont.Location = new System.Drawing.Point(13, 630);
			this.lbTestTypesRecordCont.Name = "lbTestTypesRecordCont";
			this.lbTestTypesRecordCont.Size = new System.Drawing.Size(97, 22);
			this.lbTestTypesRecordCont.TabIndex = 131;
			this.lbTestTypesRecordCont.Text = "# Records: 5";
			// 
			// gvTestTypes
			// 
			this.gvTestTypes.AllowUserToAddRows = false;
			this.gvTestTypes.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.gvTestTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvTestTypes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gvTestTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvTestTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gvTestTypes.ColumnHeadersHeight = 80;
			this.gvTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvTestTypes.ContextMenuStrip = this.cmsTestTypes;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvTestTypes.DefaultCellStyle = dataGridViewCellStyle3;
			this.gvTestTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvTestTypes.GridColor = System.Drawing.Color.Black;
			this.gvTestTypes.Location = new System.Drawing.Point(17, 70);
			this.gvTestTypes.Name = "gvTestTypes";
			this.gvTestTypes.ReadOnly = true;
			this.gvTestTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.gvTestTypes.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.gvTestTypes.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.gvTestTypes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvTestTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvTestTypes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.gvTestTypes.RowTemplate.Height = 60;
			this.gvTestTypes.Size = new System.Drawing.Size(752, 557);
			this.gvTestTypes.TabIndex = 130;
			this.gvTestTypes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
			this.gvTestTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gvTestTypes.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gvTestTypes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvTestTypes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gvTestTypes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gvTestTypes.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gvTestTypes.ThemeStyle.GridColor = System.Drawing.Color.Black;
			this.gvTestTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.gvTestTypes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gvTestTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F);
			this.gvTestTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gvTestTypes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvTestTypes.ThemeStyle.HeaderStyle.Height = 80;
			this.gvTestTypes.ThemeStyle.ReadOnly = true;
			this.gvTestTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvTestTypes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvTestTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F);
			this.gvTestTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvTestTypes.ThemeStyle.RowsStyle.Height = 60;
			this.gvTestTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvTestTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// cmsTestTypes
			// 
			this.cmsTestTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.cmsTestTypes.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cmsTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditTestType});
			this.cmsTestTypes.Name = "cmsApplicationTypes";
			this.cmsTestTypes.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.cmsTestTypes.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.cmsTestTypes.RenderStyle.ColorTable = null;
			this.cmsTestTypes.RenderStyle.RoundedEdges = true;
			this.cmsTestTypes.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.cmsTestTypes.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.cmsTestTypes.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.cmsTestTypes.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.cmsTestTypes.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.cmsTestTypes.Size = new System.Drawing.Size(177, 30);
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
			this.btnClose.Location = new System.Drawing.Point(337, 656);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 132;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::DVLI.Properties.Resources.icons8_cancel_12;
			this.pictureBox1.Location = new System.Drawing.Point(748, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 41);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// tsmEditTestType
			// 
			this.tsmEditTestType.ForeColor = System.Drawing.Color.White;
			this.tsmEditTestType.Image = global::DVLI.Properties.Resources.icons8_change;
			this.tsmEditTestType.Name = "tsmEditTestType";
			this.tsmEditTestType.Size = new System.Drawing.Size(176, 26);
			this.tsmEditTestType.Text = "Edit TakeAppointment  Type";
			this.tsmEditTestType.Click += new System.EventHandler(this.tsmEditTestType_Click);
			// 
			// frmManageTestTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 718);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbTestTypesRecordCont);
			this.Controls.Add(this.gvTestTypes);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmManageTestTypes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmManageTestTypes";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvTestTypes)).EndInit();
			this.cmsTestTypes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2Button btnClose;
		private System.Windows.Forms.Label lbTestTypesRecordCont;
		private Guna.UI2.WinForms.Guna2DataGridView gvTestTypes;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsTestTypes;
		private System.Windows.Forms.ToolStripMenuItem tsmEditTestType;
	}
}