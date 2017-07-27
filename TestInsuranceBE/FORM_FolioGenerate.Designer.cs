namespace TestInsuranceBE
{
	partial class FORM_FolioGenerate
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
			this.TEXTBOX_ConnectionString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TEXTBOX_CertificateId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TEXTBOX_Folio = new System.Windows.Forms.TextBox();
			this.BUTTON_FolioGenerate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TEXTBOX_ConnectionString
			// 
			this.TEXTBOX_ConnectionString.Location = new System.Drawing.Point(139, 25);
			this.TEXTBOX_ConnectionString.Name = "TEXTBOX_ConnectionString";
			this.TEXTBOX_ConnectionString.Size = new System.Drawing.Size(552, 22);
			this.TEXTBOX_ConnectionString.TabIndex = 0;
			this.TEXTBOX_ConnectionString.Text = "data source=.\\SQLEXPRESS; Initial Catalog = INSURERS_DB; Integrated Security = Tr" +
    "ue;";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "ConnectionString:";
			// 
			// TEXTBOX_CertificateId
			// 
			this.TEXTBOX_CertificateId.Location = new System.Drawing.Point(139, 72);
			this.TEXTBOX_CertificateId.Name = "TEXTBOX_CertificateId";
			this.TEXTBOX_CertificateId.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_CertificateId.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Certificate Id:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(91, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Folio:";
			// 
			// TEXTBOX_Folio
			// 
			this.TEXTBOX_Folio.Location = new System.Drawing.Point(139, 199);
			this.TEXTBOX_Folio.Name = "TEXTBOX_Folio";
			this.TEXTBOX_Folio.Size = new System.Drawing.Size(100, 22);
			this.TEXTBOX_Folio.TabIndex = 6;
			// 
			// BUTTON_FolioGenerate
			// 
			this.BUTTON_FolioGenerate.Location = new System.Drawing.Point(139, 135);
			this.BUTTON_FolioGenerate.Name = "BUTTON_FolioGenerate";
			this.BUTTON_FolioGenerate.Size = new System.Drawing.Size(75, 23);
			this.BUTTON_FolioGenerate.TabIndex = 7;
			this.BUTTON_FolioGenerate.Text = "Generar Folio";
			this.BUTTON_FolioGenerate.UseVisualStyleBackColor = true;
			this.BUTTON_FolioGenerate.Click += new System.EventHandler(this.BUTTON_FolioGenerate_Click);
			// 
			// FORM_FolioGenerate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(737, 358);
			this.Controls.Add(this.BUTTON_FolioGenerate);
			this.Controls.Add(this.TEXTBOX_Folio);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TEXTBOX_CertificateId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TEXTBOX_ConnectionString);
			this.Name = "FORM_FolioGenerate";
			this.Text = "FORM_FolioGenerate";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TEXTBOX_ConnectionString;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TEXTBOX_CertificateId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TEXTBOX_Folio;
		private System.Windows.Forms.Button BUTTON_FolioGenerate;
	}
}