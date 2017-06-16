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
    }
}
