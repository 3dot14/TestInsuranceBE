namespace TestInsuranceBE
{
    partial class FORM_CsvInsurer
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
            this.DATAGRID_CSV = new System.Windows.Forms.DataGridView();
            this.BOTON_Agregar = new System.Windows.Forms.Button();
            this.BOTON_CargarCSV = new System.Windows.Forms.Button();
            this.TEXTBOX_RutaCSV = new System.Windows.Forms.TextBox();
            this.BOTON_VerCSVText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRID_CSV)).BeginInit();
            this.SuspendLayout();
            // 
            // DATAGRID_CSV
            // 
            this.DATAGRID_CSV.AllowUserToAddRows = false;
            this.DATAGRID_CSV.AllowUserToDeleteRows = false;
            this.DATAGRID_CSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRID_CSV.Location = new System.Drawing.Point(14, 123);
            this.DATAGRID_CSV.Name = "DATAGRID_CSV";
            this.DATAGRID_CSV.ReadOnly = true;
            this.DATAGRID_CSV.Size = new System.Drawing.Size(673, 220);
            this.DATAGRID_CSV.TabIndex = 0;
            // 
            // BOTON_Agregar
            // 
            this.BOTON_Agregar.Location = new System.Drawing.Point(595, 12);
            this.BOTON_Agregar.Name = "BOTON_Agregar";
            this.BOTON_Agregar.Size = new System.Drawing.Size(75, 33);
            this.BOTON_Agregar.TabIndex = 1;
            this.BOTON_Agregar.Text = "Agregar";
            this.BOTON_Agregar.UseVisualStyleBackColor = true;
            this.BOTON_Agregar.Click += new System.EventHandler(this.BOTON_Agregar_Click);
            // 
            // BOTON_CargarCSV
            // 
            this.BOTON_CargarCSV.Location = new System.Drawing.Point(14, 12);
            this.BOTON_CargarCSV.Name = "BOTON_CargarCSV";
            this.BOTON_CargarCSV.Size = new System.Drawing.Size(75, 33);
            this.BOTON_CargarCSV.TabIndex = 2;
            this.BOTON_CargarCSV.Text = "Cargar CSV";
            this.BOTON_CargarCSV.UseVisualStyleBackColor = true;
            this.BOTON_CargarCSV.Click += new System.EventHandler(this.BOTON_CargarCSV_Click);
            // 
            // TEXTBOX_RutaCSV
            // 
            this.TEXTBOX_RutaCSV.Location = new System.Drawing.Point(95, 19);
            this.TEXTBOX_RutaCSV.Name = "TEXTBOX_RutaCSV";
            this.TEXTBOX_RutaCSV.Size = new System.Drawing.Size(484, 20);
            this.TEXTBOX_RutaCSV.TabIndex = 3;
            // 
            // BOTON_VerCSVText
            // 
            this.BOTON_VerCSVText.Location = new System.Drawing.Point(14, 61);
            this.BOTON_VerCSVText.Name = "BOTON_VerCSVText";
            this.BOTON_VerCSVText.Size = new System.Drawing.Size(75, 23);
            this.BOTON_VerCSVText.TabIndex = 4;
            this.BOTON_VerCSVText.Text = "Ver CSV Tetxo";
            this.BOTON_VerCSVText.UseVisualStyleBackColor = true;
            this.BOTON_VerCSVText.Click += new System.EventHandler(this.BOTON_VerCSVText_Click);
            // 
            // FORM_CsvInsurer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 355);
            this.Controls.Add(this.BOTON_VerCSVText);
            this.Controls.Add(this.TEXTBOX_RutaCSV);
            this.Controls.Add(this.BOTON_CargarCSV);
            this.Controls.Add(this.BOTON_Agregar);
            this.Controls.Add(this.DATAGRID_CSV);
            this.Name = "FORM_CsvInsurer";
            this.Text = "FORM_CsvInsurer";
            this.Load += new System.EventHandler(this.FORM_CsvInsurer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRID_CSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DATAGRID_CSV;
        private System.Windows.Forms.Button BOTON_Agregar;
        private System.Windows.Forms.Button BOTON_CargarCSV;
        private System.Windows.Forms.TextBox TEXTBOX_RutaCSV;
        private System.Windows.Forms.Button BOTON_VerCSVText;
    }
}