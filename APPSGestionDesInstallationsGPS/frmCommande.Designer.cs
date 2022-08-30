namespace APPSGestionDesInstallationsGPS
{
    partial class frmCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtlieu = new System.Windows.Forms.TextBox();
            this.txtprix_installation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbosuivi = new System.Windows.Forms.ComboBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtremise = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frais_sejour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_reduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prixtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixinstallation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprix_reduit = new System.Windows.Forms.TextBox();
            this.btnremise = new System.Windows.Forms.Button();
            this.txtlegers = new System.Windows.Forms.TextBox();
            this.txttricycle = new System.Windows.Forms.TextBox();
            this.txtlourds = new System.Windows.Forms.TextBox();
            this.txtmoto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboclient = new System.Windows.Forms.ComboBox();
            this.btncalcul = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmarque = new System.Windows.Forms.TextBox();
            this.txtimmatriculation = new System.Windows.Forms.TextBox();
            this.cbocategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdure = new System.Windows.Forms.TextBox();
            this.btnmodifier2 = new System.Windows.Forms.Button();
            this.btnavancer = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtsejour = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtdeplacement = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtprix_suivi = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtprix_total = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(17, 594);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(114, 25);
            this.btnEnregistrer.TabIndex = 44;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtlieu
            // 
            this.txtlieu.BackColor = System.Drawing.SystemColors.Info;
            this.txtlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlieu.Location = new System.Drawing.Point(141, 357);
            this.txtlieu.Name = "txtlieu";
            this.txtlieu.Size = new System.Drawing.Size(286, 24);
            this.txtlieu.TabIndex = 6;
            // 
            // txtprix_installation
            // 
            this.txtprix_installation.BackColor = System.Drawing.SystemColors.Info;
            this.txtprix_installation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprix_installation.Location = new System.Drawing.Point(168, 137);
            this.txtprix_installation.Name = "txtprix_installation";
            this.txtprix_installation.ReadOnly = true;
            this.txtprix_installation.Size = new System.Drawing.Size(286, 24);
            this.txtprix_installation.TabIndex = 35;
            this.txtprix_installation.TextChanged += new System.EventHandler(this.txtprix_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lieu d\'installation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Prix de l\'installation:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Commande:";
            // 
            // dtpDate
            // 
            this.dtpDate.AccessibleDescription = "";
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(141, 323);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(286, 24);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.Location = new System.Drawing.Point(6, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Suivi:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbosuivi
            // 
            this.cbosuivi.BackColor = System.Drawing.SystemColors.Info;
            this.cbosuivi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosuivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbosuivi.FormattingEnabled = true;
            this.cbosuivi.Items.AddRange(new object[] {
            "(aucun)",
            "Mensuel",
            "Annuel"});
            this.cbosuivi.Location = new System.Drawing.Point(119, 134);
            this.cbosuivi.Name = "cbosuivi";
            this.cbosuivi.Size = new System.Drawing.Size(286, 26);
            this.cbosuivi.TabIndex = 14;
            this.cbosuivi.SelectedIndexChanged += new System.EventHandler(this.cbosuivi_SelectedIndexChanged);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(137, 593);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(98, 25);
            this.btnmodifier.TabIndex = 45;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(241, 596);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(98, 25);
            this.btnannuler.TabIndex = 46;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du client";
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(345, 595);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(111, 27);
            this.btnFermer.TabIndex = 47;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 38;
            this.label3.Text = "Remise:";
            // 
            // txtremise
            // 
            this.txtremise.BackColor = System.Drawing.SystemColors.Info;
            this.txtremise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremise.Location = new System.Drawing.Point(168, 221);
            this.txtremise.Name = "txtremise";
            this.txtremise.Size = new System.Drawing.Size(148, 24);
            this.txtremise.TabIndex = 39;
            this.txtremise.TextChanged += new System.EventHandler(this.txtremise_TextChanged);
            this.txtremise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtremise_KeyPress);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_commande,
            this.id_client,
            this.date_commande,
            this.lieu,
            this.frais_sejour,
            this.deplacement,
            this.prix_reduit,
            this.Prixtotal,
            this.suivi,
            this.prixinstallation,
            this.Quantite});
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1371, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // id_commande
            // 
            this.id_commande.DataPropertyName = "id_commande";
            this.id_commande.HeaderText = "id_commande";
            this.id_commande.Name = "id_commande";
            this.id_commande.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_commande.Visible = false;
            // 
            // id_client
            // 
            this.id_client.DataPropertyName = "id_client";
            this.id_client.HeaderText = "id_client";
            this.id_client.Name = "id_client";
            this.id_client.Visible = false;
            // 
            // date_commande
            // 
            this.date_commande.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_commande.DataPropertyName = "Date_commande";
            this.date_commande.HeaderText = "Date de la commande";
            this.date_commande.Name = "date_commande";
            // 
            // lieu
            // 
            this.lieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lieu.DataPropertyName = "lieu";
            this.lieu.HeaderText = "Lieu";
            this.lieu.Name = "lieu";
            // 
            // frais_sejour
            // 
            this.frais_sejour.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.frais_sejour.DataPropertyName = "frais_sejour";
            this.frais_sejour.HeaderText = "Frais de séjour";
            this.frais_sejour.Name = "frais_sejour";
            // 
            // deplacement
            // 
            this.deplacement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deplacement.DataPropertyName = "frais_deplacement";
            this.deplacement.HeaderText = "Frais de déplacement";
            this.deplacement.Name = "deplacement";
            // 
            // prix_reduit
            // 
            this.prix_reduit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prix_reduit.DataPropertyName = "prix_reduit";
            this.prix_reduit.HeaderText = "Prix reduit";
            this.prix_reduit.Name = "prix_reduit";
            // 
            // Prixtotal
            // 
            this.Prixtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prixtotal.DataPropertyName = "Prix_total";
            this.Prixtotal.HeaderText = "Prix total";
            this.Prixtotal.Name = "Prixtotal";
            // 
            // suivi
            // 
            this.suivi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.suivi.DataPropertyName = "prix_suivi";
            this.suivi.HeaderText = "Prix du suivi";
            this.suivi.Name = "suivi";
            // 
            // prixinstallation
            // 
            this.prixinstallation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixinstallation.DataPropertyName = "prix_installation";
            this.prixinstallation.HeaderText = "prix de l\'installation";
            this.prixinstallation.Name = "prixinstallation";
            // 
            // Quantite
            // 
            this.Quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantite.DataPropertyName = "quantite";
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "Prix avec remise:";
            // 
            // txtprix_reduit
            // 
            this.txtprix_reduit.BackColor = System.Drawing.SystemColors.Info;
            this.txtprix_reduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprix_reduit.Location = new System.Drawing.Point(168, 268);
            this.txtprix_reduit.Name = "txtprix_reduit";
            this.txtprix_reduit.ReadOnly = true;
            this.txtprix_reduit.Size = new System.Drawing.Size(286, 24);
            this.txtprix_reduit.TabIndex = 42;
            this.txtprix_reduit.TextChanged += new System.EventHandler(this.txtprix_reduit_TextChanged);
            // 
            // btnremise
            // 
            this.btnremise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremise.Location = new System.Drawing.Point(322, 221);
            this.btnremise.Name = "btnremise";
            this.btnremise.Size = new System.Drawing.Size(132, 24);
            this.btnremise.TabIndex = 40;
            this.btnremise.Text = "Faire la remise";
            this.btnremise.UseVisualStyleBackColor = true;
            this.btnremise.Click += new System.EventHandler(this.btnremise_Click_1);
            // 
            // txtlegers
            // 
            this.txtlegers.BackColor = System.Drawing.SystemColors.Info;
            this.txtlegers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlegers.Location = new System.Drawing.Point(121, 206);
            this.txtlegers.Name = "txtlegers";
            this.txtlegers.ReadOnly = true;
            this.txtlegers.Size = new System.Drawing.Size(65, 24);
            this.txtlegers.TabIndex = 18;
            this.txtlegers.Click += new System.EventHandler(this.txtlegers_Click);
            this.txtlegers.TextChanged += new System.EventHandler(this.txtlegers_TextChanged);
            this.txtlegers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlegers_KeyPress);
            // 
            // txttricycle
            // 
            this.txttricycle.BackColor = System.Drawing.SystemColors.Info;
            this.txttricycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttricycle.Location = new System.Drawing.Point(344, 203);
            this.txttricycle.Name = "txttricycle";
            this.txttricycle.ReadOnly = true;
            this.txttricycle.Size = new System.Drawing.Size(65, 24);
            this.txttricycle.TabIndex = 20;
            this.txttricycle.Click += new System.EventHandler(this.txttricycle_Click);
            // 
            // txtlourds
            // 
            this.txtlourds.BackColor = System.Drawing.SystemColors.Info;
            this.txtlourds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlourds.Location = new System.Drawing.Point(125, 253);
            this.txtlourds.Name = "txtlourds";
            this.txtlourds.ReadOnly = true;
            this.txtlourds.Size = new System.Drawing.Size(65, 24);
            this.txtlourds.TabIndex = 22;
            this.txtlourds.Click += new System.EventHandler(this.txtlourds_Click);
            // 
            // txtmoto
            // 
            this.txtmoto.BackColor = System.Drawing.SystemColors.Info;
            this.txtmoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmoto.Location = new System.Drawing.Point(344, 251);
            this.txtmoto.Name = "txtmoto";
            this.txtmoto.ReadOnly = true;
            this.txtmoto.Size = new System.Drawing.Size(65, 24);
            this.txtmoto.TabIndex = 24;
            this.txtmoto.TabStop = false;
            this.txtmoto.Click += new System.EventHandler(this.txtmoto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Véhicules legers:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(216, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tricyle à moteur:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-1, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 18);
            this.label15.TabIndex = 21;
            this.label15.Text = " Poids lourds:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(216, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 18);
            this.label16.TabIndex = 23;
            this.label16.Text = "Moto-cyclette:";
            // 
            // cboclient
            // 
            this.cboclient.BackColor = System.Drawing.SystemColors.Info;
            this.cboclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboclient.FormattingEnabled = true;
            this.cboclient.Location = new System.Drawing.Point(141, 287);
            this.cboclient.Name = "cboclient";
            this.cboclient.Size = new System.Drawing.Size(286, 25);
            this.cboclient.TabIndex = 2;
            this.cboclient.SelectedIndexChanged += new System.EventHandler(this.cboclient_SelectedIndexChanged);
            // 
            // btncalcul
            // 
            this.btncalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcul.Location = new System.Drawing.Point(9, 313);
            this.btncalcul.Name = "btncalcul";
            this.btncalcul.Size = new System.Drawing.Size(133, 29);
            this.btncalcul.TabIndex = 43;
            this.btncalcul.Text = "Calcul du prix";
            this.btncalcul.UseVisualStyleBackColor = true;
            this.btncalcul.Click += new System.EventHandler(this.btncalcul_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(2, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 70;
            this.label7.Text = "Immatriculation:";
            // 
            // txtmarque
            // 
            this.txtmarque.BackColor = System.Drawing.SystemColors.Info;
            this.txtmarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarque.Location = new System.Drawing.Point(120, 96);
            this.txtmarque.Name = "txtmarque";
            this.txtmarque.Size = new System.Drawing.Size(286, 24);
            this.txtmarque.TabIndex = 71;
            // 
            // txtimmatriculation
            // 
            this.txtimmatriculation.BackColor = System.Drawing.SystemColors.Info;
            this.txtimmatriculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimmatriculation.Location = new System.Drawing.Point(120, 63);
            this.txtimmatriculation.Name = "txtimmatriculation";
            this.txtimmatriculation.Size = new System.Drawing.Size(286, 24);
            this.txtimmatriculation.TabIndex = 12;
            // 
            // cbocategorie
            // 
            this.cbocategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocategorie.FormattingEnabled = true;
            this.cbocategorie.Location = new System.Drawing.Point(120, 26);
            this.cbocategorie.Name = "cbocategorie";
            this.cbocategorie.Size = new System.Drawing.Size(286, 26);
            this.cbocategorie.TabIndex = 10;
            this.cbocategorie.SelectedIndexChanged += new System.EventHandler(this.cboclient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Catégorie:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtdure);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtmarque);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtimmatriculation);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbocategorie);
            this.groupBox1.Controls.Add(this.txtmoto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtlourds);
            this.groupBox1.Controls.Add(this.btnmodifier2);
            this.groupBox1.Controls.Add(this.txttricycle);
            this.groupBox1.Controls.Add(this.btnavancer);
            this.groupBox1.Controls.Add(this.txtlegers);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.cbosuivi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(465, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 348);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement des véhicules";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Marque:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "Duré:";
            // 
            // txtdure
            // 
            this.txtdure.BackColor = System.Drawing.SystemColors.Info;
            this.txtdure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdure.Location = new System.Drawing.Point(119, 170);
            this.txtdure.Name = "txtdure";
            this.txtdure.Size = new System.Drawing.Size(286, 24);
            this.txtdure.TabIndex = 16;
            this.txtdure.TextChanged += new System.EventHandler(this.txtdure_TextChanged);
            this.txtdure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdure_KeyPress);
            // 
            // btnmodifier2
            // 
            this.btnmodifier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier2.Location = new System.Drawing.Point(4, 313);
            this.btnmodifier2.Name = "btnmodifier2";
            this.btnmodifier2.Size = new System.Drawing.Size(87, 29);
            this.btnmodifier2.TabIndex = 27;
            this.btnmodifier2.Text = "Modifier";
            this.btnmodifier2.UseVisualStyleBackColor = true;
            this.btnmodifier2.Click += new System.EventHandler(this.btnmodifier2_Click);
            // 
            // btnavancer
            // 
            this.btnavancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavancer.Location = new System.Drawing.Point(126, 313);
            this.btnavancer.Name = "btnavancer";
            this.btnavancer.Size = new System.Drawing.Size(86, 29);
            this.btnavancer.TabIndex = 26;
            this.btnavancer.Text = "Avancer";
            this.btnavancer.UseVisualStyleBackColor = true;
            this.btnavancer.Click += new System.EventHandler(this.btnavancer_Click);
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(348, 313);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(54, 29);
            this.btnok.TabIndex = 25;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtsejour
            // 
            this.txtsejour.BackColor = System.Drawing.SystemColors.Info;
            this.txtsejour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsejour.Location = new System.Drawing.Point(168, 30);
            this.txtsejour.Name = "txtsejour";
            this.txtsejour.Size = new System.Drawing.Size(286, 24);
            this.txtsejour.TabIndex = 29;
            this.txtsejour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsejour_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 18);
            this.label18.TabIndex = 28;
            this.label18.Text = "Fais de séjour:";
            // 
            // txtdeplacement
            // 
            this.txtdeplacement.BackColor = System.Drawing.SystemColors.Info;
            this.txtdeplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeplacement.Location = new System.Drawing.Point(168, 65);
            this.txtdeplacement.Name = "txtdeplacement";
            this.txtdeplacement.Size = new System.Drawing.Size(286, 24);
            this.txtdeplacement.TabIndex = 31;
            this.txtdeplacement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdeplacement_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 18);
            this.label19.TabIndex = 30;
            this.label19.Text = "Frais de déplacement:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtprix_suivi
            // 
            this.txtprix_suivi.BackColor = System.Drawing.SystemColors.Info;
            this.txtprix_suivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprix_suivi.Location = new System.Drawing.Point(168, 100);
            this.txtprix_suivi.Name = "txtprix_suivi";
            this.txtprix_suivi.ReadOnly = true;
            this.txtprix_suivi.Size = new System.Drawing.Size(286, 24);
            this.txtprix_suivi.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 18);
            this.label20.TabIndex = 32;
            this.label20.Text = "Prix du suivi:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(6, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 18);
            this.label21.TabIndex = 36;
            this.label21.Text = "Prix Total:";
            // 
            // txtprix_total
            // 
            this.txtprix_total.BackColor = System.Drawing.SystemColors.Info;
            this.txtprix_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprix_total.Location = new System.Drawing.Point(168, 173);
            this.txtprix_total.Name = "txtprix_total";
            this.txtprix_total.ReadOnly = true;
            this.txtprix_total.Size = new System.Drawing.Size(286, 24);
            this.txtprix_total.TabIndex = 37;
            this.txtprix_total.TextChanged += new System.EventHandler(this.txtprix_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 403);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 18);
            this.label22.TabIndex = 7;
            this.label22.Text = "Type d\'installation:";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // cbotype
            // 
            this.cbotype.BackColor = System.Drawing.SystemColors.Info;
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "Locale",
            "Nationale"});
            this.cbotype.Location = new System.Drawing.Point(141, 398);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(286, 25);
            this.cbotype.TabIndex = 8;
            this.cbotype.SelectedIndexChanged += new System.EventHandler(this.cboclient_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtprix_suivi);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.btncalcul);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtprix_installation);
            this.groupBox2.Controls.Add(this.txtprix_total);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtsejour);
            this.groupBox2.Controls.Add(this.txtremise);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtprix_reduit);
            this.groupBox2.Controls.Add(this.btnremise);
            this.groupBox2.Controls.Add(this.txtdeplacement);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(905, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 348);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frais à payer";
            // 
            // frmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.cbotype);
            this.Controls.Add(this.cboclient);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtlieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrement des commandes";
            this.Load += new System.EventHandler(this.frmCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtlieu;
        private System.Windows.Forms.TextBox txtprix_installation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbosuivi;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtremise;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprix_reduit;
        private System.Windows.Forms.Button btnremise;
        private System.Windows.Forms.TextBox txtlegers;
        private System.Windows.Forms.TextBox txttricycle;
        private System.Windows.Forms.TextBox txtlourds;
        private System.Windows.Forms.TextBox txtmoto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboclient;
        private System.Windows.Forms.Button btncalcul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmarque;
        private System.Windows.Forms.TextBox txtimmatriculation;
        private System.Windows.Forms.ComboBox cbocategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdure;
        private System.Windows.Forms.TextBox txtsejour;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtdeplacement;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtprix_suivi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtprix_total;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.Button btnavancer;
        private System.Windows.Forms.Button btnmodifier2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn frais_sejour;
        private System.Windows.Forms.DataGridViewTextBoxColumn deplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_reduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prixtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn suivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixinstallation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
    }
}