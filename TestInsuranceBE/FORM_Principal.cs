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
    public partial class FORM_Principal : Form
    {
        public FORM_Principal()
        {
            InitializeComponent();
        }

        private void FORM_Principal_Load(object sender, EventArgs e)
        {

        }

        private void BOTON_TestInsurers_Click(object sender, EventArgs e)
        {
            FORM_Insurers fr = new FORM_Insurers();
            fr.Show();
        }

        private void BUTTON_TestAsocciate_Click(object sender, EventArgs e)
        {
            FORM_Associates fr = new FORM_Associates();
            fr.Show();
        }

        private void BUTTON_TestUsers_Click(object sender, EventArgs e)
        {
            FORM_Users fr = new FORM_Users();
            fr.Show();

        }

        private void BUTTON_TestClients_Click(object sender, EventArgs e)
        {
            FORM_Clients fr = new FORM_Clients();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FORM_CERTIFICATE_PDF fr = new FORM_CERTIFICATE_PDF();
            fr.Show();
        }

		private void BUTTON_TestCatalogs_Click(object sender, EventArgs e)
		{
			FORM_Catalogs fr = new FORM_Catalogs();
			fr.Show();
		}

		private void BUTTON_TestFolioGenerate_Click(object sender, EventArgs e)
		{
			FORM_FolioGenerate fr = new FORM_FolioGenerate();
			fr.Show();
		}

		private void BUTTON_InsuranceConfig_Click(object sender, EventArgs e)
		{
			FORM_InsuranceConfigs fr = new FORM_InsuranceConfigs();
			fr.Show();
		}

		private void BUTTON_TestReports_Click(object sender, EventArgs e)
		{
			FORM_Reports fr = new FORM_Reports();
			fr.Show();
		}

        private void BOTON_TestCsvInsurer_Click(object sender, EventArgs e)
        {
            FORM_CsvInsurer frm = new FORM_CsvInsurer();
            frm.ShowDialog();
        }
    }
}
