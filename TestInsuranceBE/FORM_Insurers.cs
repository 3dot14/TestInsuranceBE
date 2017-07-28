using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsuranceBE;


namespace TestInsuranceBE
{
    public partial class FORM_Insurers : Form
    {
        public FORM_Insurers()
        {
            InitializeComponent();
        }

        public void BOTON_QueryInsurer_Click(object sender, EventArgs e)
        {
            InsuranceBE.Insurers insure = new InsuranceBE.Insurers();
            DataTable Dt = insure.QueryInsurer(TEXTBOX_ConnectionString.Text);
            DATAGRID_Query.DataSource = Dt;
        }

        private void BOTON_QueryCsvInsurer_Click(object sender, EventArgs e)
        {
            InsuranceBE.Insurers insurer = new InsuranceBE.Insurers();
            DataTable Dt = insurer.QueryCsvInsurer(TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_InsurerId.Text));
            DATAGRID_Query.DataSource = Dt;
        }

        private void BOTON_QueryViewInsurer_Click(object sender, EventArgs e)
        {
            InsuranceBE.Insurers insurer = new InsuranceBE.Insurers();
            DataSet Ds = insurer.QueryViewInsurer(TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_InsurerId.Text));
            DATAGRID_Query.DataSource = Ds;
        }

        private void BUTTON_InsertCsvInsurer_Click(object sender, EventArgs e)
        {


            InsuranceBE.Insurers insurer = new InsuranceBE.Insurers();
            insurer.InsertCsvInsurer( (int.Parse(TEXTBOX_userId.Text)),(int.Parse(TEXTBOX_appId.Text)), TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_InsurerId.Text), TEXTBOX_Description.Text,TEXTBOX_Cond.Text,TEXTBOX_MaxMount.Text,TEXTBOX_GpoGiro.Text,TEXTBOX_Giro.Text, TEXTBOX_SA_Max.Text,TEXTBOX_Mensaje.Text );
        }

        private void BUTTON_InsertInsurer_Click(object sender, EventArgs e)
        {
            InsuranceBE.Insurers insurer = new InsuranceBE.Insurers();
            insurer.InsertInsurer((int.Parse(TEXTBOX_userId.Text)), (int.Parse(TEXTBOX_appId.Text)), TEXTBOX_ConnectionString.Text, TEXTBOX_Code.Text, TEXTBOX_Name.Text, TEXTBOX_Phone.Text, TEXTBOX_Mail.Text, Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text), Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text));
        }

        private void BUTTON_InsertViewInsurer_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            System.Type typeInt32 =
        System.Type.GetType("System.Int32");



            Dt.Columns.Add("DESCRIPCION");
            Dt.Columns.Add("LME");
            Dt.Columns.Add("MAX_MOUNT");
            Dt.Columns.Add("Cond.", typeof(Int32));
            Dt.Columns.Add("[S.A. Maxima]");
            Dt.Columns.Add("Gpo de Giro", typeInt32);
            Dt.Columns.Add("Giro");
            Dt.Columns.Add("MENSAJE");

            DataRow row = Dt.NewRow();

            row["DESCRIPCION"] = "viewCil";
            row["LME"] = "tres";
            row["MAX_MOUNT"] = "CUATRO";
            row["Cond."] = 50;
            row["[S.A. Maxima]"] = "text";
            row["Gpo de Giro"] = 2;
            row["Giro"] = "Solutions";
            row["Mensaje"] = "Ninguno";
            Dt.Rows.Add(row);

            row = Dt.NewRow();

            row["DESCRIPCION"] = "viewCilantro";
            row["LME"] = "cuatro";
            row["MAX_MOUNT"] = "CINCO";
            row["Cond."] = 20;
            row["[S.A. Maxima]"] = "text";
            row["Gpo de Giro"] = 5;
            row["Giro"] = "Sol";
            row["Mensaje"] = "Alguno";
            Dt.Rows.Add(row);

            InsuranceBE.Insurers insurer = new InsuranceBE.Insurers();
            insurer.InsertViewInsurer((int.Parse(TEXTBOX_userId.Text)), (int.Parse(TEXTBOX_appId.Text)), TEXTBOX_ConnectionString.Text, TEXTBOX_Code.Text, TEXTBOX_Name.Text, TEXTBOX_Phone.Text, TEXTBOX_Mail.Text, Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text), Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text));


        }

        private void BUTTON_UpdateInsurer_Click(object sender, EventArgs e)
        {
        
            InsuranceBE.Insurers insurer = new InsuranceBE.Insurers();
            insurer.UpdateInsurer(int.Parse(TEXTBOX_InsurerId.Text),int.Parse(TEXTBOX_EnableSystem.Text),(int.Parse(TEXTBOX_userId.Text)), (int.Parse(TEXTBOX_appId.Text)), TEXTBOX_ConnectionString.Text, TEXTBOX_Code.Text, TEXTBOX_Name.Text, TEXTBOX_Phone.Text, TEXTBOX_Mail.Text, Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text), Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text));

        }

        private void BUTTON_UpdateViewInsurer_Click(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            InsuranceBE.Insurers insurer = new InsuranceBE.Insurers();
            insurer.UpdateViewInsurer(int.Parse(TEXTBOX_InsurerId.Text), int.Parse(TEXTBOX_EnableSystem.Text), (int.Parse(TEXTBOX_userId.Text)), (int.Parse(TEXTBOX_appId.Text)), TEXTBOX_ConnectionString.Text, TEXTBOX_Code.Text, TEXTBOX_Name.Text, TEXTBOX_Phone.Text, TEXTBOX_Mail.Text, Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text), Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text),Dt);

        }

        private void BUTTON_UpdateCsvInsurer_Click(object sender, EventArgs e)
        {
           
            InsuranceBE.Insurers insurer = new InsuranceBE.Insurers();

            DataTable Dt = new DataTable();
            System.Type typeInt32 =
        System.Type.GetType("System.Int32");



            Dt.Columns.Add("DESCRIPCION");
            Dt.Columns.Add("LME");
            Dt.Columns.Add("MAX_MOUNT");
            Dt.Columns.Add("Cond.", typeof(Int32));
            Dt.Columns.Add("[S.A. Maxima]");
            Dt.Columns.Add("Gpo de Giro", typeInt32);
            Dt.Columns.Add("Giro");
            Dt.Columns.Add("MENSAJE");

            DataRow row = Dt.NewRow();

            row["DESCRIPCION"] = "updatedPruebaCil";
            row["LME"] = "tres";
            row["MAX_MOUNT"] = "dos";
            row["Cond."] = 50;
            row["[S.A. Maxima]"] = "text";
            row["Gpo de Giro"] = 2;
            row["Giro"] = "Solutions";
            row["Mensaje"] = "Ninguno";
            Dt.Rows.Add(row);

            row = Dt.NewRow();

            row["DESCRIPCION"] = "updatedCilantro";
            row["LME"] = "cuatro";
            row["MAX_MOUNT"] = "dos";
            row["Cond."] = 20;
            row["[S.A. Maxima]"] = "text";
            row["Gpo de Giro"] = 5;
            row["Giro"] = "Sol";
            row["Mensaje"] = "Alguno";
            Dt.Rows.Add(row);
            insurer.UpdateCsvInsurer( (int.Parse(TEXTBOX_userId.Text)), (int.Parse(TEXTBOX_appId.Text)), TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_InsurerId.Text), Encoding.ASCII.GetBytes(TEXTBOX_Csv.Text), Dt);


        }

		private void FORM_Insurers_Load(object sender, EventArgs e)
		{

		}
	}
}
