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
	public partial class FORM_FolioGenerate : Form
	{
		public FORM_FolioGenerate()
		{
			InitializeComponent();
		}

		private void BUTTON_FolioGenerate_Click(object sender, EventArgs e)
		{
			InsuranceBE.Calculations Calculation = new InsuranceBE.Calculations();
			TEXTBOX_Folio.Text = Calculation.GenFolioCertificatePdf(TEXTBOX_ConnectionString.Text, Int32.Parse(TEXTBOX_CertificateId.Text));

		}
	}
}
