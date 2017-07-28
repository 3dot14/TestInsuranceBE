using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace TestInsuranceBE
{
    public partial class FORM_CsvInsurer : Form
    {
        public FORM_CsvInsurer()
        {
            InitializeComponent();
        }

        private void BOTON_CargarCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog oD = new OpenFileDialog();
            oD.DefaultExt = "*.csv";
            oD.ShowDialog();
            TEXTBOX_RutaCSV.Text = oD.FileName;
            DATAGRID_CSV.DataSource = ConvertCSVtoDt(TEXTBOX_RutaCSV.Text);
        }

        private void BOTON_Agregar_Click(object sender, EventArgs e)
        {

        }

        public DataTable ConvertCSVtoDt(string rutaCSV)
        {

            DataTable dt = new DataTable("Csv");
            using (OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OlEDB.4.0; Data Source=\"" +
                Path.GetDirectoryName(rutaCSV) + "\";Extended Properties='text;HDR=yes; FMT=dELIMITED(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("Select * from [{0}] ", new FileInfo(rutaCSV).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void BOTON_VerCSVText_Click(object sender, EventArgs e)
        {
            FORM_ViewCSVText frm = new FORM_ViewCSVText();
            frm.ShowDialog();
        }
    }
}
