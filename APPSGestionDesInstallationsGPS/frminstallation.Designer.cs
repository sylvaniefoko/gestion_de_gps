namespace APPSGestionDesInstallationsGPS
{
    partial class frminstallation
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnumerrogps = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbovehicule = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.btnmodifier2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotechnicien = new System.Windows.Forms.ComboBox();
            this.NOM_1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.CheckBox();
            this.nom = new System.Windows.Forms.CheckBox();
            this.cboclient = new System.Windows.Forms.ComboBox();
            this.btntrier = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_vehicule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpdate2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbostatut = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_installation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_commande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_technicien1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_technicien2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_technicien3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_technicien4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_technicien5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_installation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbotechnicien2 = new System.Windows.Forms.ComboBox();
            this.Nom_2 = new System.Windows.Forms.Label();
            this.cbotechnicien3 = new System.Windows.Forms.ComboBox();
            this.Nom_3 = new System.Windows.Forms.Label();
            this.Nom_4 = new System.Windows.Forms.Label();
            this.cbotechnicien4 = new System.Windows.Forms.ComboBox();
            this.Nom_5 = new System.Windows.Forms.Label();
            this.cbotechnicien5 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(925, 588);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(131, 31);
            this.btnFermer.TabIndex = 89;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(628, 588);
            this.btnannuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(131, 31);
            this.btnannuler.TabIndex = 88;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(327, 588);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(131, 31);
            this.btnmodifier.TabIndex = 87;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.AccessibleDescription = "";
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(167, 283);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(289, 27);
            this.dtpDate.TabIndex = 83;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(24, 588);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(131, 31);
            this.btnEnregistrer.TabIndex = 82;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 281);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Date installation:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Info;
            this.txtemail.Location = new System.Drawing.Point(151, 145);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(289, 27);
            this.txtemail.TabIndex = 90;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // txtnumerrogps
            // 
            this.txtnumerrogps.BackColor = System.Drawing.SystemColors.Info;
            this.txtnumerrogps.Location = new System.Drawing.Point(151, 101);
            this.txtnumerrogps.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumerrogps.Name = "txtnumerrogps";
            this.txtnumerrogps.Size = new System.Drawing.Size(289, 27);
            this.txtnumerrogps.TabIndex = 92;
            this.txtnumerrogps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumerrogps_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbovehicule);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnok);
            this.groupBox1.Controls.Add(this.btnmodifier2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtnumerrogps);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 329);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(459, 228);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbovehicule
            // 
            this.cbovehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovehicule.FormattingEnabled = true;
            this.cbovehicule.Location = new System.Drawing.Point(151, 53);
            this.cbovehicule.Margin = new System.Windows.Forms.Padding(4);
            this.cbovehicule.Name = "cbovehicule";
            this.cbovehicule.Size = new System.Drawing.Size(289, 28);
            this.cbovehicule.TabIndex = 101;
            this.cbovehicule.SelectedIndexChanged += new System.EventHandler(this.cbovehicule_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Vehicule:";
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(12, 191);
            this.btnok.Margin = new System.Windows.Forms.Padding(4);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(56, 31);
            this.btnok.TabIndex = 95;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnmodifier2
            // 
            this.btnmodifier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier2.Location = new System.Drawing.Point(322, 191);
            this.btnmodifier2.Margin = new System.Windows.Forms.Padding(4);
            this.btnmodifier2.Name = "btnmodifier2";
            this.btnmodifier2.Size = new System.Drawing.Size(120, 31);
            this.btnmodifier2.TabIndex = 95;
            this.btnmodifier2.Text = "Modifier";
            this.btnmodifier2.UseVisualStyleBackColor = true;
            this.btnmodifier2.Click += new System.EventHandler(this.btnmodifer2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 94;
            this.label2.Text = "Numero GPS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 93;
            this.label1.Text = "IMEI Gps:";
            // 
            // cbotechnicien
            // 
            this.cbotechnicien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotechnicien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotechnicien.FormattingEnabled = true;
            this.cbotechnicien.Items.AddRange(new object[] {
            "En Cours",
            "Stand By",
            "Terminer",
            "Non Fait"});
            this.cbotechnicien.Location = new System.Drawing.Point(779, 332);
            this.cbotechnicien.Margin = new System.Windows.Forms.Padding(4);
            this.cbotechnicien.Name = "cbotechnicien";
            this.cbotechnicien.Size = new System.Drawing.Size(363, 28);
            this.cbotechnicien.TabIndex = 100;
            // 
            // NOM_1
            // 
            this.NOM_1.AutoSize = true;
            this.NOM_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_1.Location = new System.Drawing.Point(585, 340);
            this.NOM_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NOM_1.Name = "NOM_1";
            this.NOM_1.Size = new System.Drawing.Size(167, 20);
            this.NOM_1.TabIndex = 96;
            this.NOM_1.Text = "Nom du technicien 1:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.nom);
            this.groupBox2.Controls.Add(this.cboclient);
            this.groupBox2.Controls.Add(this.btntrier);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dtpdate2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(615, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(541, 286);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selctionner une commande";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(156, 256);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(67, 24);
            this.date.TabIndex = 104;
            this.date.Text = "Date";
            this.date.UseVisualStyleBackColor = true;
            this.date.CheckedChanged += new System.EventHandler(this.date_CheckedChanged);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(156, 222);
            this.nom.Margin = new System.Windows.Forms.Padding(4);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(111, 24);
            this.nom.TabIndex = 103;
            this.nom.Text = "Nom client";
            this.nom.UseVisualStyleBackColor = true;
            this.nom.CheckedChanged += new System.EventHandler(this.nom_CheckedChanged);
            // 
            // cboclient
            // 
            this.cboclient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboclient.FormattingEnabled = true;
            this.cboclient.Items.AddRange(new object[] {
            "En Cours",
            "Stand By",
            "Terminer",
            "Non Fait"});
            this.cboclient.Location = new System.Drawing.Point(302, 215);
            this.cboclient.Margin = new System.Windows.Forms.Padding(4);
            this.cboclient.Name = "cboclient";
            this.cboclient.Size = new System.Drawing.Size(216, 28);
            this.cboclient.TabIndex = 99;
            this.cboclient.SelectedIndexChanged += new System.EventHandler(this.cboclient_SelectedIndexChanged);
            // 
            // btntrier
            // 
            this.btntrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrier.Location = new System.Drawing.Point(13, 222);
            this.btntrier.Margin = new System.Windows.Forms.Padding(4);
            this.btntrier.Name = "btntrier";
            this.btntrier.Size = new System.Drawing.Size(103, 31);
            this.btntrier.TabIndex = 100;
            this.btntrier.Text = "Trier par";
            this.btntrier.UseVisualStyleBackColor = true;
            this.btntrier.Click += new System.EventHandler(this.btntrier_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vehicule,
            this.id_client,
            this.Nom_client,
            this.date_commande,
            this.lieu,
            this.quantite});
            this.dataGridView2.Location = new System.Drawing.Point(17, 23);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(507, 185);
            this.dataGridView2.TabIndex = 58;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // id_vehicule
            // 
            this.id_vehicule.DataPropertyName = "id_commande";
            this.id_vehicule.HeaderText = "id_commande";
            this.id_vehicule.Name = "id_vehicule";
            this.id_vehicule.Visible = false;
            // 
            // id_client
            // 
            this.id_client.DataPropertyName = "id_client";
            this.id_client.HeaderText = "id_client";
            this.id_client.Name = "id_client";
            this.id_client.Visible = false;
            // 
            // Nom_client
            // 
            this.Nom_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom_client.DataPropertyName = "concat(nom,\' \',prenom)";
            this.Nom_client.HeaderText = "Nom du client";
            this.Nom_client.Name = "Nom_client";
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
            // quantite
            // 
            this.quantite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantite.DataPropertyName = "quantite";
            this.quantite.HeaderText = "Quantite";
            this.quantite.Name = "quantite";
            // 
            // dtpdate2
            // 
            this.dtpdate2.AccessibleDescription = "";
            this.dtpdate2.CustomFormat = "yyyy-MM-dd";
            this.dtpdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate2.Location = new System.Drawing.Point(302, 254);
            this.dtpdate2.Margin = new System.Windows.Forms.Padding(4);
            this.dtpdate2.Name = "dtpdate2";
            this.dtpdate2.Size = new System.Drawing.Size(216, 27);
            this.dtpdate2.TabIndex = 83;
            this.dtpdate2.ValueChanged += new System.EventHandler(this.dtpdate2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 98;
            this.label7.Text = "statut:";
            // 
            // cbostatut
            // 
            this.cbostatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbostatut.FormattingEnabled = true;
            this.cbostatut.Items.AddRange(new object[] {
            "En Cours",
            "Stand By",
            "Terminer",
            "Non Fait"});
            this.cbostatut.Location = new System.Drawing.Point(167, 238);
            this.cbostatut.Margin = new System.Windows.Forms.Padding(4);
            this.cbostatut.Name = "cbostatut";
            this.cbostatut.Size = new System.Drawing.Size(289, 30);
            this.cbostatut.TabIndex = 99;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_installation,
            this.id_commande,
            this.id_technicien1,
            this.id_technicien2,
            this.id_technicien3,
            this.id_technicien4,
            this.id_technicien5,
            this.statut,
            this.date_installation});
            this.dataGridView1.Location = new System.Drawing.Point(17, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 208);
            this.dataGridView1.TabIndex = 95;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id_installation
            // 
            this.id_installation.DataPropertyName = "id_installation";
            this.id_installation.HeaderText = "id_installation";
            this.id_installation.Name = "id_installation";
            this.id_installation.Visible = false;
            // 
            // id_commande
            // 
            this.id_commande.DataPropertyName = "id_commande";
            this.id_commande.HeaderText = "id_commande";
            this.id_commande.Name = "id_commande";
            this.id_commande.Visible = false;
            // 
            // id_technicien1
            // 
            this.id_technicien1.DataPropertyName = "id_technicien1";
            this.id_technicien1.HeaderText = "id_technicien1";
            this.id_technicien1.Name = "id_technicien1";
            this.id_technicien1.Visible = false;
            // 
            // id_technicien2
            // 
            this.id_technicien2.DataPropertyName = "id_technicien2";
            this.id_technicien2.HeaderText = "id_technicien2";
            this.id_technicien2.Name = "id_technicien2";
            this.id_technicien2.Visible = false;
            // 
            // id_technicien3
            // 
            this.id_technicien3.DataPropertyName = "id_technicien3";
            this.id_technicien3.HeaderText = "id_technicien3";
            this.id_technicien3.Name = "id_technicien3";
            this.id_technicien3.Visible = false;
            // 
            // id_technicien4
            // 
            this.id_technicien4.DataPropertyName = "id_technicien4";
            this.id_technicien4.HeaderText = "id_technicien4";
            this.id_technicien4.Name = "id_technicien4";
            this.id_technicien4.Visible = false;
            // 
            // id_technicien5
            // 
            this.id_technicien5.DataPropertyName = "id_technicien5";
            this.id_technicien5.HeaderText = "id_technicien5";
            this.id_technicien5.Name = "id_technicien5";
            this.id_technicien5.Visible = false;
            // 
            // statut
            // 
            this.statut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statut.DataPropertyName = "statut";
            this.statut.HeaderText = "Statut";
            this.statut.Name = "statut";
            // 
            // date_installation
            // 
            this.date_installation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date_installation.DataPropertyName = "date_installation";
            this.date_installation.HeaderText = "Date de l\'installation";
            this.date_installation.Name = "date_installation";
            // 
            // cbotechnicien2
            // 
            this.cbotechnicien2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotechnicien2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotechnicien2.FormattingEnabled = true;
            this.cbotechnicien2.Items.AddRange(new object[] {
            "En Cours",
            "Stand By",
            "Terminer",
            "Non Fait"});
            this.cbotechnicien2.Location = new System.Drawing.Point(779, 375);
            this.cbotechnicien2.Margin = new System.Windows.Forms.Padding(4);
            this.cbotechnicien2.Name = "cbotechnicien2";
            this.cbotechnicien2.Size = new System.Drawing.Size(363, 28);
            this.cbotechnicien2.TabIndex = 102;
            // 
            // Nom_2
            // 
            this.Nom_2.AutoSize = true;
            this.Nom_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_2.Location = new System.Drawing.Point(586, 383);
            this.Nom_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom_2.Name = "Nom_2";
            this.Nom_2.Size = new System.Drawing.Size(167, 20);
            this.Nom_2.TabIndex = 101;
            this.Nom_2.Text = "Nom du technicien 2:";
            // 
            // cbotechnicien3
            // 
            this.cbotechnicien3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotechnicien3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotechnicien3.FormattingEnabled = true;
            this.cbotechnicien3.Items.AddRange(new object[] {
            "En Cours",
            "Stand By",
            "Terminer",
            "Non Fait"});
            this.cbotechnicien3.Location = new System.Drawing.Point(779, 420);
            this.cbotechnicien3.Margin = new System.Windows.Forms.Padding(4);
            this.cbotechnicien3.Name = "cbotechnicien3";
            this.cbotechnicien3.Size = new System.Drawing.Size(363, 28);
            this.cbotechnicien3.TabIndex = 104;
            // 
            // Nom_3
            // 
            this.Nom_3.AutoSize = true;
            this.Nom_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_3.Location = new System.Drawing.Point(586, 426);
            this.Nom_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom_3.Name = "Nom_3";
            this.Nom_3.Size = new System.Drawing.Size(167, 20);
            this.Nom_3.TabIndex = 103;
            this.Nom_3.Text = "Nom du technicien 3:";
            // 
            // Nom_4
            // 
            this.Nom_4.AutoSize = true;
            this.Nom_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_4.Location = new System.Drawing.Point(586, 478);
            this.Nom_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom_4.Name = "Nom_4";
            this.Nom_4.Size = new System.Drawing.Size(167, 20);
            this.Nom_4.TabIndex = 103;
            this.Nom_4.Text = "Nom du technicien 4:";
            // 
            // cbotechnicien4
            // 
            this.cbotechnicien4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotechnicien4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotechnicien4.FormattingEnabled = true;
            this.cbotechnicien4.Items.AddRange(new object[] {
            "En Cours",
            "Stand By",
            "Terminer",
            "Non Fait"});
            this.cbotechnicien4.Location = new System.Drawing.Point(776, 473);
            this.cbotechnicien4.Margin = new System.Windows.Forms.Padding(4);
            this.cbotechnicien4.Name = "cbotechnicien4";
            this.cbotechnicien4.Size = new System.Drawing.Size(363, 28);
            this.cbotechnicien4.TabIndex = 104;
            // 
            // Nom_5
            // 
            this.Nom_5.AutoSize = true;
            this.Nom_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_5.Location = new System.Drawing.Point(586, 531);
            this.Nom_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom_5.Name = "Nom_5";
            this.Nom_5.Size = new System.Drawing.Size(167, 20);
            this.Nom_5.TabIndex = 103;
            this.Nom_5.Text = "Nom du technicien 5:";
            // 
            // cbotechnicien5
            // 
            this.cbotechnicien5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotechnicien5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotechnicien5.FormattingEnabled = true;
            this.cbotechnicien5.Items.AddRange(new object[] {
            "En Cours",
            "Stand By",
            "Terminer",
            "Non Fait"});
            this.cbotechnicien5.Location = new System.Drawing.Point(779, 524);
            this.cbotechnicien5.Margin = new System.Windows.Forms.Padding(4);
            this.cbotechnicien5.Name = "cbotechnicien5";
            this.cbotechnicien5.Size = new System.Drawing.Size(363, 28);
            this.cbotechnicien5.TabIndex = 104;
            // 
            // frminstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 645);
            this.Controls.Add(this.cbotechnicien5);
            this.Controls.Add(this.Nom_5);
            this.Controls.Add(this.cbotechnicien4);
            this.Controls.Add(this.Nom_4);
            this.Controls.Add(this.cbotechnicien3);
            this.Controls.Add(this.Nom_3);
            this.Controls.Add(this.cbotechnicien2);
            this.Controls.Add(this.Nom_2);
            this.Controls.Add(this.cbotechnicien);
            this.Controls.Add(this.cbostatut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NOM_1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnEnregistrer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frminstallation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frminstallation";
            this.Load += new System.EventHandler(this.frminstallation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnumerrogps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnmodifier2;
        private System.Windows.Forms.Label NOM_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbostatut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbotechnicien;
        private System.Windows.Forms.ComboBox cbovehicule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbotechnicien2;
        private System.Windows.Forms.Label Nom_2;
        private System.Windows.Forms.ComboBox cbotechnicien3;
        private System.Windows.Forms.Label Nom_3;
        private System.Windows.Forms.Label Nom_4;
        private System.Windows.Forms.ComboBox cbotechnicien4;
        private System.Windows.Forms.Label Nom_5;
        private System.Windows.Forms.ComboBox cbotechnicien5;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_installation;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_technicien1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_technicien2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_technicien3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_technicien4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_technicien5;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_installation;
        private System.Windows.Forms.CheckBox date;
        private System.Windows.Forms.CheckBox nom;
        private System.Windows.Forms.ComboBox cboclient;
        private System.Windows.Forms.Button btntrier;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DateTimePicker dtpdate2;
    }
}