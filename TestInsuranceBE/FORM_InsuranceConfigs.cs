using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TestInsuranceBE
{
	public partial class FORM_InsuranceConfigs : Form
	{

		InsuranceBE.InsuranceConfigs Configs = new InsuranceBE.InsuranceConfigs();

		public FORM_InsuranceConfigs()
		{
			InitializeComponent();
		}

		private void BUTTON_QueryInsuranceConfig_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt = Configs.QueryInsuranceConfig(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_InsuranceConfig.DataSource = dt;


		}

		private void BUTTON_InsertInsuranceConfig_Click(object sender, EventArgs e)
		{
			Configs.InsertInsuranceConfig(Int32.Parse(TEXTBOX_UserId.Text), Int32.Parse(TEXTBOX_AppId.Text), TEXTBOX_ConnectionString.Text, TEXTBOX_Iva.Text, TEXTBOX_HoursAdd.Text, TEXTBOX_PolicyNumber.Text, new byte[0], new byte[0], new byte[0]);
		}

		private void BUTON_UpdateInsuranceConfig_Click(object sender, EventArgs e)
		{
			Configs.UpdateInsuraceConfig(Int32.Parse(TEXTBOX_RowId.Text), Int32.Parse(TEXTBOX_EnableSystem.Text), Int32.Parse(TEXTBOX_UserId.Text), Int32.Parse(TEXTBOX_AppId.Text), TEXTBOX_ConnectionString.Text, TEXTBOX_Iva.Text, TEXTBOX_HoursAdd.Text, TEXTBOX_PolicyNumber.Text, new byte[0], new byte[0], new byte[0]);
		}

		private void BUTTON_LogoEmpresa_Click(object sender, EventArgs e)
		{
			

		}
	}
}
