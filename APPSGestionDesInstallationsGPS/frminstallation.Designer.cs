namespace APPSGestionDesInstallationsGPS
{
    partial class frmInstallation
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumerrogps = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbovehicule = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.btnmodifier2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtimei = new System.Windows.Forms.TextBox();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtcommercial = new System.Windows.Forms.TextBox();
            this.cboservice = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(911, 572);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(98, 25);
            this.btnFermer.TabIndex = 36;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.FlatAppearance.BorderSize = 0;
            this.btnannuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.Location = new System.Drawing.Point(495, 580);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(98, 25);
            this.btnannuler.TabIndex = 35;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.FlatAppearance.BorderSize = 0;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(148, 581);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(89, 25);
            this.btnmodifier.TabIndex = 34;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.AccessibleDescription = "";
            this.dtpDate.CalendarForeColor = System.Drawing.Color.CornflowerBlue;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(164, 282);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(291, 23);
            this.dtpDate.TabIndex = 29;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(16, 581);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(98, 25);
            this.btnEnregistrer.TabIndex = 33;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Date de l\'installation:";
            // 
            // txtnumerrogps
            // 
            this.txtnumerrogps.BackColor = System.Drawing.SystemColors.Info;
            this.txtnumerrogps.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerrogps.Location = new System.Drawing.Point(146, 78);
            this.txtnumerrogps.Name = "txtnumerrogps";
            this.txtnumerrogps.Size = new System.Drawing.Size(291, 24);
            this.txtnumerrogps.TabIndex = 24;
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
            this.groupBox1.Controls.Add(this.txtimei);
            this.groupBox1.Controls.Add(this.txtnumerrogps);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 200);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrer les GPS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbovehicule
            // 
            this.cbovehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovehicule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbovehicule.FormattingEnabled = true;
            this.cbovehicule.Location = new System.Drawing.Point(146, 39);
            this.cbovehicule.Name = "cbovehicule";
            this.cbovehicule.Size = new System.Drawing.Size(291, 26);
            this.cbovehicule.TabIndex = 27;
            this.cbovehicule.SelectedIndexChanged += new System.EventHandler(this.cbovehicule_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Véhicule:";
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(5, 168);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(42, 25);
            this.btnok.TabIndex = 21;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnmodifier2
            // 
            this.btnmodifier2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier2.Location = new System.Drawing.Point(347, 168);
            this.btnmodifier2.Name = "btnmodifier2";
            this.btnmodifier2.Size = new System.Drawing.Size(90, 25);
            this.btnmodifier2.TabIndex = 20;
            this.btnmodifier2.Text = "Modifier";
            this.btnmodifier2.UseVisualStyleBackColor = true;
            this.btnmodifier2.Click += new System.EventHandler(this.btnmodifer2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Numéro du  GPS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "IMEI du Gps:";
            // 
            // txtimei
            // 
            this.txtimei.BackColor = System.Drawing.SystemColors.Info;
            this.txtimei.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimei.Location = new System.Drawing.Point(146, 115);
            this.txtimei.Name = "txtimei";
            this.txtimei.Size = new System.Drawing.Size(291, 24);
            this.txtimei.TabIndex = 22;
            this.txtimei.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtimei_KeyPress);
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
            this.cbotechnicien.Location = new System.Drawing.Point(216, 15);
            this.cbotechnicien.Name = "cbotechnicien";
            this.cbotechnicien.Size = new System.Drawing.Size(286, 25);
            this.cbotechnicien.TabIndex = 11;
            // 
            // NOM_1
            // 
            this.NOM_1.AutoSize = true;
            this.NOM_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOM_1.Location = new System.Drawing.Point(15, 25);
            this.NOM_1.Name = "NOM_1";
            this.NOM_1.Size = new System.Drawing.Size(141, 17);
            this.NOM_1.TabIndex = 10;
            this.NOM_1.Text = "Nom du technicien 1:";
            this.NOM_1.Click += new System.EventHandler(this.NOM_1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.nom);
            this.groupBox2.Controls.Add(this.cboclient);
            this.groupBox2.Controls.Add(this.btntrier);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dtpdate2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(489, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 257);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sélectionner une commande";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(370, 222);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(57, 21);
            this.date.TabIndex = 4;
            this.date.Text = "Date";
            this.date.UseVisualStyleBackColor = true;
            this.date.CheckedChanged += new System.EventHandler(this.date_CheckedChanged);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(84, 220);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(113, 21);
            this.nom.TabIndex = 2;
            this.nom.Text = "Nom du client";
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
            this.cboclient.Location = new System.Drawing.Point(213, 218);
            this.cboclient.Name = "cboclient";
            this.cboclient.Size = new System.Drawing.Size(138, 25);
            this.cboclient.TabIndex = 3;
            this.cboclient.SelectedIndexChanged += new System.EventHandler(this.cboclient_SelectedIndexChanged);
            // 
            // btntrier
            // 
            this.btntrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrier.Location = new System.Drawing.Point(6, 214);
            this.btntrier.Name = "btntrier";
            this.btntrier.Size = new System.Drawing.Size(72, 31);
            this.btntrier.TabIndex = 1;
            this.btntrier.Text = "Trier ";
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
            this.quantite,
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(13, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(546, 187);
            this.dataGridView2.TabIndex = 0;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "prix_total";
            this.Column1.HeaderText = "prix du service";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // dtpdate2
            // 
            this.dtpdate2.AccessibleDescription = "";
            this.dtpdate2.CustomFormat = "yyyy-MM-dd";
            this.dtpdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate2.Location = new System.Drawing.Point(438, 222);
            this.dtpdate2.Name = "dtpdate2";
            this.dtpdate2.Size = new System.Drawing.Size(116, 23);
            this.dtpdate2.TabIndex = 5;
            this.dtpdate2.ValueChanged += new System.EventHandler(this.dtpdate2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 30;
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
            this.cbostatut.Location = new System.Drawing.Point(164, 236);
            this.cbostatut.Name = "cbostatut";
            this.cbostatut.Size = new System.Drawing.Size(291, 25);
            this.cbostatut.TabIndex = 31;
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
            this.id_installation,
            this.id_commande,
            this.id_technicien1,
            this.id_technicien2,
            this.id_technicien3,
            this.id_technicien4,
            this.id_technicien5,
            this.statut,
            this.date_installation});
            this.dataGridView1.Location = new System.Drawing.Point(13, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 188);
            this.dataGridView1.TabIndex = 32;
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
            this.cbotechnicien2.Location = new System.Drawing.Point(216, 55);
            this.cbotechnicien2.Name = "cbotechnicien2";
            this.cbotechnicien2.Size = new System.Drawing.Size(286, 25);
            this.cbotechnicien2.TabIndex = 13;
            // 
            // Nom_2
            // 
            this.Nom_2.AutoSize = true;
            this.Nom_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_2.Location = new System.Drawing.Point(15, 66);
            this.Nom_2.Name = "Nom_2";
            this.Nom_2.Size = new System.Drawing.Size(141, 17);
            this.Nom_2.TabIndex = 12;
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
            this.cbotechnicien3.Location = new System.Drawing.Point(216, 95);
            this.cbotechnicien3.Name = "cbotechnicien3";
            this.cbotechnicien3.Size = new System.Drawing.Size(286, 25);
            this.cbotechnicien3.TabIndex = 15;
            // 
            // Nom_3
            // 
            this.Nom_3.AutoSize = true;
            this.Nom_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_3.Location = new System.Drawing.Point(15, 103);
            this.Nom_3.Name = "Nom_3";
            this.Nom_3.Size = new System.Drawing.Size(141, 17);
            this.Nom_3.TabIndex = 14;
            this.Nom_3.Text = "Nom du technicien 3:";
            // 
            // Nom_4
            // 
            this.Nom_4.AutoSize = true;
            this.Nom_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_4.Location = new System.Drawing.Point(15, 137);
            this.Nom_4.Name = "Nom_4";
            this.Nom_4.Size = new System.Drawing.Size(141, 17);
            this.Nom_4.TabIndex = 16;
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
            this.cbotechnicien4.Location = new System.Drawing.Point(216, 129);
            this.cbotechnicien4.Name = "cbotechnicien4";
            this.cbotechnicien4.Size = new System.Drawing.Size(286, 25);
            this.cbotechnicien4.TabIndex = 17;
            // 
            // Nom_5
            // 
            this.Nom_5.AutoSize = true;
            this.Nom_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom_5.Location = new System.Drawing.Point(15, 175);
            this.Nom_5.Name = "Nom_5";
            this.Nom_5.Size = new System.Drawing.Size(141, 17);
            this.Nom_5.TabIndex = 18;
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
            this.cbotechnicien5.Location = new System.Drawing.Point(216, 175);
            this.cbotechnicien5.Name = "cbotechnicien5";
            this.cbotechnicien5.Size = new System.Drawing.Size(286, 25);
            this.cbotechnicien5.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(499, 325);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(147, 18);
            this.label18.TabIndex = 8;
            this.label18.Text = "Nom du commercial:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(499, 282);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 18);
            this.label19.TabIndex = 6;
            this.label19.Text = "Type de service:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtcommercial
            // 
            this.txtcommercial.BackColor = System.Drawing.SystemColors.Info;
            this.txtcommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcommercial.Location = new System.Drawing.Point(718, 319);
            this.txtcommercial.Name = "txtcommercial";
            this.txtcommercial.Size = new System.Drawing.Size(286, 24);
            this.txtcommercial.TabIndex = 9;
            this.txtcommercial.TextChanged += new System.EventHandler(this.txtcommercial_TextChanged);
            // 
            // cboservice
            // 
            this.cboservice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboservice.FormattingEnabled = true;
            this.cboservice.Items.AddRange(new object[] {
            "Installation",
            "Installation et suivi"});
            this.cboservice.Location = new System.Drawing.Point(719, 282);
            this.cboservice.Name = "cboservice";
            this.cboservice.Size = new System.Drawing.Size(285, 25);
            this.cboservice.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbotechnicien3);
            this.groupBox3.Controls.Add(this.NOM_1);
            this.groupBox3.Controls.Add(this.cbotechnicien);
            this.groupBox3.Controls.Add(this.Nom_2);
            this.groupBox3.Controls.Add(this.cbotechnicien5);
            this.groupBox3.Controls.Add(this.cbotechnicien2);
            this.groupBox3.Controls.Add(this.Nom_5);
            this.groupBox3.Controls.Add(this.Nom_3);
            this.groupBox3.Controls.Add(this.cbotechnicien4);
            this.groupBox3.Controls.Add(this.Nom_4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(502, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 208);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enregistrer les techniciens";
            // 
            // frmInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 625);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtcommercial);
            this.Controls.Add(this.cboservice);
            this.Controls.Add(this.cbostatut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnEnregistrer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstallation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enregistrement des installations";
            this.Load += new System.EventHandler(this.frminstallation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dtpdate2;
        private System.Windows.Forms.TextBox txtimei;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtcommercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vehicule;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_commande;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cboservice;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}