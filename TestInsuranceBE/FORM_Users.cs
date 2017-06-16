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
    public partial class FORM_Users : Form
    {
        public FORM_Users()
        {
            InitializeComponent();
        }

        private void FORM_Users_Load(object sender, EventArgs e)
        {

        }

        private void BUTTON_AddNewUser_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.AddNewUser(int.Parse(TEXTBOX_UserId.Text),int.Parse(TEXTBOX_AppIdUsers.Text),TEXTBOX_ConnectionString.Text,TEXTBOX_NewUserName.Text,TEXTBOX_NewPassword.Text,TEXTBOX_RolName.Text,TEXTBOX_AppName.Text);
       
        }

        private void BUTTON_InsertApp_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.InsertApp(int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppIdUsers.Text), TEXTBOX_ConnectionString.Text,TEXTBOX_AppName.Text,TEXTBOX_Description.Text);
        }

        private void BUTTON_InsertRol_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.InsertRol(int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppIdUsers.Text), TEXTBOX_ConnectionString.Text, TEXTBOX_RolName.Text, TEXTBOX_Description.Text);

        }

        private void BUTTON_InsertUser_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
         int varResult=Usuario.InsertUser(int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppIdUsers.Text), TEXTBOX_ConnectionString.Text, TEXTBOX_UserName.Text, TEXTBOX_Password.Text);
        }

        private void BUTTON_InsertUserRolApp_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
           
            Usuario.InsertUserRolApp(int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppIdUsers.Text), TEXTBOX_ConnectionString.Text,int.Parse(TEXTBOX_InsertUserId.Text),int.Parse(TEXTBOX_InsertRolId.Text),int.Parse(TEXTBOX_InsertAppId.Text));
        }

        private void BUTTON_QueryApp_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
           DataTable Dt= Usuario.QueryApp(TEXTBOX_ConnectionString.Text);
            DATAGRIDVIEW_Users.DataSource = Dt;
        }

        private void BUTTON_QueryAppNameById_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
          Usuario.QueryAppNameById(TEXTBOX_ConnectionString.Text,int.Parse(TEXTBOX_AppIdUsers.Text));
        }

        private void BUTTON_QueryRol_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
           DataTable Dt= Usuario.QueryRol(TEXTBOX_ConnectionString.Text);
            DATAGRIDVIEW_Users.DataSource = Dt;
        }

        private void BUTTON_QueryRolApp_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            DataTable Dt = Usuario.QueryRolApp(TEXTBOX_ConnectionString.Text,int.Parse(TEXTBOX_UserId.Text));
            DATAGRIDVIEW_Users.DataSource = Dt;
        }

        private void BUTTON_QueryRolByUserIdAppId_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.QueryRolByUserIdAppId(TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_UserId.Text),int.Parse(TEXTBOX_AppIdUsers.Text));
        }

        private void BUTTON_QueryRolNameById_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.QueryRolNameById(TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_RolId.Text));
        }

        private void BUTTON_QueryUser_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            DataTable Dt = Usuario.QueryUser(TEXTBOX_ConnectionString.Text);
            DATAGRIDVIEW_Users.DataSource = Dt;
        }

        private void BUTTON_QueryUserRolApp_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            DataTable Dt = Usuario.QueryUserRolApp(TEXTBOX_ConnectionString.Text);
            DATAGRIDVIEW_Users.DataSource = Dt;
        }

        private void BUTTON_UpdateApp_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.UpdateApp(int.Parse(TEXTBOX_UpdateAppId.Text),int.Parse(TEXTBOX_EnableSystem.Text),int.Parse(TEXTBOX_UserId.Text),int.Parse(TEXTBOX_AppIdUsers.Text),TEXTBOX_ConnectionString.Text,TEXTBOX_AppName.Text,TEXTBOX_Description.Text);
        }

        private void BUTTON_UpdateRol_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.UpdateRol(int.Parse(TEXTBOX_UpdateRolId.Text), int.Parse(TEXTBOX_EnableSystem.Text), int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppIdUsers.Text), TEXTBOX_ConnectionString.Text, TEXTBOX_RolName.Text, TEXTBOX_Description.Text);

        }

        private void BUTTON_UpdateUser_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.UpdateUser(int.Parse(TEXTBOX_UpdateUserId.Text), int.Parse(TEXTBOX_EnableSystem.Text), int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppIdUsers.Text), TEXTBOX_ConnectionString.Text, TEXTBOX_UserName.Text, TEXTBOX_Password.Text);
        }

        private void BUTTON_UpdateUserRolApp_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.UpdateUserRolApp(int.Parse(TEXTBOX_RolId.Text),int.Parse(TEXTBOX_EnableSystem.Text), int.Parse(TEXTBOX_UserId.Text), int.Parse(TEXTBOX_AppIdUsers.Text),TEXTBOX_ConnectionString.Text, int.Parse(TEXTBOX_UpdateUserId.Text),int.Parse(TEXTBOX_UpdateRolId.Text), int.Parse(TEXTBOX_UpdateAppId.Text));
        }

        private void BUTTON_ValidateApp_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.ValidateAppExist(TEXTBOX_ConnectionString.Text,TEXTBOX_AppName.Text);
        }

        private void BUTTON_ValidateRol_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.ValidateRolExist(TEXTBOX_ConnectionString.Text, TEXTBOX_RolName.Text);
        }

        private void BUTTON_ValidateUser_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.ValidateRolExist(TEXTBOX_ConnectionString.Text, TEXTBOX_UserName.Text);
        }

        private void BUTTON_ValidateUserPassword_Click(object sender, EventArgs e)
        {
            InsuranceBE.Users Usuario = new InsuranceBE.Users();
            Usuario.ValidateUserPassword(TEXTBOX_ConnectionString.Text,TEXTBOX_UserName.Text,TEXTBOX_Password.Text);
        }
    }
}
