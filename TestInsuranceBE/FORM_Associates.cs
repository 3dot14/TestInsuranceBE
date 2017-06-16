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
    public partial class FORM_Associates : Form
    {
        public FORM_Associates()
        {
            InitializeComponent();
        }

        private void BUTTON_InsertAssociates_Click(object sender, EventArgs e)
        {
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            Associate.InsertAssociate(int.Parse(TEXTBOX_UserId.Text),int.Parse(TEXTBOX_AppId.Text),TEXTBOX_ConnectionString.Text, TEXTBOX_FullName.Text,TEXTBOX_FirstName.Text,TEXTBOX_MiddleName.Text,TEXTBOX_OtherName.Text,TEXTBOX_LastName.Text,TEXTBOX_MotherLastName.Text,TEXTBOX_RFC.Text,TEXTBOX_Mail.Text,TEXTBOX_Cel.Text,TEXTBOX_Tel.Text,TEXTBOX_OtherMail.Text,TEXTBOX_Tel.Text,TEXTBOX_Adress.Text,TEXTBOX_Country.Text, TEXTBOX_CP.Text,TEXTBOX_State.Text,TEXTBOX_City.Text,TEXTBOX_Colony.Text,TEXTBOX_Street.Text,TEXTBOX_OutNum.Text,TEXTBOX_IntNum.Text,TEXTBOX_Company.Text,TEXTBOX_Responsable.Text,TEXTBOX_TelCompany.Text,TEXTBOX_LadaCompany.Text, TEXTBOX_LadaCompany.Text,TEXTBOX_WebPage.Text,TEXTBOX_Turn.Text,TEXTBOX_Comission.Text,TEXTBOX_Rot.Text,TEXTBOX_RotRobo.Text,TEXTBOX_TodoRiesgo.Text,TEXTBOX_Porcentaje.Text, Encoding.ASCII.GetBytes(TEXTBOX_Logo.Text));
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void BUTTON_QueryAssociate_Click(object sender, EventArgs e)
        {
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            DataTable Dt = Associate.QueryAssociate(TEXTBOX_ConnectionString.Text);
            DATAGRID_Associate.DataSource = Dt;
        }

        private void BUTTON_UpdateAssociate_Click(object sender, EventArgs e)
        {
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            Associate.UpdateAssociate(int.Parse(TEXTBOX_RowIdAssociate.Text), int.Parse(TEXTBOX_EnableSystem.Text), int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppId.Text), TEXTBOX_ConnectionString.Text,TEXTBOX_FullName.Text, TEXTBOX_FirstName.Text,TEXTBOX_MiddleName.Text,TEXTBOX_OtherName.Text,TEXTBOX_LastName.Text,TEXTBOX_MotherLastName.Text,TEXTBOX_RFC.Text,TEXTBOX_Mail.Text, TEXTBOX_Cel.Text, TEXTBOX_Tel.Text, TEXTBOX_OtherMail.Text, TEXTBOX_Tel.Text,TEXTBOX_Adress.Text,TEXTBOX_Country.Text,TEXTBOX_CP.Text,TEXTBOX_State.Text, TEXTBOX_City.Text,TEXTBOX_Colony.Text,TEXTBOX_Street.Text,TEXTBOX_OutNum.Text, TEXTBOX_IntNum.Text,TEXTBOX_Company.Text,TEXTBOX_Responsable.Text,TEXTBOX_TelCompany.Text,TEXTBOX_LadaCompany.Text,TEXTBOX_LadaCompany.Text,TEXTBOX_WebPage.Text,TEXTBOX_Turn.Text, TEXTBOX_Comission.Text, TEXTBOX_Rot.Text, TEXTBOX_RotRobo.Text, TEXTBOX_TodoRiesgo.Text,TEXTBOX_Porcentaje.Text,new byte[0]);
        }

        private void BUTTON_InsertAssociateInsurer_Click(object sender, EventArgs e)
        {
            int[] IdInsurer = new int[1]; 
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            Associate.InsertAssociateInsurer(int.Parse(TEXTBOX_UserId.Text),int.Parse(TEXTBOX_AppId.Text),TEXTBOX_ConnectionString.Text,int.Parse(TEXTBOX_AssociateId.Text),IdInsurer);

        }

        private void BUTTON_QueryAssociateInsurer_Click(object sender, EventArgs e)
        {
        
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            DataTable Dt;
            Dt= Associate.QueryAssociateInsurer(TEXTBOX_ConnectionString.Text,int.Parse(TEXTBOX_AssociateId.Text));
            DATAGRID_Associate.DataSource = Dt;
        }

        private void BUTTON_UpdateAssociateInsurer_Click(object sender, EventArgs e)
        {
            int[] IdInsurer = new int[1];
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            Associate.UpdateAssociateInsurer(int.Parse(TEXTBOX_UserId.Text),int.Parse(TEXTBOX_AppId.Text),TEXTBOX_ConnectionString.Text,int.Parse(TEXTBOX_AssociateId.Text),IdInsurer);
        }

        private void BUTTON_InsertViewAssociate_Click(object sender, EventArgs e)
        {
            int[] IdInsurer = new int[1];
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            Associate.InsertViewAssociate(int.Parse(TEXTBOX_UserId.Text),int.Parse(TEXTBOX_AppId.Text),TEXTBOX_ConnectionString.Text,TEXTBOX_FullName.Text,TEXTBOX_FirstName.Text,TEXTBOX_MiddleName.Text,TEXTBOX_OtherName.Text,TEXTBOX_LastName.Text,TEXTBOX_MotherLastName.Text,TEXTBOX_RFC.Text,TEXTBOX_Mail.Text,TEXTBOX_Cel.Text,TEXTBOX_Tel.Text,TEXTBOX_OtherMail.Text,TEXTBOX_Tel.Text,TEXTBOX_Adress.Text, TEXTBOX_Country.Text,TEXTBOX_CP.Text,TEXTBOX_State.Text,TEXTBOX_City.Text,TEXTBOX_Colony.Text,TEXTBOX_Street.Text,TEXTBOX_OutNum.Text,TEXTBOX_IntNum.Text,TEXTBOX_Company.Text,TEXTBOX_Responsable.Text,TEXTBOX_TelCompany.Text,TEXTBOX_LadaCompany.Text,TEXTBOX_Tel.Text,TEXTBOX_WebPage.Text,TEXTBOX_Turn.Text,TEXTBOX_Comission.Text,TEXTBOX_Rot.Text,TEXTBOX_RotRobo.Text, TEXTBOX_TodoRiesgo.Text,TEXTBOX_Porcentaje.Text,new byte[0],IdInsurer);
        }

        private void BUTTON_QueryViewAssociate_Click(object sender, EventArgs e)
        {
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            DataSet Ds= Associate.QueryViewAssociateInsurer(TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_AssociateId.Text));
            DATAGRID_Associate.DataSource = Ds;
        }

        private void BUTTON_UpdateView_Click(object sender, EventArgs e)
        {
            int[] IdInsurer = new int[1];
            InsuranceBE.Associates Associate = new InsuranceBE.Associates();
            Associate.UpdateViewAssociate(int.Parse(TEXTBOX_RowIdAssociate.Text),int.Parse(TEXTBOX_EnableSystem.Text),int.Parse(TEXTBOX_UserId.Text),int.Parse(TEXTBOX_AppId.Text),TEXTBOX_ConnectionString.Text,TEXTBOX_FullName.Text, TEXTBOX_FirstName.Text,TEXTBOX_MiddleName.Text, TEXTBOX_OtherName.Text,TEXTBOX_LastName.Text,TEXTBOX_MotherLastName.Text,TEXTBOX_RFC.Text,TEXTBOX_Mail.Text,TEXTBOX_Cel.Text,TEXTBOX_Cel.Text,TEXTBOX_OtherMail.Text,TEXTBOX_Tel.Text,TEXTBOX_Adress.Text,TEXTBOX_Country.Text,TEXTBOX_CP.Text,TEXTBOX_State.Text,TEXTBOX_City.Text,TEXTBOX_Colony.Text,TEXTBOX_Street.Text,TEXTBOX_OutNum.Text,TEXTBOX_IntNum.Text,TEXTBOX_Company.Text,TEXTBOX_Responsable.Text,TEXTBOX_TelCompany.Text,TEXTBOX_LadaCompany.Text,TEXTBOX_LadaCompany.Text,TEXTBOX_WebPage.Text,TEXTBOX_Turn.Text,TEXTBOX_Comission.Text,TEXTBOX_Rot.Text,TEXTBOX_RotRobo.Text,TEXTBOX_TodoRiesgo.Text,TEXTBOX_Porcentaje.Text,new byte[0],IdInsurer);
           
        }
    }
}
