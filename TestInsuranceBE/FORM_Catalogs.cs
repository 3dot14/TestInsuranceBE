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
	public partial class FORM_Catalogs : Form
	{
		public FORM_Catalogs()
		{
			InitializeComponent();
		}

		private void BUTTON_DescripcionMercancias_Click(object sender, EventArgs e)
		{
			InsuranceBE.Catalogs Ctlgs = new InsuranceBE.Catalogs();
			DataTable DescrpMer = Ctlgs.DtDescripcionMercancias(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_Catalogs.DataSource = DescrpMer;
		}

		private void BUTTON_TipoVehiculo_Click(object sender, EventArgs e)
		{
			InsuranceBE.Catalogs Ctlgs = new InsuranceBE.Catalogs();
			DataTable TipoVehiculo = Ctlgs.DtTiposVehiculo(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_Catalogs.DataSource = TipoVehiculo;
		}

		private void BUTTON_GrupoMercancia_Click(object sender, EventArgs e)
		{
			InsuranceBE.Catalogs Ctlgs = new InsuranceBE.Catalogs();
			DataTable GpoMercancia = Ctlgs.DtGruposMercancia(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_Catalogs.DataSource = GpoMercancia;
		}

		private void BUTTON_EstadosMexico_Click(object sender, EventArgs e)
		{
			InsuranceBE.Catalogs Ctlgs = new InsuranceBE.Catalogs();
			DataTable EdosMexico = Ctlgs.DtEstadosMexico(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_Catalogs.DataSource = EdosMexico;

		}

		private void BUTTON_TipoLineaTrans_Click(object sender, EventArgs e)
		{
			InsuranceBE.Catalogs Ctlgs = new InsuranceBE.Catalogs();
			DataTable TipoLinea = Ctlgs.DtTiposLineaTransporte(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_Catalogs.DataSource = TipoLinea;

		}

		private void BUTTON_QueryTiposMercancia_Click(object sender, EventArgs e)
		{
			InsuranceBE.Catalogs Ctlgs = new InsuranceBE.Catalogs();
			DataTable TiposMercancia = Ctlgs.QueryDtTiposMercancia(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_Catalogs.DataSource = TiposMercancia;
		}

		private void BUTTON_QueryContainer_Click(object sender, EventArgs e)
		{
			InsuranceBE.Catalogs Ctlgs = new InsuranceBE.Catalogs();
			DataTable QueryContainer = Ctlgs.QueryDtContainer(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_Catalogs.DataSource = QueryContainer;

		}

		private void BUTTON_QueryNote_Click(object sender, EventArgs e)
		{
			InsuranceBE.Catalogs Ctlgs = new InsuranceBE.Catalogs();
			DataTable QueryNote = Ctlgs.QueryDtNote(TEXTBOX_ConnectionString.Text);
			DATAGRIDVIEW_Catalogs.DataSource = QueryNote;
		}
	}
}
