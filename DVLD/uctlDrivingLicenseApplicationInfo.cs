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

namespace DVLI
{
	public partial class uctlDrivingLicenseApplicationInfo : UserControl
	{
		public uctlDrivingLicenseApplicationInfo()
		{
			InitializeComponent();
		}
		public void FillTheForm(int DLApplicationInfo)
		{
			clsLocalDrivingLicenseApplications Application = clsLocalDrivingLicenseApplications.Find(DLApplicationInfo);

			if(Application != null)
			{
				lbDLAppID.Text = Application.LocalDrivingLicenseApplicationID.ToString();
				lbAppliedForLicense.Text = Application.ClassName();
				lbPassedTests.Text = Application.PassedTestCount().ToString() + "/3";
			}
		}

	}
}
