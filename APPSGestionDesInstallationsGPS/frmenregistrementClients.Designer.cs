namespace APPSGestionDesInstallationsGPS
{
    partial class frmenregistrementClients
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
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.txtid_client = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_client,
            this.Nom,
            this.Prenom,
            this.Adresse,
            this.Telephone,
            this.Ville});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 155);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id_client
            // 
            this.id_client.DataPropertyName = "id_client";
            this.id_client.HeaderText = "id_client";
            this.id_client.Name = "id_client";
            this.id_client.Visible = false;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Adresse
            // 
            this.Adresse.DataPropertyName = "adresse";
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            // 
            // Ville
            // 
            this.Ville.DataPropertyName = "ville";
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ville";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(134, 209);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(181, 20);
            this.txtNom.TabIndex = 8;
            this.txtNom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(134, 245);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(181, 20);
            this.txtPrenom.TabIndex = 9;
            this.txtPrenom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(134, 284);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(181, 20);
            this.txtAdresse.TabIndex = 10;
            this.txtAdresse.TextChanged += new System.EventHandler(this.txtAdresse_TextChanged);
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(134, 324);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(181, 20);
            this.txtTelephone.TabIndex = 11;
            this.txtTelephone.TextChanged += new System.EventHandler(this.txtNumero_Telephone_TextChanged);
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(134, 365);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(181, 20);
            this.txtVille.TabIndex = 12;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 442);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(98, 25);
            this.btnEnregistrer.TabIndex = 13;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(134, 442);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(98, 25);
            this.btnmodifier.TabIndex = 14;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(255, 442);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(98, 25);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimmer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(378, 442);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 25);
            this.btnFermer.TabIndex = 16;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // txtid_client
            // 
            this.txtid_client.Location = new System.Drawing.Point(134, 173);
            this.txtid_client.Margin = new System.Windows.Forms.Padding(1);
            this.txtid_client.Name = "txtid_client";
            this.txtid_client.Size = new System.Drawing.Size(1, 20);
            this.txtid_client.TabIndex = 7;
            this.txtid_client.Visible = false;
            this.txtid_client.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmenregistrementClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtid_client);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmenregistrementClients";
            this.Text = "frmenregistrementClients";
            this.Load += new System.EventHandler(this.frmenregistrementClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.TextBox txtid_client;
    }
}