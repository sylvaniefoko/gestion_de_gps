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
            this.texte_erreur.BackColor = System.Drawing.Color.Transparent;
            this.texte_erreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texte_erreur.Location = new System.Drawing.Point(73, 79);
            this.texte_erreur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texte_erreur.Name = "texte_erreur";
            this.texte_erreur.Size = new System.Drawing.Size(176, 18);
            this.texte_erreur.TabIndex = 0;
            this.texte_erreur.Text = "Entrer l\'érreur signaler";
            // 
            // frmerreur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::APPSGestionDesInstallationsGPS.Properties.Resources.erreur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(318, 221);
            this.Controls.Add(this.texte_erreur);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmerreur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erreur signaler";
            this.Load += new System.EventHandler(this.frmerreur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texte_erreur;
    }
}