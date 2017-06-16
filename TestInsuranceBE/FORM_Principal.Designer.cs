namespace TestInsuranceBE
{
    partial class FORM_Principal
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
            this.BOTON_TestInsurers = new System.Windows.Forms.Button();
            this.BUTTON_TestAsocciate = new System.Windows.Forms.Button();
            this.BUTTON_TestUsers = new System.Windows.Forms.Button();
            this.BUTTON_TestClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BOTON_TestInsurers
            // 
            this.BOTON_TestInsurers.Location = new System.Drawing.Point(33, 19);
            this.BOTON_TestInsurers.Name = "BOTON_TestInsurers";
            this.BOTON_TestInsurers.Size = new System.Drawing.Size(216, 41);
            this.BOTON_TestInsurers.TabIndex = 0;
            this.BOTON_TestInsurers.Text = "Test Insurers";
            this.BOTON_TestInsurers.UseVisualStyleBackColor = true;
            this.BOTON_TestInsurers.Click += new System.EventHandler(this.BOTON_TestInsurers_Click);
            // 
            // BUTTON_TestAsocciate
            // 
            this.BUTTON_TestAsocciate.Location = new System.Drawing.Point(33, 82);
            this.BUTTON_TestAsocciate.Name = "BUTTON_TestAsocciate";
            this.BUTTON_TestAsocciate.Size = new System.Drawing.Size(216, 42);
            this.BUTTON_TestAsocciate.TabIndex = 1;
            this.BUTTON_TestAsocciate.Text = "Test Associate";
            this.BUTTON_TestAsocciate.UseVisualStyleBackColor = true;
            this.BUTTON_TestAsocciate.Click += new System.EventHandler(this.BUTTON_TestAsocciate_Click);
            // 
            // BUTTON_TestUsers
            // 
            this.BUTTON_TestUsers.Location = new System.Drawing.Point(33, 149);
            this.BUTTON_TestUsers.Name = "BUTTON_TestUsers";
            this.BUTTON_TestUsers.Size = new System.Drawing.Size(216, 42);
            this.BUTTON_TestUsers.TabIndex = 2;
            this.BUTTON_TestUsers.Text = "Test Users";
            this.BUTTON_TestUsers.UseVisualStyleBackColor = true;
            this.BUTTON_TestUsers.Click += new System.EventHandler(this.BUTTON_TestUsers_Click);
            // 
            // BUTTON_TestClients
            // 
            this.BUTTON_TestClients.Location = new System.Drawing.Point(33, 220);
            this.BUTTON_TestClients.Name = "BUTTON_TestClients";
            this.BUTTON_TestClients.Size = new System.Drawing.Size(216, 42);
            this.BUTTON_TestClients.TabIndex = 3;
            this.BUTTON_TestClients.Text = "Test Clients";
            this.BUTTON_TestClients.UseVisualStyleBackColor = true;
            this.BUTTON_TestClients.Click += new System.EventHandler(this.BUTTON_TestClients_Click);
            // 
            // FORM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 310);
            this.Controls.Add(this.BUTTON_TestClients);
            this.Controls.Add(this.BUTTON_TestUsers);
            this.Controls.Add(this.BUTTON_TestAsocciate);
            this.Controls.Add(this.BOTON_TestInsurers);
            this.Name = "FORM_Principal";
            this.Text = "FORM_Principal";
            this.Load += new System.EventHandler(this.FORM_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BOTON_TestInsurers;
        private System.Windows.Forms.Button BUTTON_TestAsocciate;
        private System.Windows.Forms.Button BUTTON_TestUsers;
        private System.Windows.Forms.Button BUTTON_TestClients;
    }
}