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
    public partial class FORM_Clients : Form
    {
        public FORM_Clients()
        {
            InitializeComponent();
        }

        private void BUTTON_InsertClient_Click(object sender, EventArgs e)
        {
            InsuranceBE.Clients Cliente = new InsuranceBE.Clients();
            Cliente.InsertClient(int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppId.Text), TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_AssociateId.Text), TEXTBOX_FullName.Text, TEXTBOX_Name.Text, TEXTBOX_OtherName.Text, TEXTBOX_FirstLastName.Text, TEXTBOX_SecondLastName.Text, TEXTBOX_RFC.Text, TEXTBOX_Address.Text, TEXTBOX_PostalCode.Text, TEXTBOX_Country.Text, TEXTBOX_State.Text, TEXTBOX_Colony.Text, TEXTBOX_NumOut.Text, TEXTBOX_NumIn.Text, TEXTBOX_Email.Text, TEXTBOX_SecondEmail.Text, TEXTBOX_PhoneOffice.Text, TEXTBOX_Extend.Text, TEXTBOX_WebSite.Text, TEXTBOX_Rot.Text, TEXTBOX_RotRobo.Text, TEXTBOX_TodoRiezgo.Text, TEXTBOX_Porcentaje.Text, TEXTBOX_Street.Text);
        }

 
        private void BUTTON_QueryClient_Click(object sender, EventArgs e)
        {
            InsuranceBE.Clients Cliente = new InsuranceBE.Clients();
           DataTable Dt=  Cliente.QueryClient(TEXTBOX_ConnectionString.Text);
            DATAGRIDVIEW_Clients.DataSource = Dt;
        }

        private void BUTTON_QueryClientInsurer_Click(object sender, EventArgs e)
        {
            InsuranceBE.Clients Cliente = new InsuranceBE.Clients();
            DataTable Dt = Cliente.QueryClientInsurer(TEXTBOX_ConnectionString.Text,int.Parse(TEXTBOX_ClienteId.Text));
            DATAGRIDVIEW_Clients.DataSource = Dt;
        }

        private void BUTTON_UpdateClient_Click(object sender, EventArgs e)
        {
            InsuranceBE.Clients Cliente = new InsuranceBE.Clients();
            Cliente.UpdateClient(int.Parse(TEXTBOX_RowId.Text),int.Parse(TEXTBOX_EnableSystem.Text),int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppId.Text), TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_AssociateId.Text), TEXTBOX_FullName.Text, TEXTBOX_Name.Text, TEXTBOX_OtherName.Text, TEXTBOX_FirstLastName.Text, TEXTBOX_SecondLastName.Text, TEXTBOX_RFC.Text, TEXTBOX_Address.Text, TEXTBOX_PostalCode.Text, TEXTBOX_Country.Text, TEXTBOX_State.Text, TEXTBOX_Colony.Text, TEXTBOX_NumOut.Text, TEXTBOX_NumIn.Text, TEXTBOX_Email.Text, TEXTBOX_SecondEmail.Text, TEXTBOX_PhoneOffice.Text, TEXTBOX_Extend.Text, TEXTBOX_WebSite.Text, TEXTBOX_Rot.Text,TEXTBOX_RotRobo.Text,TEXTBOX_TodoRiezgo.Text,TEXTBOX_Porcentaje.Text,TEXTBOX_Street.Text);
        

    }

        private void FORM_Clients_Load(object sender, EventArgs e)
        {

        }
    }
}
