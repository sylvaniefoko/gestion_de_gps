namespace APPSGestionDesInstallationsGPS
{
    partial class frmCreationCompte
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtMotdepass = new System.Windows.Forms.TextBox();
            this.txtconfirmer = new System.Windows.Forms.TextBox();
            this.txtreponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cboquestion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(45, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.label2.Location = new System.Drawing.Point(45, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.label3.Location = new System.Drawing.Point(45, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.label5.Location = new System.Drawing.Point(45, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirmer le mot de pass";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.label7.Location = new System.Drawing.Point(45, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "reponse";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNom.Location = new System.Drawing.Point(234, 141);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(239, 22);
            this.txtNom.TabIndex = 7;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrenom.Location = new System.Drawing.Point(234, 188);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(239, 22);
            this.txtPrenom.TabIndex = 8;
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtlogin.Location = new System.Drawing.Point(234, 232);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(239, 22);
            this.txtlogin.TabIndex = 9;
            this.txtlogin.TextChanged += new System.EventHandler(this.txtlogin_TextChanged);
            // 
            // txtMotdepass
            // 
            this.txtMotdepass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMotdepass.Location = new System.Drawing.Point(234, 276);
            this.txtMotdepass.Name = "txtMotdepass";
            this.txtMotdepass.Size = new System.Drawing.Size(239, 22);
            this.txtMotdepass.TabIndex = 10;
            this.txtMotdepass.UseSystemPasswordChar = true;
            this.txtMotdepass.TextChanged += new System.EventHandler(this.txtMotdepass_TextChanged);
            // 
            // txtconfirmer
            // 
            this.txtconfirmer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtconfirmer.Location = new System.Drawing.Point(234, 315);
            this.txtconfirmer.Name = "txtconfirmer";
            this.txtconfirmer.Size = new System.Drawing.Size(239, 22);
            this.txtconfirmer.TabIndex = 11;
            this.txtconfirmer.UseSystemPasswordChar = true;
            this.txtconfirmer.TextChanged += new System.EventHandler(this.txtconfirmer_TextChanged);
            // 
            // txtreponse
            // 
            this.txtreponse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtreponse.Location = new System.Drawing.Point(234, 396);
            this.txtreponse.Name = "txtreponse";
            this.txtreponse.Size = new System.Drawing.Size(239, 22);
            this.txtreponse.TabIndex = 13;
            this.txtreponse.UseSystemPasswordChar = true;
            this.txtreponse.TextChanged += new System.EventHandler(this.txtreponse_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(45, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de pass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.label6.Location = new System.Drawing.Point(45, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Question de securite";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(326, 445);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(147, 42);
            this.btnAnnuler.TabIndex = 15;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cboquestion
            // 
            this.cboquestion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cboquestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboquestion.FormattingEnabled = true;
            this.cboquestion.ItemHeight = 16;
            this.cboquestion.Items.AddRange(new object[] {
            "Dans quelle ville se sont rencontrés vos parents ?",
            "Quel est le nom de famille de votre professeur denfance prefere ?"});
            this.cboquestion.Location = new System.Drawing.Point(234, 359);
            this.cboquestion.MaxDropDownItems = 10;
            this.cboquestion.Name = "cboquestion";
            this.cboquestion.Size = new System.Drawing.Size(239, 24);
            this.cboquestion.TabIndex = 16;
            this.cboquestion.SelectedIndexChanged += new System.EventHandler(this.cboquestion_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(75, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 39);
            this.label8.TabIndex = 17;
            this.label8.Text = "Créer un compte";
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(21)))), ((int)(((byte)(173)))));
            this.btnenregistrer.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrchid;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.White;
            this.btnenregistrer.Location = new System.Drawing.Point(48, 454);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(147, 42);
            this.btnenregistrer.TabIndex = 15;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // frmCreationCompte
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 525);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboquestion);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.txtreponse);
            this.Controls.Add(this.txtconfirmer);
            this.Controls.Add(this.txtMotdepass);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreationCompte";
            this.Text = "frmcompte";
            this.Load += new System.EventHandler(this.frmCreationCompte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtMotdepass;
        private System.Windows.Forms.TextBox txtconfirmer;
        private System.Windows.Forms.TextBox txtreponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cboquestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnenregistrer;
    }
}