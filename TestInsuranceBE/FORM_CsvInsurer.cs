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
        }
    }
}
