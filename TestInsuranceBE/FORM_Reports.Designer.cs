namespace TestInsuranceBE
{
	partial class FORM_Reports
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
			this.BUTTON_QueryReports = new System.Windows.Forms.Button();
			this.DATAGRIDVIEW_QueryReports = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DATAGRIDVIEW_QueryReports)).BeginInit();
			this.SuspendLayout();
			// 
			// TEXTBOX_ConnectionString
			// 
			this.TEXTBOX_ConnectionString.Location = new System.Drawing.Point(157, 50);
			this.TEXTBOX_ConnectionString.Name = "TEXTBOX_ConnectionString";
			this.TEXTBOX_ConnectionString.Size = new System.Drawing.Size(537, 22);
			this.TEXTBOX_ConnectionString.TabIndex = 0;
			this.TEXTBOX_ConnectionString.Text = "data source=.\\SQLEXPRESS; Initial Catalog = INSURERS_DB; Integrated Security = Tr" +
    "ue;";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "ConnectionString:";
			// 
			// BUTTON_QueryReports
			// 
			this.BUTTON_QueryReports.Location = new System.Drawing.Point(157, 120);
			this.BUTTON_QueryReports.Name = "BUTTON_QueryReports";
			this.BUTTON_QueryReports.Size = new System.Drawing.Size(134, 29);
			this.BUTTON_QueryReports.TabIndex = 2;
			this.BUTTON_QueryReports.Text = "Query Reports";
			this.BUTTON_QueryReports.UseVisualStyleBackColor = true;
			this.BUTTON_QueryReports.Click += new System.EventHandler(this.BUTTON_QueryReports_Click);
			// 
			// DATAGRIDVIEW_QueryReports
			// 
			this.DATAGRIDVIEW_QueryReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DATAGRIDVIEW_QueryReports.Location = new System.Drawing.Point(34, 297);
			this.DATAGRIDVIEW_QueryReports.Name = "DATAGRIDVIEW_QueryReports";
			this.DATAGRIDVIEW_QueryReports.RowTemplate.Height = 24;
			this.DATAGRIDVIEW_QueryReports.Size = new System.Drawing.Size(856, 170);
			this.DATAGRIDVIEW_QueryReports.TabIndex = 3;
			// 
			// FORM_Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(979, 746);
			this.Controls.Add(this.DATAGRIDVIEW_QueryReports);
			this.Controls.Add(this.BUTTON_QueryReports);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TEXTBOX_ConnectionString);
			this.Name = "FORM_Reports";
			this.Text = "FORM_Reports";
			((System.ComponentModel.ISupportInitialize)(this.DATAGRIDVIEW_QueryReports)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TEXTBOX_ConnectionString;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BUTTON_QueryReports;
		private System.Windows.Forms.DataGridView DATAGRIDVIEW_QueryReports;
	}
}