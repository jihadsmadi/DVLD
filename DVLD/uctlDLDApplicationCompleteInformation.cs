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
	public partial class uctlDLDApplicationCompleteInformation : UserControl
	{
		public uctlDLDApplicationCompleteInformation()
		{
			InitializeComponent();
		}

		public void FillTheForm(int LDLApplicationID)
		{
			uctlApplicationBasicInfo1.FillTheForm(clsLocalDrivingLicenseApplications.Find(LDLApplicationID).ApplicationID);
			uctlDrivingLicenseApplicationInfo1.FillTheForm(LDLApplicationID);
		}
	}
}
