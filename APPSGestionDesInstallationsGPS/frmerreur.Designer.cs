namespace APPSGestionDesInstallationsGPS
{
    partial class frmerreur
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
            this.texte_erreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // texte_erreur
            // 
            this.texte_erreur.AutoSize = true;
            this.texte_erreur.Location = new System.Drawing.Point(12, 89);
            this.texte_erreur.Name = "texte_erreur";
            this.texte_erreur.Size = new System.Drawing.Size(150, 17);
            this.texte_erreur.TabIndex = 0;
            this.texte_erreur.Text = "Entrer l\'érreur signaler";
            // 
            // frmerreur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 219);
            this.Controls.Add(this.texte_erreur);
            this.Name = "frmerreur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmerreur";
            this.Load += new System.EventHandler(this.frmerreur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texte_erreur;
    }
}