namespace APPSGestionDesInstallationsGPS
{
    partial class frmvehicule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtcategorie = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.id_catvehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_catvehicule,
            this.categorie,
            this.prix});
            this.dataGridView1.Location = new System.Drawing.Point(10, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(303, 387);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(85, 31);
            this.btnAnnuler.TabIndex = 20;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(147, 387);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(96, 31);
            this.btnmodifier.TabIndex = 18;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(13, 387);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(95, 31);
            this.btnEnregistrer.TabIndex = 17;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Categorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Prix de l\'installation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(188, 291);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(240, 22);
            this.txtPrix.TabIndex = 27;
            // 
            // txtcategorie
            // 
            this.txtcategorie.Location = new System.Drawing.Point(188, 222);
            this.txtcategorie.Margin = new System.Windows.Forms.Padding(4);
            this.txtcategorie.Name = "txtcategorie";
            this.txtcategorie.Size = new System.Drawing.Size(240, 22);
            this.txtcategorie.TabIndex = 33;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(444, 387);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(85, 31);
            this.btnSupprimer.TabIndex = 34;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // id_catvehicule
            // 
            this.id_catvehicule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_catvehicule.DataPropertyName = "id_catvehicule";
            this.id_catvehicule.HeaderText = "id_catveicule";
            this.id_catvehicule.Name = "id_catvehicule";
            this.id_catvehicule.Visible = false;
            // 
            // categorie
            // 
            this.categorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categorie.DataPropertyName = "categorie_vehicule";
            this.categorie.HeaderText = "Categorie";
            this.categorie.Name = "categorie";
            // 
            // prix
            // 
            this.prix.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prix.DataPropertyName = "prix_installation";
            this.prix.HeaderText = "Prix de l\'installation";
            this.prix.Name = "prix";
            // 
            // frmvehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 453);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.txtcategorie);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmvehicule";
            this.Text = "frmvehicule";
            this.Load += new System.EventHandler(this.frmvehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtcategorie;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_catvehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
    }
}