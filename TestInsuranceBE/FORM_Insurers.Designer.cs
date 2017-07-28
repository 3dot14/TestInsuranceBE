namespace TestInsuranceBE
{
    partial class FORM_Insurers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.DATAGRID_Query = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.TEXTBOX_InsurerId = new System.Windows.Forms.TextBox();
			this.BOTON_QueryViewInsurer = new System.Windows.Forms.Button();
			this.BOTON_QueryCsvInsurer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TEXTBOX_ConnectionString = new System.Windows.Forms.TextBox();
			this.BOTON_QueryInsurer = new System.Windows.Forms.Button();
			this.TEXTBOX_appId = new System.Windows.Forms.TextBox();
			this.TEXTBOX_userId = new System.Windows.Forms.TextBox();
			this.TEXTBOX_Csv = new System.Windows.Forms.TextBox();
			this.TEXTBOX_Logo = new System.Windows.Forms.TextBox();
			this.BUTTON_InsertCsvInsurer = new System.Windows.Forms.Button();
			this.TEXTBOX_Code = new System.Windows.Forms.TextBox();
			this.TEXTBOX_Name = new System.Windows.Forms.TextBox();
			this.TEXTBOX_Phone = new System.Windows.Forms.TextBox();
			this.TEXTBOX_Mail = new System.Windows.Forms.TextBox();
			this.BUTTON_InsertInsurer = new System.Windows.Forms.Button();
			this.BUTTON_InsertViewInsurer = new System.Windows.Forms.Button();
			this.TEXTBOX_EnableSystem = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.BUTTON_UpdateInsurer = new System.Windows.Forms.Button();
			this.BUTTON_UpdateViewInsurer = new System.Windows.Forms.Button();
			this.BUTTON_UpdateCsvInsurer = new System.Windows.Forms.Button();
			this.TEXTBOX_Description = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.TEXTBOX_Lme = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.TEXTBOX_MaxMount = new System.Windows.Forms.TextBox();
			this.TEXTBOX_Giro = new System.Windows.Forms.TextBox();
			this.TEXTBOX_GpoGiro = new System.Windows.Forms.TextBox();
			this.TEXTBOX_SA_Max = new System.Windows.Forms.TextBox();
			this.TEXTBOX_Cond = new System.Windows.Forms.TextBox();
			this.TEXTBOX_Mensaje = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DATAGRID_Query)).BeginInit();
			this.SuspendLayout();
			// 
			// DATAGRID_Query
			// 
			this.DATAGRID_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DATAGRID_Query.Location = new System.Drawing.Point(12, 209);
			this.DATAGRID_Query.Margin = new System.Windows.Forms.Padding(4);
			this.DATAGRID_Query.Name = "DATAGRID_Query";
			this.DATAGRID_Query.Size = new System.Drawing.Size(1063, 226);
			this.DATAGRID_Query.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 47);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 14;
			this.label2.Text = "InsurerId";
			// 
			// TEXTBOX_InsurerId
			// 
			this.TEXTBOX_InsurerId.Location = new System.Drawing.Point(133, 43);
			this.TEXTBOX_InsurerId.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_InsurerId.Name = "TEXTBOX_InsurerId";
			this.TEXTBOX_InsurerId.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_InsurerId.TabIndex = 13;
			this.TEXTBOX_InsurerId.Text = "1";
			// 
			// BOTON_QueryViewInsurer
			// 
			this.BOTON_QueryViewInsurer.Location = new System.Drawing.Point(257, 169);
			this.BOTON_QueryViewInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BOTON_QueryViewInsurer.Name = "BOTON_QueryViewInsurer";
			this.BOTON_QueryViewInsurer.Size = new System.Drawing.Size(135, 28);
			this.BOTON_QueryViewInsurer.TabIndex = 12;
			this.BOTON_QueryViewInsurer.Text = "QueryViewInsurer";
			this.BOTON_QueryViewInsurer.UseVisualStyleBackColor = true;
			this.BOTON_QueryViewInsurer.Click += new System.EventHandler(this.BOTON_QueryViewInsurer_Click);
			// 
			// BOTON_QueryCsvInsurer
			// 
			this.BOTON_QueryCsvInsurer.Location = new System.Drawing.Point(133, 169);
			this.BOTON_QueryCsvInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BOTON_QueryCsvInsurer.Name = "BOTON_QueryCsvInsurer";
			this.BOTON_QueryCsvInsurer.Size = new System.Drawing.Size(125, 28);
			this.BOTON_QueryCsvInsurer.TabIndex = 11;
			this.BOTON_QueryCsvInsurer.Text = "QueryCsvInsurer";
			this.BOTON_QueryCsvInsurer.UseVisualStyleBackColor = true;
			this.BOTON_QueryCsvInsurer.Click += new System.EventHandler(this.BOTON_QueryCsvInsurer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "ConnectionString";
			// 
			// TEXTBOX_ConnectionString
			// 
			this.TEXTBOX_ConnectionString.Location = new System.Drawing.Point(133, 11);
			this.TEXTBOX_ConnectionString.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_ConnectionString.Name = "TEXTBOX_ConnectionString";
			this.TEXTBOX_ConnectionString.Size = new System.Drawing.Size(940, 22);
			this.TEXTBOX_ConnectionString.TabIndex = 9;
			this.TEXTBOX_ConnectionString.Text = "data source=.\\SQLEXPRESS; Initial Catalog = INSURERS_DB; Integrated Security = Tr" +
    "ue;";
			// 
			// BOTON_QueryInsurer
			// 
			this.BOTON_QueryInsurer.Location = new System.Drawing.Point(12, 169);
			this.BOTON_QueryInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BOTON_QueryInsurer.Name = "BOTON_QueryInsurer";
			this.BOTON_QueryInsurer.Size = new System.Drawing.Size(125, 28);
			this.BOTON_QueryInsurer.TabIndex = 8;
			this.BOTON_QueryInsurer.Text = "QueryInsurer";
			this.BOTON_QueryInsurer.UseVisualStyleBackColor = true;
			this.BOTON_QueryInsurer.Click += new System.EventHandler(this.BOTON_QueryInsurer_Click);
			// 
			// TEXTBOX_appId
			// 
			this.TEXTBOX_appId.Location = new System.Drawing.Point(133, 70);
			this.TEXTBOX_appId.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_appId.Name = "TEXTBOX_appId";
			this.TEXTBOX_appId.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_appId.TabIndex = 18;
			this.TEXTBOX_appId.Text = "78";
			// 
			// TEXTBOX_userId
			// 
			this.TEXTBOX_userId.Location = new System.Drawing.Point(133, 102);
			this.TEXTBOX_userId.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_userId.Name = "TEXTBOX_userId";
			this.TEXTBOX_userId.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_userId.TabIndex = 19;
			this.TEXTBOX_userId.Text = "1";
			// 
			// TEXTBOX_Csv
			// 
			this.TEXTBOX_Csv.Location = new System.Drawing.Point(133, 137);
			this.TEXTBOX_Csv.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_Csv.Name = "TEXTBOX_Csv";
			this.TEXTBOX_Csv.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_Csv.TabIndex = 20;
			// 
			// TEXTBOX_Logo
			// 
			this.TEXTBOX_Logo.Location = new System.Drawing.Point(312, 43);
			this.TEXTBOX_Logo.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_Logo.Name = "TEXTBOX_Logo";
			this.TEXTBOX_Logo.Size = new System.Drawing.Size(79, 22);
			this.TEXTBOX_Logo.TabIndex = 21;
			// 
			// BUTTON_InsertCsvInsurer
			// 
			this.BUTTON_InsertCsvInsurer.Location = new System.Drawing.Point(405, 169);
			this.BUTTON_InsertCsvInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BUTTON_InsertCsvInsurer.Name = "BUTTON_InsertCsvInsurer";
			this.BUTTON_InsertCsvInsurer.Size = new System.Drawing.Size(113, 28);
			this.BUTTON_InsertCsvInsurer.TabIndex = 22;
			this.BUTTON_InsertCsvInsurer.Text = "InsertCsvInsurer";
			this.BUTTON_InsertCsvInsurer.UseVisualStyleBackColor = true;
			this.BUTTON_InsertCsvInsurer.Click += new System.EventHandler(this.BUTTON_InsertCsvInsurer_Click);
			// 
			// TEXTBOX_Code
			// 
			this.TEXTBOX_Code.Location = new System.Drawing.Point(312, 75);
			this.TEXTBOX_Code.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_Code.Name = "TEXTBOX_Code";
			this.TEXTBOX_Code.Size = new System.Drawing.Size(79, 22);
			this.TEXTBOX_Code.TabIndex = 23;
			// 
			// TEXTBOX_Name
			// 
			this.TEXTBOX_Name.Location = new System.Drawing.Point(312, 106);
			this.TEXTBOX_Name.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_Name.Name = "TEXTBOX_Name";
			this.TEXTBOX_Name.Size = new System.Drawing.Size(79, 22);
			this.TEXTBOX_Name.TabIndex = 24;
			this.TEXTBOX_Name.Text = "111";
			// 
			// TEXTBOX_Phone
			// 
			this.TEXTBOX_Phone.Location = new System.Drawing.Point(312, 137);
			this.TEXTBOX_Phone.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_Phone.Name = "TEXTBOX_Phone";
			this.TEXTBOX_Phone.Size = new System.Drawing.Size(79, 22);
			this.TEXTBOX_Phone.TabIndex = 26;
			this.TEXTBOX_Phone.Text = "11111";
			// 
			// TEXTBOX_Mail
			// 
			this.TEXTBOX_Mail.Location = new System.Drawing.Point(519, 47);
			this.TEXTBOX_Mail.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_Mail.Name = "TEXTBOX_Mail";
			this.TEXTBOX_Mail.Size = new System.Drawing.Size(132, 22);
			this.TEXTBOX_Mail.TabIndex = 27;
			this.TEXTBOX_Mail.Text = "emorales@cil.com";
			// 
			// BUTTON_InsertInsurer
			// 
			this.BUTTON_InsertInsurer.Location = new System.Drawing.Point(519, 169);
			this.BUTTON_InsertInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BUTTON_InsertInsurer.Name = "BUTTON_InsertInsurer";
			this.BUTTON_InsertInsurer.Size = new System.Drawing.Size(113, 28);
			this.BUTTON_InsertInsurer.TabIndex = 28;
			this.BUTTON_InsertInsurer.Text = "Insert Insurer";
			this.BUTTON_InsertInsurer.UseVisualStyleBackColor = true;
			this.BUTTON_InsertInsurer.Click += new System.EventHandler(this.BUTTON_InsertInsurer_Click);
			// 
			// BUTTON_InsertViewInsurer
			// 
			this.BUTTON_InsertViewInsurer.Location = new System.Drawing.Point(633, 169);
			this.BUTTON_InsertViewInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BUTTON_InsertViewInsurer.Name = "BUTTON_InsertViewInsurer";
			this.BUTTON_InsertViewInsurer.Size = new System.Drawing.Size(113, 28);
			this.BUTTON_InsertViewInsurer.TabIndex = 29;
			this.BUTTON_InsertViewInsurer.Text = "Insert View";
			this.BUTTON_InsertViewInsurer.UseVisualStyleBackColor = true;
			this.BUTTON_InsertViewInsurer.Click += new System.EventHandler(this.BUTTON_InsertViewInsurer_Click);
			// 
			// TEXTBOX_EnableSystem
			// 
			this.TEXTBOX_EnableSystem.Location = new System.Drawing.Point(519, 75);
			this.TEXTBOX_EnableSystem.Margin = new System.Windows.Forms.Padding(4);
			this.TEXTBOX_EnableSystem.Name = "TEXTBOX_EnableSystem";
			this.TEXTBOX_EnableSystem.Size = new System.Drawing.Size(132, 22);
			this.TEXTBOX_EnableSystem.TabIndex = 30;
			this.TEXTBOX_EnableSystem.Text = "1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(64, 79);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 31;
			this.label3.Text = "AppId";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(60, 106);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 17);
			this.label4.TabIndex = 32;
			this.label4.Text = "UserId";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(68, 140);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 17);
			this.label5.TabIndex = 33;
			this.label5.Text = "CSV";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(263, 47);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 17);
			this.label6.TabIndex = 34;
			this.label6.Text = "Logo";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(263, 79);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 17);
			this.label7.TabIndex = 35;
			this.label7.Text = "Code";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(263, 110);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 17);
			this.label8.TabIndex = 36;
			this.label8.Text = "Name";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(255, 140);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 17);
			this.label9.TabIndex = 37;
			this.label9.Text = "Phone";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(419, 47);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 17);
			this.label10.TabIndex = 38;
			this.label10.Text = "Mail";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(412, 81);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(98, 17);
			this.label11.TabIndex = 39;
			this.label11.Text = "EnableSystem";
			// 
			// BUTTON_UpdateInsurer
			// 
			this.BUTTON_UpdateInsurer.Location = new System.Drawing.Point(761, 169);
			this.BUTTON_UpdateInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BUTTON_UpdateInsurer.Name = "BUTTON_UpdateInsurer";
			this.BUTTON_UpdateInsurer.Size = new System.Drawing.Size(116, 28);
			this.BUTTON_UpdateInsurer.TabIndex = 40;
			this.BUTTON_UpdateInsurer.Text = "Update Insurer";
			this.BUTTON_UpdateInsurer.UseVisualStyleBackColor = true;
			this.BUTTON_UpdateInsurer.Click += new System.EventHandler(this.BUTTON_UpdateInsurer_Click);
			// 
			// BUTTON_UpdateViewInsurer
			// 
			this.BUTTON_UpdateViewInsurer.Location = new System.Drawing.Point(876, 169);
			this.BUTTON_UpdateViewInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BUTTON_UpdateViewInsurer.Name = "BUTTON_UpdateViewInsurer";
			this.BUTTON_UpdateViewInsurer.Size = new System.Drawing.Size(100, 28);
			this.BUTTON_UpdateViewInsurer.TabIndex = 41;
			this.BUTTON_UpdateViewInsurer.Text = "UpdateViewInsurer";
			this.BUTTON_UpdateViewInsurer.UseVisualStyleBackColor = true;
			this.BUTTON_UpdateViewInsurer.Click += new System.EventHandler(this.BUTTON_UpdateViewInsurer_Click);
			// 
			// BUTTON_UpdateCsvInsurer
			// 
			this.BUTTON_UpdateCsvInsurer.Location = new System.Drawing.Point(975, 169);
			this.BUTTON_UpdateCsvInsurer.Margin = new System.Windows.Forms.Padding(4);
			this.BUTTON_UpdateCsvInsurer.Name = "BUTTON_UpdateCsvInsurer";
			this.BUTTON_UpdateCsvInsurer.Size = new System.Drawing.Size(100, 28);
			this.BUTTON_UpdateCsvInsurer.TabIndex = 42;
			this.BUTTON_UpdateCsvInsurer.Text = "Update Csv";
			this.BUTTON_UpdateCsvInsurer.UseVisualStyleBackColor = true;
			this.BUTTON_UpdateCsvInsurer.Click += new System.EventHandler(this.BUTTON_UpdateCsvInsurer_Click);
			// 
			// TEXTBOX_Description
			// 
			this.TEXTBOX_Description.Location = new System.Drawing.Point(519, 107);
			this.TEXTBOX_Description.Name = "TEXTBOX_Description";
			this.TEXTBOX_Description.Size = new System.Drawing.Size(132, 22);
			this.TEXTBOX_Description.TabIndex = 43;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(427, 111);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(83, 17);
			this.label12.TabIndex = 44;
			this.label12.Text = "Description:";
			// 
			// TEXTBOX_Lme
			// 
			this.TEXTBOX_Lme.Location = new System.Drawing.Point(519, 137);
			this.TEXTBOX_Lme.Name = "TEXTBOX_Lme";
			this.TEXTBOX_Lme.Size = new System.Drawing.Size(132, 22);
			this.TEXTBOX_Lme.TabIndex = 45;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(470, 140);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 17);
			this.label13.TabIndex = 46;
			this.label13.Text = "LME:";
			// 
			// TEXTBOX_MaxMount
			// 
			this.TEXTBOX_MaxMount.Location = new System.Drawing.Point(761, 47);
			this.TEXTBOX_MaxMount.Name = "TEXTBOX_MaxMount";
			this.TEXTBOX_MaxMount.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_MaxMount.TabIndex = 47;
			// 
			// TEXTBOX_Giro
			// 
			this.TEXTBOX_Giro.Location = new System.Drawing.Point(973, 47);
			this.TEXTBOX_Giro.Name = "TEXTBOX_Giro";
			this.TEXTBOX_Giro.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_Giro.TabIndex = 48;
			// 
			// TEXTBOX_GpoGiro
			// 
			this.TEXTBOX_GpoGiro.Location = new System.Drawing.Point(761, 137);
			this.TEXTBOX_GpoGiro.Name = "TEXTBOX_GpoGiro";
			this.TEXTBOX_GpoGiro.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_GpoGiro.TabIndex = 49;
			// 
			// TEXTBOX_SA_Max
			// 
			this.TEXTBOX_SA_Max.Location = new System.Drawing.Point(761, 107);
			this.TEXTBOX_SA_Max.Name = "TEXTBOX_SA_Max";
			this.TEXTBOX_SA_Max.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_SA_Max.TabIndex = 50;
			// 
			// TEXTBOX_Cond
			// 
			this.TEXTBOX_Cond.Location = new System.Drawing.Point(761, 74);
			this.TEXTBOX_Cond.Name = "TEXTBOX_Cond";
			this.TEXTBOX_Cond.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_Cond.TabIndex = 51;
			// 
			// TEXTBOX_Mensaje
			// 
			this.TEXTBOX_Mensaje.Location = new System.Drawing.Point(973, 81);
			this.TEXTBOX_Mensaje.Name = "TEXTBOX_Mensaje";
			this.TEXTBOX_Mensaje.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_Mensaje.TabIndex = 52;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(675, 50);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 17);
			this.label14.TabIndex = 54;
			this.label14.Text = "Max Mount:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(902, 84);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(65, 17);
			this.label15.TabIndex = 55;
			this.label15.Text = "Mensaje:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(665, 140);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(90, 17);
			this.label16.TabIndex = 56;
			this.label16.Text = "Gpo de Giro:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(696, 110);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(59, 17);
			this.label17.TabIndex = 57;
			this.label17.Text = "SA_Max";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(710, 77);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(45, 17);
			this.label18.TabIndex = 58;
			this.label18.Text = "Cond:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(928, 50);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(39, 17);
			this.label19.TabIndex = 59;
			this.label19.Text = "Giro:";
			// 
			// FORM_Insurers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1242, 551);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.TEXTBOX_Mensaje);
			this.Controls.Add(this.TEXTBOX_Cond);
			this.Controls.Add(this.TEXTBOX_SA_Max);
			this.Controls.Add(this.TEXTBOX_GpoGiro);
			this.Controls.Add(this.TEXTBOX_Giro);
			this.Controls.Add(this.TEXTBOX_MaxMount);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.TEXTBOX_Lme);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.TEXTBOX_Description);
			this.Controls.Add(this.BUTTON_UpdateCsvInsurer);
			this.Controls.Add(this.BUTTON_UpdateViewInsurer);
			this.Controls.Add(this.BUTTON_UpdateInsurer);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TEXTBOX_EnableSystem);
			this.Controls.Add(this.BUTTON_InsertViewInsurer);
			this.Controls.Add(this.BUTTON_InsertInsurer);
			this.Controls.Add(this.TEXTBOX_Mail);
			this.Controls.Add(this.TEXTBOX_Phone);
			this.Controls.Add(this.TEXTBOX_Name);
			this.Controls.Add(this.TEXTBOX_Code);
			this.Controls.Add(this.BUTTON_InsertCsvInsurer);
			this.Controls.Add(this.TEXTBOX_Logo);
			this.Controls.Add(this.TEXTBOX_Csv);
			this.Controls.Add(this.TEXTBOX_userId);
			this.Controls.Add(this.TEXTBOX_appId);
			this.Controls.Add(this.DATAGRID_Query);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TEXTBOX_InsurerId);
			this.Controls.Add(this.BOTON_QueryViewInsurer);
			this.Controls.Add(this.BOTON_QueryCsvInsurer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TEXTBOX_ConnectionString);
			this.Controls.Add(this.BOTON_QueryInsurer);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FORM_Insurers";
			this.Text = "FORM_Insurers";
			this.Load += new System.EventHandler(this.FORM_Insurers_Load);
			((System.ComponentModel.ISupportInitialize)(this.DATAGRID_Query)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DATAGRID_Query;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TEXTBOX_InsurerId;
        private System.Windows.Forms.Button BOTON_QueryViewInsurer;
        private System.Windows.Forms.Button BOTON_QueryCsvInsurer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TEXTBOX_ConnectionString;
        private System.Windows.Forms.Button BOTON_QueryInsurer;
        private System.Windows.Forms.TextBox TEXTBOX_appId;
        private System.Windows.Forms.TextBox TEXTBOX_userId;
        private System.Windows.Forms.TextBox TEXTBOX_Csv;
        private System.Windows.Forms.TextBox TEXTBOX_Logo;
        private System.Windows.Forms.Button BUTTON_InsertCsvInsurer;
        private System.Windows.Forms.TextBox TEXTBOX_Code;
        private System.Windows.Forms.TextBox TEXTBOX_Name;
        private System.Windows.Forms.TextBox TEXTBOX_Phone;
        private System.Windows.Forms.TextBox TEXTBOX_Mail;
        private System.Windows.Forms.Button BUTTON_InsertInsurer;
        private System.Windows.Forms.Button BUTTON_InsertViewInsurer;
        private System.Windows.Forms.TextBox TEXTBOX_EnableSystem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BUTTON_UpdateInsurer;
        private System.Windows.Forms.Button BUTTON_UpdateViewInsurer;
        private System.Windows.Forms.Button BUTTON_UpdateCsvInsurer;
		private System.Windows.Forms.TextBox TEXTBOX_Description;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox TEXTBOX_Lme;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox TEXTBOX_MaxMount;
		private System.Windows.Forms.TextBox TEXTBOX_Giro;
		private System.Windows.Forms.TextBox TEXTBOX_GpoGiro;
		private System.Windows.Forms.TextBox TEXTBOX_SA_Max;
		private System.Windows.Forms.TextBox TEXTBOX_Cond;
		private System.Windows.Forms.TextBox TEXTBOX_Mensaje;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
	}
}