using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Business_Layer.clsApplicationTypes;

namespace DVLI
{
	public partial class frmShowLocalDrivingApplicationInfo : Form
	{
		public frmShowLocalDrivingApplicationInfo(int LocalDrivingApplication)
		{
			InitializeComponent();
			this.uctlPersonInfo1.LoadPersonInfo(clsApplications.Find(clsLocalDrivingLicenseApplications.Find(LocalDrivingApplication).ApplicationID).ApplicationPersonID);
			this.uctlDLDApplicationCompleteInformation1.FillTheForm(LocalDrivingApplication);

		}
		//Making The Form Move
		private bool isClick = false;
		int x, y;

		private void plTopBar_MouseDown(object sender, MouseEventArgs e)
		{
			isClick = true;
			x = e.X;
			y = e.Y;
		}
		private void plTopBar_MouseUp(object sender, MouseEventArgs e)
		{
			isClick = false;
		}
		private void plTopBar_MouseMove(object sender, MouseEventArgs e)
		{

			if (isClick)
			{


				this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
			}
		}
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
