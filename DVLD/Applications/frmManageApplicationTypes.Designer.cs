namespace DVLI
{
	partial class frmManageApplicationTypes
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbApplicationTypesRecordCont = new System.Windows.Forms.Label();
			this.gvApplicationTypes = new Guna.UI2.WinForms.Guna2DataGridView();
			this.cmsApplicationTypes = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.tsmEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
			this.btnClose = new Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gvApplicationTypes)).BeginInit();
			this.cmsApplicationTypes.SuspendLayout();
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
			this.panel1.TabIndex = 4;
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
			this.label.Size = new System.Drawing.Size(256, 25);
			this.label.TabIndex = 80;
			this.label.Text = "Manage Application Types";
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
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// lbApplicationTypesRecordCont
			// 
			this.lbApplicationTypesRecordCont.AutoSize = true;
			this.lbApplicationTypesRecordCont.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbApplicationTypesRecordCont.ForeColor = System.Drawing.Color.Black;
			this.lbApplicationTypesRecordCont.Location = new System.Drawing.Point(13, 626);
			this.lbApplicationTypesRecordCont.Name = "lbApplicationTypesRecordCont";
			this.lbApplicationTypesRecordCont.Size = new System.Drawing.Size(97, 22);
			this.lbApplicationTypesRecordCont.TabIndex = 45;
			this.lbApplicationTypesRecordCont.Text = "# Records: 5";
			// 
			// gvApplicationTypes
			// 
			this.gvApplicationTypes.AllowUserToAddRows = false;
			this.gvApplicationTypes.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.gvApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvApplicationTypes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.gvApplicationTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.gvApplicationTypes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gvApplicationTypes.ColumnHeadersHeight = 80;
			this.gvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.gvApplicationTypes.DefaultCellStyle = dataGridViewCellStyle3;
			this.gvApplicationTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.gvApplicationTypes.GridColor = System.Drawing.Color.Black;
			this.gvApplicationTypes.Location = new System.Drawing.Point(17, 66);
			this.gvApplicationTypes.Name = "gvApplicationTypes";
			this.gvApplicationTypes.ReadOnly = true;
			this.gvApplicationTypes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.gvApplicationTypes.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
			this.gvApplicationTypes.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.gvApplicationTypes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvApplicationTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvApplicationTypes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
			this.gvApplicationTypes.RowTemplate.Height = 60;
			this.gvApplicationTypes.Size = new System.Drawing.Size(752, 557);
			this.gvApplicationTypes.TabIndex = 44;
			this.gvApplicationTypes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
			this.gvApplicationTypes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.gvApplicationTypes.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.gvApplicationTypes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvApplicationTypes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.gvApplicationTypes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.gvApplicationTypes.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gvApplicationTypes.ThemeStyle.GridColor = System.Drawing.Color.Black;
			this.gvApplicationTypes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.gvApplicationTypes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.gvApplicationTypes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvApplicationTypes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.gvApplicationTypes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.gvApplicationTypes.ThemeStyle.HeaderStyle.Height = 80;
			this.gvApplicationTypes.ThemeStyle.ReadOnly = true;
			this.gvApplicationTypes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gainsboro;
			this.gvApplicationTypes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.gvApplicationTypes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gvApplicationTypes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
			this.gvApplicationTypes.ThemeStyle.RowsStyle.Height = 60;
			this.gvApplicationTypes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
			this.gvApplicationTypes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
			// 
			// cmsApplicationTypes
			// 
			this.cmsApplicationTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.cmsApplicationTypes.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cmsApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditApplicationType});
			this.cmsApplicationTypes.Name = "cmsApplicationTypes";
			this.cmsApplicationTypes.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.cmsApplicationTypes.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.cmsApplicationTypes.RenderStyle.ColorTable = null;
			this.cmsApplicationTypes.RenderStyle.RoundedEdges = true;
			this.cmsApplicationTypes.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.cmsApplicationTypes.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.cmsApplicationTypes.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.cmsApplicationTypes.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.cmsApplicationTypes.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.cmsApplicationTypes.Size = new System.Drawing.Size(225, 30);
			// 
			// tsmEditApplicationType
			// 
			this.tsmEditApplicationType.ForeColor = System.Drawing.Color.White;
			this.tsmEditApplicationType.Image = global::DVLI.Properties.Resources.icons8_change;
			this.tsmEditApplicationType.Name = "tsmEditApplicationType";
			this.tsmEditApplicationType.Size = new System.Drawing.Size(224, 26);
			this.tsmEditApplicationType.Text = "Edit Application Type";
			this.tsmEditApplicationType.Click += new System.EventHandler(this.tsmEditApplicationType_Click);
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
			this.btnClose.Location = new System.Drawing.Point(337, 652);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(112, 45);
			this.btnClose.TabIndex = 129;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// frmManageApplicationTypes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.ClientSize = new System.Drawing.Size(796, 718);
			this.ContextMenuStrip = this.cmsApplicationTypes;
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lbApplicationTypesRecordCont);
			this.Controls.Add(this.gvApplicationTypes);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmManageApplicationTypes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmManageApplicationTypes";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gvApplicationTypes)).EndInit();
			this.cmsApplicationTypes.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbApplicationTypesRecordCont;
		private Guna.UI2.WinForms.Guna2DataGridView gvApplicationTypes;
		private System.Windows.Forms.Label label;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsApplicationTypes;
		private System.Windows.Forms.ToolStripMenuItem tsmEditApplicationType;
		private Guna.UI2.WinForms.Guna2Button btnClose;
	}
}