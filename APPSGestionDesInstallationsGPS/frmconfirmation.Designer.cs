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
            this.texte_confirm.BackColor = System.Drawing.Color.Transparent;
            this.texte_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texte_confirm.Location = new System.Drawing.Point(61, 83);
            this.texte_confirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.texte_confirm.Name = "texte_confirm";
            this.texte_confirm.Size = new System.Drawing.Size(171, 18);
            this.texte_confirm.TabIndex = 1;
            this.texte_confirm.Text = "Entrer la confirmation";
            this.texte_confirm.Click += new System.EventHandler(this.texte_confirm_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::APPSGestionDesInstallationsGPS.Properties.Resources.confirmer1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(280, 181);
            this.Controls.Add(this.texte_confirm);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmer";
            this.Load += new System.EventHandler(this.frmconfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texte_confirm;
    }
}