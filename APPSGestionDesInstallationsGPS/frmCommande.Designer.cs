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
            this.prix_installation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_suivi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frais_sejour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_reduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmarque = new System.Windows.Forms.TextBox();
            this.txtimmatriculation = new System.Windows.Forms.TextBox();
            this.cbocategorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdure = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(42, 738);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(131, 31);
            this.btnEnregistrer.TabIndex = 30;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtlieu
            // 
            this.txtlieu.Location = new System.Drawing.Point(820, 251);
            this.txtlieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtlieu.Name = "txtlieu";
            this.txtlieu.Size = new System.Drawing.Size(323, 22);
            this.txtlieu.TabIndex = 29;
            // 
            // txtprix_installation
            // 
            this.txtprix_installation.Location = new System.Drawing.Point(820, 491);
            this.txtprix_installation.Margin = new System.Windows.Forms.Padding(4);
            this.txtprix_installation.Name = "txtprix_installation";
            this.txtprix_installation.ReadOnly = true;
            this.txtprix_installation.Size = new System.Drawing.Size(323, 22);
            this.txtprix_installation.TabIndex = 28;
            this.txtprix_installation.TextChanged += new System.EventHandler(this.txtprix_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Lieu d\'installation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 496);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Prix de l\'installation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date Commande";
            // 
            // dtpDate
            // 
            this.dtpDate.AccessibleDescription = "";
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(155, 305);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(355, 22);
            this.dtpDate.TabIndex = 40;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "suivi";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbosuivi
            // 
            this.cbosuivi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosuivi.FormattingEnabled = true;
            this.cbosuivi.Items.AddRange(new object[] {
            "(aucun)",
            "Mensuel",
            "Annuel"});
            this.cbosuivi.Location = new System.Drawing.Point(139, 173);
            this.cbosuivi.Margin = new System.Windows.Forms.Padding(4);
            this.cbosuivi.Name = "cbosuivi";
            this.cbosuivi.Size = new System.Drawing.Size(360, 24);
            this.cbosuivi.TabIndex = 41;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(376, 738);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(131, 31);
            this.btnmodifier.TabIndex = 46;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(672, 738);
            this.btnannuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(131, 31);
            this.btnannuler.TabIndex = 48;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom client";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(979, 738);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(131, 31);
            this.btnFermer.TabIndex = 53;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 568);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Remise";
            // 
            // txtremise
            // 
            this.txtremise.Location = new System.Drawing.Point(820, 560);
            this.txtremise.Margin = new System.Windows.Forms.Padding(4);
            this.txtremise.Name = "txtremise";
            this.txtremise.Size = new System.Drawing.Size(196, 22);
            this.txtremise.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_commande,
            this.id_client,
            this.date_commande,
            this.lieu,
            this.prix_installation,
            this.prix_total,
            this.prix_suivi,
            this.frais_sejour,
            this.deplacement,
            this.prix_reduit,
            this.Quantite});
            this.dataGridView1.Location = new System.Drawing.Point(168, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 217);
            this.dataGridView1.TabIndex = 57;
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
            this.date_commande.DataPropertyName = "Date_commande";
            this.date_commande.HeaderText = "Date de la commande";
            this.date_commande.Name = "date_commande";
            // 
            // lieu
            // 
            this.lieu.DataPropertyName = "lieu";
            this.lieu.HeaderText = "Lieu";
            this.lieu.Name = "lieu";
            // 
            // prix_installation
            // 
            this.prix_installation.DataPropertyName = "Prix_installation";
            this.prix_installation.HeaderText = "Prix de l\'installation";
            this.prix_installation.Name = "prix_installation";
            // 
            // prix_total
            // 
            this.prix_total.DataPropertyName = "prix_total";
            this.prix_total.HeaderText = "Prix total";
            this.prix_total.Name = "prix_total";
            // 
            // prix_suivi
            // 
            this.prix_suivi.DataPropertyName = "prix_suivi";
            this.prix_suivi.HeaderText = "Prix du suivi";
            this.prix_suivi.Name = "prix_suivi";
            // 
            // frais_sejour
            // 
            this.frais_sejour.DataPropertyName = "frais_sejour";
            this.frais_sejour.HeaderText = "Frais de sejour";
            this.frais_sejour.Name = "frais_sejour";
            // 
            // deplacement
            // 
            this.deplacement.DataPropertyName = "rais_deplacement";
            this.deplacement.HeaderText = "Frais de déplacement";
            this.deplacement.Name = "deplacement";
            // 
            // prix_reduit
            // 
            this.prix_reduit.DataPropertyName = "prix_reduit";
            this.prix_reduit.HeaderText = "Prix reduit";
            this.prix_reduit.Name = "prix_reduit";
            // 
            // Quantite
            // 
            this.Quantite.DataPropertyName = "quantite";
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 605);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Prix avec remise";
            // 
            // txtprix_reduit
            // 
            this.txtprix_reduit.Location = new System.Drawing.Point(820, 593);
            this.txtprix_reduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtprix_reduit.Name = "txtprix_reduit";
            this.txtprix_reduit.ReadOnly = true;
            this.txtprix_reduit.Size = new System.Drawing.Size(323, 22);
            this.txtprix_reduit.TabIndex = 59;
            // 
            // btnremise
            // 
            this.btnremise.Location = new System.Drawing.Point(1024, 560);
            this.btnremise.Margin = new System.Windows.Forms.Padding(4);
            this.btnremise.Name = "btnremise";
            this.btnremise.Size = new System.Drawing.Size(119, 25);
            this.btnremise.TabIndex = 60;
            this.btnremise.Text = "Faire  la remise";
            this.btnremise.UseVisualStyleBackColor = true;
            this.btnremise.Click += new System.EventHandler(this.btnremise_Click_1);
            // 
            // txtlegers
            // 
            this.txtlegers.Location = new System.Drawing.Point(147, 633);
            this.txtlegers.Margin = new System.Windows.Forms.Padding(4);
            this.txtlegers.Name = "txtlegers";
            this.txtlegers.ReadOnly = true;
            this.txtlegers.Size = new System.Drawing.Size(95, 22);
            this.txtlegers.TabIndex = 61;
            this.txtlegers.Click += new System.EventHandler(this.txtlegers_Click);
            this.txtlegers.TextChanged += new System.EventHandler(this.txtlegers_TextChanged);
            this.txtlegers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlegers_KeyPress);
            // 
            // txttricycle
            // 
            this.txttricycle.Location = new System.Drawing.Point(444, 635);
            this.txttricycle.Margin = new System.Windows.Forms.Padding(4);
            this.txttricycle.Name = "txttricycle";
            this.txttricycle.ReadOnly = true;
            this.txttricycle.Size = new System.Drawing.Size(91, 22);
            this.txttricycle.TabIndex = 62;
            this.txttricycle.Click += new System.EventHandler(this.txttricycle_Click);
            // 
            // txtlourds
            // 
            this.txtlourds.Location = new System.Drawing.Point(147, 673);
            this.txtlourds.Margin = new System.Windows.Forms.Padding(4);
            this.txtlourds.Name = "txtlourds";
            this.txtlourds.ReadOnly = true;
            this.txtlourds.Size = new System.Drawing.Size(95, 22);
            this.txtlourds.TabIndex = 63;
            this.txtlourds.Click += new System.EventHandler(this.txtlourds_Click);
            // 
            // txtmoto
            // 
            this.txtmoto.Location = new System.Drawing.Point(444, 672);
            this.txtmoto.Margin = new System.Windows.Forms.Padding(4);
            this.txtmoto.Name = "txtmoto";
            this.txtmoto.ReadOnly = true;
            this.txtmoto.Size = new System.Drawing.Size(91, 22);
            this.txtmoto.TabIndex = 64;
            this.txtmoto.TabStop = false;
            this.txtmoto.Click += new System.EventHandler(this.txtmoto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 635);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "Vehicules legers";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(282, 635);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "Tricyle à moteur";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 677);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 17);
            this.label15.TabIndex = 67;
            this.label15.Text = " Poids lourds";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(285, 680);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 68;
            this.label16.Text = "Moto-cyclette";
            // 
            // cboclient
            // 
            this.cboclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclient.FormattingEnabled = true;
            this.cboclient.Location = new System.Drawing.Point(153, 252);
            this.cboclient.Margin = new System.Windows.Forms.Padding(4);
            this.cboclient.Name = "cboclient";
            this.cboclient.Size = new System.Drawing.Size(357, 24);
            this.cboclient.TabIndex = 44;
            this.cboclient.SelectedIndexChanged += new System.EventHandler(this.cboclient_SelectedIndexChanged);
            // 
            // btncalcul
            // 
            this.btncalcul.Location = new System.Drawing.Point(651, 661);
            this.btncalcul.Margin = new System.Windows.Forms.Padding(4);
            this.btncalcul.Name = "btncalcul";
            this.btncalcul.Size = new System.Drawing.Size(153, 36);
            this.btncalcul.TabIndex = 75;
            this.btncalcul.Text = "calcul du prix";
            this.btncalcul.UseVisualStyleBackColor = true;
            this.btncalcul.Click += new System.EventHandler(this.btncalcul_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 511);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 72;
            this.label9.Text = "Immatriculation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Immatriculation";
            // 
            // txtmarque
            // 
            this.txtmarque.Location = new System.Drawing.Point(139, 128);
            this.txtmarque.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarque.Name = "txtmarque";
            this.txtmarque.Size = new System.Drawing.Size(359, 22);
            this.txtmarque.TabIndex = 71;
            // 
            // txtimmatriculation
            // 
            this.txtimmatriculation.Location = new System.Drawing.Point(139, 80);
            this.txtimmatriculation.Margin = new System.Windows.Forms.Padding(4);
            this.txtimmatriculation.Name = "txtimmatriculation";
            this.txtimmatriculation.Size = new System.Drawing.Size(359, 22);
            this.txtimmatriculation.TabIndex = 73;
            // 
            // cbocategorie
            // 
            this.cbocategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategorie.FormattingEnabled = true;
            this.cbocategorie.Location = new System.Drawing.Point(140, 34);
            this.cbocategorie.Margin = new System.Windows.Forms.Padding(4);
            this.cbocategorie.Name = "cbocategorie";
            this.cbocategorie.Size = new System.Drawing.Size(359, 24);
            this.cbocategorie.TabIndex = 44;
            this.cbocategorie.SelectedIndexChanged += new System.EventHandler(this.cboclient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Categorie";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdure);
            this.groupBox1.Controls.Add(this.txtmarque);
            this.groupBox1.Controls.Add(this.txtimmatriculation);
            this.groupBox1.Controls.Add(this.cbocategorie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.cbosuivi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(8, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(527, 287);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 70;
            this.label11.Text = "Marque";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 223);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 70;
            this.label14.Text = "dure";
            // 
            // txtdure
            // 
            this.txtdure.Location = new System.Drawing.Point(139, 218);
            this.txtdure.Margin = new System.Windows.Forms.Padding(4);
            this.txtdure.Name = "txtdure";
            this.txtdure.Size = new System.Drawing.Size(363, 22);
            this.txtdure.TabIndex = 71;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(442, 248);
            this.btnok.Margin = new System.Windows.Forms.Padding(4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(60, 31);
            this.btnok.TabIndex = 53;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(820, 334);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 22);
            this.textBox2.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(647, 339);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 70;
            this.label17.Text = "Marque";
            // 
            // txtsejour
            // 
            this.txtsejour.Location = new System.Drawing.Point(820, 375);
            this.txtsejour.Margin = new System.Windows.Forms.Padding(4);
            this.txtsejour.Name = "txtsejour";
            this.txtsejour.Size = new System.Drawing.Size(323, 22);
            this.txtsejour.TabIndex = 73;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(648, 375);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 17);
            this.label18.TabIndex = 70;
            this.label18.Text = "Fais de sejour";
            // 
            // txtdeplacement
            // 
            this.txtdeplacement.Location = new System.Drawing.Point(820, 414);
            this.txtdeplacement.Margin = new System.Windows.Forms.Padding(4);
            this.txtdeplacement.Name = "txtdeplacement";
            this.txtdeplacement.Size = new System.Drawing.Size(323, 22);
            this.txtdeplacement.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(647, 419);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 17);
            this.label19.TabIndex = 70;
            this.label19.Text = "Frais de déplacement";
            // 
            // txtprix_suivi
            // 
            this.txtprix_suivi.Location = new System.Drawing.Point(820, 454);
            this.txtprix_suivi.Margin = new System.Windows.Forms.Padding(4);
            this.txtprix_suivi.Name = "txtprix_suivi";
            this.txtprix_suivi.ReadOnly = true;
            this.txtprix_suivi.Size = new System.Drawing.Size(323, 22);
            this.txtprix_suivi.TabIndex = 73;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(647, 459);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 17);
            this.label20.TabIndex = 70;
            this.label20.Text = "Prix du suivi";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(647, 535);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 17);
            this.label21.TabIndex = 22;
            this.label21.Text = "Prix Total";
            // 
            // txtprix_total
            // 
            this.txtprix_total.Location = new System.Drawing.Point(820, 526);
            this.txtprix_total.Margin = new System.Windows.Forms.Padding(4);
            this.txtprix_total.Name = "txtprix_total";
            this.txtprix_total.ReadOnly = true;
            this.txtprix_total.Size = new System.Drawing.Size(323, 22);
            this.txtprix_total.TabIndex = 28;
            this.txtprix_total.TextChanged += new System.EventHandler(this.txtprix_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(647, 298);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(122, 17);
            this.label22.TabIndex = 70;
            this.label22.Text = "Type d\'installation";
            // 
            // cbotype
            // 
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "Locale",
            "Nationale"});
            this.cbotype.Location = new System.Drawing.Point(820, 295);
            this.cbotype.Margin = new System.Windows.Forms.Padding(4);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(323, 24);
            this.cbotype.TabIndex = 44;
            this.cbotype.SelectedIndexChanged += new System.EventHandler(this.cboclient_SelectedIndexChanged);
            // 
            // frmCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 782);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncalcul);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtprix_suivi);
            this.Controls.Add(this.txtdeplacement);
            this.Controls.Add(this.txtsejour);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtmoto);
            this.Controls.Add(this.txtlourds);
            this.Controls.Add(this.txttricycle);
            this.Controls.Add(this.txtlegers);
            this.Controls.Add(this.btnremise);
            this.Controls.Add(this.txtprix_reduit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtremise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.cbotype);
            this.Controls.Add(this.cboclient);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtlieu);
            this.Controls.Add(this.txtprix_total);
            this.Controls.Add(this.txtprix_installation);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcommande";
            this.Load += new System.EventHandler(this.frmCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmarque;
        private System.Windows.Forms.TextBox txtimmatriculation;
        private System.Windows.Forms.ComboBox cbocategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_installation;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_suivi;
        private System.Windows.Forms.DataGridViewTextBoxColumn frais_sejour;
        private System.Windows.Forms.DataGridViewTextBoxColumn deplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_reduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtdure;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
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
    }
}