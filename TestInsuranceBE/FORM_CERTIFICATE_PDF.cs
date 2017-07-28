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
    public partial class FORM_CERTIFICATE_PDF : Form
    {
        public FORM_CERTIFICATE_PDF()
        {
            InitializeComponent();
        }

      

        private void BUTTON_InsertClient_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_InsertPdfCertificate_Click(object sender, EventArgs e)
        {
            InsuranceBE.PdfCertificates PDF = new InsuranceBE.PdfCertificates();
             PDF.InsertPdfCertificate(Int32.Parse(TEXTBOX_UserId.Text), Int32.Parse(TEXTBOX_AppId.Text), TEXTBOX_ConnectionString.Text, Int32.Parse(TEXTBOX_CertificateId.Text), TEXTBOX_NoPoliza.Text, TEXTBOX_NoFolio.Text, TEXTBOX_FechaCertificado.Text, TEXTBOX_HrCertificado.Text,TEXTBOX_Asegurado.Text,TEXTBOX_Beneficiario.Text, TEXTBOX_YO.Text, TEXTBOX_RFC.Text, TEXTBOX_Calle.Text, TEXTBOX_NumInt.Text, TEXTBOX_NumExt.Text, TEXTBOX_Colonia.Text, TEXTBOX_Pais.Text, TEXTBOX_Estado.Text, TEXTBOX_Ciudad.Text, TEXTBOX_CodigoPostal.Text, TEXTBOX_GuiaPedimento.Text, TEXTBOX_IdContainer.Text, TEXTBOX_IniCobertura.Text, TEXTBOX_HraCobertura.Text, TEXTBOX_MedioTrans.Text, TEXTBOX_LineaTransporte.Text, TEXTBOX_Embarque.Text, TEXTBOX_TipoEmbarque.Text, TEXTBOX_NombreLineaTransportista.Text, TEXTBOX_Marca.Text, TEXTBOX_Modelo.Text, TEXTBOX_Placas.Text, TEXTBOX_NoMotor.Text, TEXTBOX_NoSerie.Text, TEXTBOX_Color.Text, TEXTBOX_NombreChofer.Text, TEXTBOX_CoberturaTrayecto.Text, TEXTBOX_CoberturaRiesgo.Text, TEXTBOX_CoberturaContenedores.Text, TEXTBOX_OrigenEmbarque.Text, TEXTBOX_PaisCobertura.Text, TEXTBOX_EstadoCobertura.Text, TEXTBOX_MunCobertura.Text, TEXTBOX_PaisDestino.Text, TEXTBOX_EstadoDestino.Text, TEXTBOX_MunCobertura.Text, TEXTBOX_DescripcionMercancia.Text, TEXTBOX_TipoEmpaque.Text, TEXTBOX_ValorEmbarque.Text, TEXTBOX_PrimaTotal.Text, TEXTBOX_Moneda.Text, TEXTBOX_NoRemolques.Text, TEXTBOX_CertificadoAmparo.Text, TEXTBOX_Contenedor1Descripcion.Text, TEXTBOX_Contenedor2Descripcion.Text, TEXTBOX_Observaciones.Text, TEXTBOX_CondicionesGenerales.Text, TEXTBOX_TelBienSeguro.Text, TEXTBOX_TelBienSeguro.Text, TEXTBOX_TelBienSeguro.Text, TEXTBOX_TelSiniestro.Text, TEXTBOX_MailSiniestro.Text, new byte[0], new byte[0], new byte[0]);
        }

        private void BUTTON_QueryPdfCertificate_Click(object sender, EventArgs e)
        {
            InsuranceBE.PdfCertificates PDF = new InsuranceBE.PdfCertificates();
            DataTable Dt = PDF.QueryPdfCertificate(TEXTBOX_ConnectionString.Text);
            DATAGRIDVIEW_PDFCertificate.DataSource = Dt;
        }

        private void BUTTON_UpdatePDFCertificate_Click(object sender, EventArgs e)
        {
            InsuranceBE.PdfCertificates PDF = new InsuranceBE.PdfCertificates();
            PDF.UpdatePDFCertificate(Int32.Parse(TEXTBOX_RowId.Text), Int32.Parse(TEXTBOX_EnableSystem.Text), Int32.Parse(TEXTBOX_UserId.Text), Int32.Parse(TEXTBOX_AppId.Text), TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_CertificateId.Text), TEXTBOX_NoPoliza.Text, TEXTBOX_NoFolio.Text, TEXTBOX_FechaCertificado.Text, TEXTBOX_HrCertificado.Text, TEXTBOX_Asegurado.Text, TEXTBOX_Beneficiario.Text, TEXTBOX_YO.Text, TEXTBOX_RFC.Text, TEXTBOX_Calle.Text, TEXTBOX_NumInt.Text, TEXTBOX_NumExt.Text, TEXTBOX_Colonia.Text, TEXTBOX_Pais.Text, TEXTBOX_Estado.Text, TEXTBOX_Ciudad.Text, TEXTBOX_CodigoPostal.Text, TEXTBOX_GuiaPedimento.Text, TEXTBOX_IdContainer.Text, TEXTBOX_IniCobertura.Text, TEXTBOX_HraCobertura.Text, TEXTBOX_MedioTrans.Text, TEXTBOX_LineaTransporte.Text, TEXTBOX_Embarque.Text, TEXTBOX_TipoEmbarque.Text, TEXTBOX_NombreLineaTransportista.Text, TEXTBOX_Marca.Text, TEXTBOX_Modelo.Text, TEXTBOX_Placas.Text, TEXTBOX_NoMotor.Text, TEXTBOX_NoSerie.Text, TEXTBOX_Color.Text, TEXTBOX_NombreChofer.Text, TEXTBOX_CoberturaTrayecto.Text, TEXTBOX_CoberturaRiesgo.Text, TEXTBOX_CoberturaContenedores.Text, TEXTBOX_OrigenEmbarque.Text, TEXTBOX_PaisCobertura.Text, TEXTBOX_EstadoCobertura.Text, TEXTBOX_MunCobertura.Text, TEXTBOX_PaisDestino.Text, TEXTBOX_EstadoDestino.Text, TEXTBOX_MunCobertura.Text, TEXTBOX_DescripcionMercancia.Text, TEXTBOX_TipoEmpaque.Text, TEXTBOX_ValorEmbarque.Text, TEXTBOX_PrimaTotal.Text, TEXTBOX_Moneda.Text, TEXTBOX_NoRemolques.Text, TEXTBOX_CertificadoAmparo.Text, TEXTBOX_Contenedor1Descripcion.Text, TEXTBOX_Contenedor2Descripcion.Text, TEXTBOX_Observaciones.Text, TEXTBOX_CondicionesGenerales.Text, TEXTBOX_TelBienSeguro.Text, TEXTBOX_TelBienSeguro.Text, TEXTBOX_TelBienSeguro.Text, TEXTBOX_TelSiniestro.Text, TEXTBOX_MailSiniestro.Text, new byte[0], new byte[0], new byte[0]);
        }

        private void BUTTON_PDFCertificateById_Click(object sender, EventArgs e)
        {
			InsuranceBE.PdfCertificates PDF = new InsuranceBE.PdfCertificates();
			DataTable Dt = PDF.QueryPdfCertificate(TEXTBOX_ConnectionString.Text, Int32.Parse(TEXTBOX_CertificateId.Text));
			DATAGRIDVIEW_PDFCertificate.DataSource = Dt;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			InsuranceBE.PdfCertificates PDF = new InsuranceBE.PdfCertificates();
			PDF.InsertViewPdfCertificate(Int32.Parse(TEXTBOX_UserId.Text),Int32.Parse(TEXTBOX_AppId.Text),TEXTBOX_ConnectionString.Text,Int32.Parse(TEXTBOX_CertificateId.Text));
		}
	}
    
}
