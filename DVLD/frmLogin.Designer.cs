namespace DVLI
{
	partial class frmLogin
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
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
			this.cbRemeberMe = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbUserName = new Guna.UI2.WinForms.Guna2TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(63)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(721, 37);
			this.panel1.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = global::DVLI.Properties.Resources.icons8_cancel_12;
			this.pictureBox1.Location = new System.Drawing.Point(673, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 37);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnLogin);
			this.panel2.Controls.Add(this.cbRemeberMe);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.tbPassword);
			this.panel2.Controls.Add(this.tbUserName);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(325, 37);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(396, 471);
			this.panel2.TabIndex = 4;
			// 
			// btnLogin
			// 
			this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
			this.btnLogin.BorderRadius = 2;
			this.btnLogin.BorderThickness = 2;
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.HoverState.BorderColor = System.Drawing.Color.White;
			this.btnLogin.Image = global::DVLI.Properties.Resources.icons8_next1;
			this.btnLogin.Location = new System.Drawing.Point(132, 363);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.PressedColor = System.Drawing.Color.Transparent;
			this.btnLogin.Size = new System.Drawing.Size(131, 45);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "  Login";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// cbRemeberMe
			// 
			this.cbRemeberMe.AutoSize = true;
			this.cbRemeberMe.Location = new System.Drawing.Point(131, 275);
			this.cbRemeberMe.Name = "cbRemeberMe";
			this.cbRemeberMe.Size = new System.Drawing.Size(152, 27);
			this.cbRemeberMe.TabIndex = 4;
			this.cbRemeberMe.Text = "Remember Me";
			this.cbRemeberMe.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 223);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(103, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "UserName:";
			// 
			// tbPassword
			// 
			this.tbPassword.Animated = true;
			this.tbPassword.BorderColor = System.Drawing.Color.Black;
			this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPassword.DefaultText = "";
			this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.Blue;
			this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbPassword.HoverState.BorderColor = System.Drawing.Color.Blue;
			this.tbPassword.IconRight = global::DVLI.Properties.Resources.icons8_blind;
			this.tbPassword.Location = new System.Drawing.Point(131, 219);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.PlaceholderText = "Password";
			this.tbPassword.SelectedText = "";
			this.tbPassword.Size = new System.Drawing.Size(186, 31);
			this.tbPassword.TabIndex = 2;
			this.tbPassword.Tag = "Password";
			// 
			// tbUserName
			// 
			this.tbUserName.Animated = true;
			this.tbUserName.BorderColor = System.Drawing.Color.Black;
			this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUserName.DefaultText = "";
			this.tbUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUserName.FocusedState.BorderColor = System.Drawing.Color.Blue;
			this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbUserName.HoverState.BorderColor = System.Drawing.Color.Blue;
			this.tbUserName.Location = new System.Drawing.Point(132, 158);
			this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbUserName.Name = "tbUserName";
			this.tbUserName.PasswordChar = '\0';
			this.tbUserName.PlaceholderText = "UserName";
			this.tbUserName.SelectedText = "";
			this.tbUserName.Size = new System.Drawing.Size(186, 31);
			this.tbUserName.TabIndex = 1;
			this.tbUserName.Tag = "UserName";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
			this.label2.Location = new System.Drawing.Point(78, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(239, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Login to your account";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(721, 508);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLogin";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel2;
		private Guna.UI2.WinForms.Guna2Button btnLogin;
		private System.Windows.Forms.CheckBox cbRemeberMe;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private Guna.UI2.WinForms.Guna2TextBox tbPassword;
		private Guna.UI2.WinForms.Guna2TextBox tbUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}