namespace APPSGestionDesInstallationsGPS
{
    partial class frmsuivi
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtcategorie = new System.Windows.Forms.TextBox();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_suivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_suivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_suivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(443, 306);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(85, 31);
            this.btnSupprimer.TabIndex = 43;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtcategorie
            // 
            this.txtcategorie.Location = new System.Drawing.Point(172, 192);
            this.txtcategorie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcategorie.Name = "txtcategorie";
            this.txtcategorie.Size = new System.Drawing.Size(240, 22);
            this.txtcategorie.TabIndex = 42;
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(172, 236);
            this.txtprix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(240, 22);
            this.txtprix.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Prix_suivi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "type de suivi";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(308, 306);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(85, 31);
            this.btnAnnuler.TabIndex = 38;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(139, 306);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(96, 31);
            this.btnmodifier.TabIndex = 37;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(8, 306);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(95, 31);
            this.btnEnregistrer.TabIndex = 36;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_suivi,
            this.prix_suivi,
            this.type_suivi});
            this.dataGridView1.Location = new System.Drawing.Point(88, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 137);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id_suivi
            // 
            this.id_suivi.DataPropertyName = "id_suivi";
            this.id_suivi.HeaderText = "id_suivi";
            this.id_suivi.Name = "id_suivi";
            this.id_suivi.Visible = false;
            // 
            // prix_suivi
            // 
            this.prix_suivi.DataPropertyName = "prix_suivi";
            this.prix_suivi.HeaderText = "Prix suivi";
            this.prix_suivi.Name = "prix_suivi";
            // 
            // type_suivi
            // 
            this.type_suivi.DataPropertyName = "type_suivi";
            this.type_suivi.HeaderText = "type suivi";
            this.type_suivi.Name = "type_suivi";
            // 
            // frmsuivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtcategorie);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnEnregistrer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmsuivi";
            this.Text = "frmsuivi";
            this.Load += new System.EventHandler(this.frmsuivi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtcategorie;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_suivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_suivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_suivi;
    }
}