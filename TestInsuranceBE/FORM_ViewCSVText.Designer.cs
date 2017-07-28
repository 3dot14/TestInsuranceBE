namespace TestInsuranceBE
{
    partial class FORM_ViewCSVText
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
            this.TEXTBOX_CSV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TEXTBOX_CSV
            // 
            this.TEXTBOX_CSV.Location = new System.Drawing.Point(12, 33);
            this.TEXTBOX_CSV.Multiline = true;
            this.TEXTBOX_CSV.Name = "TEXTBOX_CSV";
            this.TEXTBOX_CSV.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TEXTBOX_CSV.Size = new System.Drawing.Size(670, 293);
            this.TEXTBOX_CSV.TabIndex = 0;
            // 
            // FORM_ViewCSVText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 338);
            this.Controls.Add(this.TEXTBOX_CSV);
            this.Name = "FORM_ViewCSVText";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FORM_ViewCSVText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXTBOX_CSV;
    }
}