﻿namespace TestInsuranceBE
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
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRID_Query)).BeginInit();
            this.SuspendLayout();
            // 
            // DATAGRID_Query
            // 
            this.DATAGRID_Query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRID_Query.Location = new System.Drawing.Point(9, 170);
            this.DATAGRID_Query.Name = "DATAGRID_Query";
            this.DATAGRID_Query.Size = new System.Drawing.Size(797, 184);
            this.DATAGRID_Query.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "InsurerId";
            // 
            // TEXTBOX_InsurerId
            // 
            this.TEXTBOX_InsurerId.Location = new System.Drawing.Point(100, 35);
            this.TEXTBOX_InsurerId.Name = "TEXTBOX_InsurerId";
            this.TEXTBOX_InsurerId.Size = new System.Drawing.Size(76, 20);
            this.TEXTBOX_InsurerId.TabIndex = 13;
            this.TEXTBOX_InsurerId.Text = "1";
            // 
            // BOTON_QueryViewInsurer
            // 
            this.BOTON_QueryViewInsurer.Location = new System.Drawing.Point(193, 137);
            this.BOTON_QueryViewInsurer.Name = "BOTON_QueryViewInsurer";
            this.BOTON_QueryViewInsurer.Size = new System.Drawing.Size(101, 23);
            this.BOTON_QueryViewInsurer.TabIndex = 12;
            this.BOTON_QueryViewInsurer.Text = "QueryViewInsurer";
            this.BOTON_QueryViewInsurer.UseVisualStyleBackColor = true;
            this.BOTON_QueryViewInsurer.Click += new System.EventHandler(this.BOTON_QueryViewInsurer_Click);
            // 
            // BOTON_QueryCsvInsurer
            // 
            this.BOTON_QueryCsvInsurer.Location = new System.Drawing.Point(100, 137);
            this.BOTON_QueryCsvInsurer.Name = "BOTON_QueryCsvInsurer";
            this.BOTON_QueryCsvInsurer.Size = new System.Drawing.Size(94, 23);
            this.BOTON_QueryCsvInsurer.TabIndex = 11;
            this.BOTON_QueryCsvInsurer.Text = "QueryCsvInsurer";
            this.BOTON_QueryCsvInsurer.UseVisualStyleBackColor = true;
            this.BOTON_QueryCsvInsurer.Click += new System.EventHandler(this.BOTON_QueryCsvInsurer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ConnectionString";
            // 
            // TEXTBOX_ConnectionString
            // 
            this.TEXTBOX_ConnectionString.Location = new System.Drawing.Point(100, 9);
            this.TEXTBOX_ConnectionString.Name = "TEXTBOX_ConnectionString";
            this.TEXTBOX_ConnectionString.Size = new System.Drawing.Size(706, 20);
            this.TEXTBOX_ConnectionString.TabIndex = 9;
            this.TEXTBOX_ConnectionString.Text = "data source=.\\SQLEXPRESS; Initial Catalog = INSURERS_DB; Integrated Security = Tr" +
    "ue;";
            // 
            // BOTON_QueryInsurer
            // 
            this.BOTON_QueryInsurer.Location = new System.Drawing.Point(9, 137);
            this.BOTON_QueryInsurer.Name = "BOTON_QueryInsurer";
            this.BOTON_QueryInsurer.Size = new System.Drawing.Size(94, 23);
            this.BOTON_QueryInsurer.TabIndex = 8;
            this.BOTON_QueryInsurer.Text = "QueryInsurer";
            this.BOTON_QueryInsurer.UseVisualStyleBackColor = true;
            this.BOTON_QueryInsurer.Click += new System.EventHandler(this.BOTON_QueryInsurer_Click);
            // 
            // TEXTBOX_appId
            // 
            this.TEXTBOX_appId.Location = new System.Drawing.Point(100, 57);
            this.TEXTBOX_appId.Name = "TEXTBOX_appId";
            this.TEXTBOX_appId.Size = new System.Drawing.Size(76, 20);
            this.TEXTBOX_appId.TabIndex = 18;
            this.TEXTBOX_appId.Text = "78";
            // 
            // TEXTBOX_userId
            // 
            this.TEXTBOX_userId.Location = new System.Drawing.Point(100, 83);
            this.TEXTBOX_userId.Name = "TEXTBOX_userId";
            this.TEXTBOX_userId.Size = new System.Drawing.Size(76, 20);
            this.TEXTBOX_userId.TabIndex = 19;
            // 
            // TEXTBOX_Csv
            // 
            this.TEXTBOX_Csv.Location = new System.Drawing.Point(100, 111);
            this.TEXTBOX_Csv.Name = "TEXTBOX_Csv";
            this.TEXTBOX_Csv.Size = new System.Drawing.Size(76, 20);
            this.TEXTBOX_Csv.TabIndex = 20;
            // 
            // TEXTBOX_Logo
            // 
            this.TEXTBOX_Logo.Location = new System.Drawing.Point(234, 35);
            this.TEXTBOX_Logo.Name = "TEXTBOX_Logo";
            this.TEXTBOX_Logo.Size = new System.Drawing.Size(60, 20);
            this.TEXTBOX_Logo.TabIndex = 21;
            // 
            // BUTTON_InsertCsvInsurer
            // 
            this.BUTTON_InsertCsvInsurer.Location = new System.Drawing.Point(304, 137);
            this.BUTTON_InsertCsvInsurer.Name = "BUTTON_InsertCsvInsurer";
            this.BUTTON_InsertCsvInsurer.Size = new System.Drawing.Size(85, 23);
            this.BUTTON_InsertCsvInsurer.TabIndex = 22;
            this.BUTTON_InsertCsvInsurer.Text = "InsertCsvInsurer";
            this.BUTTON_InsertCsvInsurer.UseVisualStyleBackColor = true;
            this.BUTTON_InsertCsvInsurer.Click += new System.EventHandler(this.BUTTON_InsertCsvInsurer_Click);
            // 
            // TEXTBOX_Code
            // 
            this.TEXTBOX_Code.Location = new System.Drawing.Point(234, 61);
            this.TEXTBOX_Code.Name = "TEXTBOX_Code";
            this.TEXTBOX_Code.Size = new System.Drawing.Size(60, 20);
            this.TEXTBOX_Code.TabIndex = 23;
            // 
            // TEXTBOX_Name
            // 
            this.TEXTBOX_Name.Location = new System.Drawing.Point(234, 86);
            this.TEXTBOX_Name.Name = "TEXTBOX_Name";
            this.TEXTBOX_Name.Size = new System.Drawing.Size(60, 20);
            this.TEXTBOX_Name.TabIndex = 24;
            // 
            // TEXTBOX_Phone
            // 
            this.TEXTBOX_Phone.Location = new System.Drawing.Point(234, 111);
            this.TEXTBOX_Phone.Name = "TEXTBOX_Phone";
            this.TEXTBOX_Phone.Size = new System.Drawing.Size(60, 20);
            this.TEXTBOX_Phone.TabIndex = 26;
            // 
            // TEXTBOX_Mail
            // 
            this.TEXTBOX_Mail.Location = new System.Drawing.Point(389, 38);
            this.TEXTBOX_Mail.Name = "TEXTBOX_Mail";
            this.TEXTBOX_Mail.Size = new System.Drawing.Size(100, 20);
            this.TEXTBOX_Mail.TabIndex = 27;
            // 
            // BUTTON_InsertInsurer
            // 
            this.BUTTON_InsertInsurer.Location = new System.Drawing.Point(389, 137);
            this.BUTTON_InsertInsurer.Name = "BUTTON_InsertInsurer";
            this.BUTTON_InsertInsurer.Size = new System.Drawing.Size(85, 23);
            this.BUTTON_InsertInsurer.TabIndex = 28;
            this.BUTTON_InsertInsurer.Text = "Insert Insurer";
            this.BUTTON_InsertInsurer.UseVisualStyleBackColor = true;
            this.BUTTON_InsertInsurer.Click += new System.EventHandler(this.BUTTON_InsertInsurer_Click);
            // 
            // BUTTON_InsertViewInsurer
            // 
            this.BUTTON_InsertViewInsurer.Location = new System.Drawing.Point(475, 137);
            this.BUTTON_InsertViewInsurer.Name = "BUTTON_InsertViewInsurer";
            this.BUTTON_InsertViewInsurer.Size = new System.Drawing.Size(85, 23);
            this.BUTTON_InsertViewInsurer.TabIndex = 29;
            this.BUTTON_InsertViewInsurer.Text = "Insert View";
            this.BUTTON_InsertViewInsurer.UseVisualStyleBackColor = true;
            this.BUTTON_InsertViewInsurer.Click += new System.EventHandler(this.BUTTON_InsertViewInsurer_Click);
            // 
            // TEXTBOX_EnableSystem
            // 
            this.TEXTBOX_EnableSystem.Location = new System.Drawing.Point(389, 61);
            this.TEXTBOX_EnableSystem.Name = "TEXTBOX_EnableSystem";
            this.TEXTBOX_EnableSystem.Size = new System.Drawing.Size(100, 20);
            this.TEXTBOX_EnableSystem.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "AppId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "UserId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "CSV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Logo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "EnableSystem";
            // 
            // BUTTON_UpdateInsurer
            // 
            this.BUTTON_UpdateInsurer.Location = new System.Drawing.Point(571, 137);
            this.BUTTON_UpdateInsurer.Name = "BUTTON_UpdateInsurer";
            this.BUTTON_UpdateInsurer.Size = new System.Drawing.Size(87, 23);
            this.BUTTON_UpdateInsurer.TabIndex = 40;
            this.BUTTON_UpdateInsurer.Text = "Update Insurer";
            this.BUTTON_UpdateInsurer.UseVisualStyleBackColor = true;
            this.BUTTON_UpdateInsurer.Click += new System.EventHandler(this.BUTTON_UpdateInsurer_Click);
            // 
            // BUTTON_UpdateViewInsurer
            // 
            this.BUTTON_UpdateViewInsurer.Location = new System.Drawing.Point(657, 137);
            this.BUTTON_UpdateViewInsurer.Name = "BUTTON_UpdateViewInsurer";
            this.BUTTON_UpdateViewInsurer.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_UpdateViewInsurer.TabIndex = 41;
            this.BUTTON_UpdateViewInsurer.Text = "UpdateViewInsurer";
            this.BUTTON_UpdateViewInsurer.UseVisualStyleBackColor = true;
            this.BUTTON_UpdateViewInsurer.Click += new System.EventHandler(this.BUTTON_UpdateViewInsurer_Click);
            // 
            // BUTTON_UpdateCsvInsurer
            // 
            this.BUTTON_UpdateCsvInsurer.Location = new System.Drawing.Point(731, 137);
            this.BUTTON_UpdateCsvInsurer.Name = "BUTTON_UpdateCsvInsurer";
            this.BUTTON_UpdateCsvInsurer.Size = new System.Drawing.Size(75, 23);
            this.BUTTON_UpdateCsvInsurer.TabIndex = 42;
            this.BUTTON_UpdateCsvInsurer.Text = "Update Csv";
            this.BUTTON_UpdateCsvInsurer.UseVisualStyleBackColor = true;
            this.BUTTON_UpdateCsvInsurer.Click += new System.EventHandler(this.BUTTON_UpdateCsvInsurer_Click);
            // 
            // FORM_Insurers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 366);
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
            this.Name = "FORM_Insurers";
            this.Text = "FORM_Insurers";
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
    }
}