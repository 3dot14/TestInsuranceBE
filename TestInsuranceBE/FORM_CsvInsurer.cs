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
        public string textCSV = "";
        public byte[] textFileCSV;

        public FORM_CsvInsurer()
        {
            InitializeComponent();
        }

        public string OpenFileTxt(String FilePath, Encoding encoding)
        {
            string contenido = System.IO.File.ReadAllText(FilePath, encoding);
            return contenido;
        }

        public byte[] OpenFile(String FilePath)
        {
            byte[] devuelve = System.IO.File.ReadAllBytes(FilePath);

            return devuelve;
        }

        public DataTable ConvertCSVtoDtOLDB(string rutaCSV)
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

        public DataTable ConvertCsvToDt(string strCSV)
        {
            if (string.IsNullOrEmpty(strCSV)) return null;
            DataTable dtCsv = new DataTable("Csv");
            string reservedWordComilla = @"\*comilla*/";
            string reservedWordComillaComa = @"\*QuotationMarks*/";
            string reservedWordComa = @"\*div*/";

            strCSV = strCSV.Replace("\"\"", reservedWordComilla);
            strCSV = ConvertReserverdWordQuotationMarks(strCSV, reservedWordComillaComa);
            //strCSV = strCSV.Replace(",", reservedWordComa);

            string[] div = new string[1];
            div[0] = "\r\n";

            string[] rowsCSV = strCSV.Split(div, StringSplitOptions.RemoveEmptyEntries);

            string[] columns = rowsCSV[0].Split(Convert.ToChar(","));

            for(int i =0; i < columns.Length; i++)
            {
                dtCsv.Columns.Add(columns[i]);
            }
            dtCsv.AcceptChanges();
            DataRow dr;
            string[] cells;
            for (int i = 1; i < rowsCSV.Length; i++)
            {
                dr = dtCsv.NewRow();
                cells = rowsCSV[i].Split(Convert.ToChar(","));
                for(int j = 0; j < cells.Length; j++)
                {
                    dr[j] = cells[j];
                }
                    
                dtCsv.Rows.Add(dr);
            }
            dtCsv.AcceptChanges();

            return dtCsv;
        }

        public string ConvertReserverdWordQuotationMarks(string CSV,string reservedWordComa)
        {
            
            int ini = 0;
            int fin = 0;
            int len = 0;
            for (int i = 0; i < CSV.Length; i++)
            {
                if (CSV.Substring(i, 1) == "\"")
                {
                    ini = i;
                    for(int j=i+1; j < CSV.Length; j++)
                    {
                        if (CSV.Substring(j, 1) == "\"")
                        {
                            fin = j;
                            len = fin - ini + 1;
                            CSV = CSV.Replace(CSV.Substring(i, len), CSV.Substring(i, len).Replace(",",reservedWordComa).Replace("\"",""));
                            break;
                        }

                    }
                }
            }
            return CSV;
        }

        private void BOTON_CargarCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog oD = new OpenFileDialog();
            oD.DefaultExt = "*.csv";
            oD.ShowDialog();
            TEXTBOX_RutaCSV.Text = oD.FileName;
            textCSV= OpenFileTxt(TEXTBOX_RutaCSV.Text, Encoding.UTF8);
            textFileCSV = OpenFile(TEXTBOX_RutaCSV.Text);
            textCSV= System.Text.Encoding.UTF8.GetString(textFileCSV).TrimEnd('\0');
            //DATAGRID_CSV.DataSource = ConvertCSVtoDt(TEXTBOX_RutaCSV.Text);
            DATAGRID_CSV.DataSource = ConvertCsvToDt(textCSV);
        }

        private void BOTON_Agregar_Click(object sender, EventArgs e)
        {

        }

        

        private void BOTON_VerCSVText_Click(object sender, EventArgs e)
        {
            FORM_ViewCSVText frm = new FORM_ViewCSVText();
            frm.textCSV = textCSV;
            frm.ShowDialog();
        }



        

        private void FORM_CsvInsurer_Load(object sender, EventArgs e)
        {

        }
    }
}
