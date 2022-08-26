namespace APPSGestionDesInstallationsGPS
{
    partial class frmConfirmation
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
            this.texte_confirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texte_confirm
            // 
            this.texte_confirm.AutoSize = true;
            this.texte_confirm.Location = new System.Drawing.Point(12, 97);
            this.texte_confirm.Name = "texte_confirm";
            this.texte_confirm.Size = new System.Drawing.Size(143, 17);
            this.texte_confirm.TabIndex = 1;
            this.texte_confirm.Text = "Entrer la confirmation";
            this.texte_confirm.Click += new System.EventHandler(this.texte_confirm_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 223);
            this.Controls.Add(this.texte_confirm);
            this.Name = "frmConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmconfirmation";
            this.Load += new System.EventHandler(this.frmconfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texte_confirm;
    }
}