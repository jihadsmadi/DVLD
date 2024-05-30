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
	public partial class uctlApplicationBasicInfo : UserControl
	{
		public uctlApplicationBasicInfo()
		{
			InitializeComponent();
		}

		clsApplications app;
		public void FillTheForm(int ApplicationID)
		{
			app = clsApplications.Find(ApplicationID);

			if (app != null)
			{
				lbApplicationID.Text = app.ApplicationID.ToString();
				lbDate.Text = app.ApplicationDate.ToShortDateString();
				lbStatus.Text = ((clsApplications.enApplicationStatus)app.ApplicationStatus).ToString();
				lbStatusDate.Text = app.LastStatusDate.ToShortDateString();
				lbFees.Text = app.PaidFees.ToString()+"$";
				lbCreatedBy.Text = clsUsers.Find(app.CreatedByUserID).UserName;
				lbType.Text = ((clsApplicationTypes.enApplicationTypes)app.ApplicationTypeID).ToString();
				lbApplicant.Text = clsPeople.Find(app.ApplicationPersonID).GetFullName();

				lbViewPersonInfo.Enabled = true;
			}
		}

		private void lbViewPersonInfo_Click(object sender, EventArgs e)
		{
			frmPersonDetails frm = new frmPersonDetails(app.ApplicationPersonID);
			frm.ShowDialog();
		}
	}
}
