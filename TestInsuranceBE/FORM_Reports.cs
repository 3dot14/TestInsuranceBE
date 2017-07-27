using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInsuranceBE
{
	

	public partial class FORM_Reports : Form
	{
		public FORM_Reports()
		{
			InitializeComponent();
		}

		private void BUTTON_QueryReports_Click(object sender, EventArgs e)
		{
			InsuranceBE.Reports report = new InsuranceBE.Reports();

			DATAGRIDVIEW_QueryReports.DataSource= report.QueryViewGeneralReport(TEXTBOX_ConnectionString.Text);
		}
	}
}
