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
    public partial class FORM_ViewCSVText : Form
    {
        public string textCSV = "";

        public FORM_ViewCSVText()
        {
            InitializeComponent();
        }

        private void FORM_ViewCSVText_Load(object sender, EventArgs e)
        {
            TEXTBOX_CSV.Text = textCSV;
        }
    }
}
