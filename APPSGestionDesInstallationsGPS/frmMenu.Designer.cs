namespace APPSGestionDesInstallationsGPS
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suiviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFermer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.comptesToolStripMenuItem,
            this.connexionToolStripMenuItem,
            this.vehiculeToolStripMenuItem,
            this.technicienToolStripMenuItem,
            this.installationToolStripMenuItem,
            this.suiviToolStripMenuItem,
            this.commandeToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(223, 526);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.clientToolStripMenuItem.Text = "client";
            this.clientToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.comptesToolStripMenuItem.Text = "gestionnaire de compte";
            this.comptesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.comptesToolStripMenuItem.Click += new System.EventHandler(this.comptesToolStripMenuItem_Click);
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.connexionToolStripMenuItem.Text = "connexion";
            this.connexionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.connexionToolStripMenuItem.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // vehiculeToolStripMenuItem
            // 
            this.vehiculeToolStripMenuItem.Name = "vehiculeToolStripMenuItem";
            this.vehiculeToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.vehiculeToolStripMenuItem.Text = "vehicule";
            this.vehiculeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.vehiculeToolStripMenuItem.Click += new System.EventHandler(this.vehiculeToolStripMenuItem_Click);
            // 
            // technicienToolStripMenuItem
            // 
            this.technicienToolStripMenuItem.Name = "technicienToolStripMenuItem";
            this.technicienToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.technicienToolStripMenuItem.Text = "Technicien";
            this.technicienToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.technicienToolStripMenuItem.Click += new System.EventHandler(this.technicienToolStripMenuItem_Click);
            // 
            // installationToolStripMenuItem
            // 
            this.installationToolStripMenuItem.Name = "installationToolStripMenuItem";
            this.installationToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.installationToolStripMenuItem.Text = "Installation";
            this.installationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.installationToolStripMenuItem.Click += new System.EventHandler(this.installationToolStripMenuItem_Click);
            // 
            // suiviToolStripMenuItem
            // 
            this.suiviToolStripMenuItem.Name = "suiviToolStripMenuItem";
            this.suiviToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.suiviToolStripMenuItem.Text = "suivi";
            this.suiviToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.suiviToolStripMenuItem.Click += new System.EventHandler(this.suiviToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(214, 25);
            this.commandeToolStripMenuItem.Text = "commande";
            this.commandeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.commandeToolStripMenuItem.Click += new System.EventHandler(this.commandeToolStripMenuItem_Click_1);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFermer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.Gray;
            this.btnFermer.Location = new System.Drawing.Point(677, 0);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(60, 41);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "x";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 526);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculeToolStripMenuItem;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ToolStripMenuItem technicienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suiviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
    }
}