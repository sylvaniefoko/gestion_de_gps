using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPSGestionDesInstallationsGPS
{
    public partial class frmCreationCompte : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete;
        public frmCreationCompte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCreationCompte_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            requete = "select * from compte ";                   
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtlogin.Text = "";
            txtMotdepass.Text = "";
            txtconfirmer.Text = "";
            cboquestion.Text = "";
            txtreponse.Text = "";
            btnenregistrer.Enabled = true;
            btnAnnuler.Enabled = true;      
        }

        private void txtMotdepass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
                 


        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtconfirmer_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboquestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtreponse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (txtMotdepass.Text == txtconfirmer.Text)
            {
                requete = "INSERT INTO `compte` (`Nom`, `prenom`, `login`, `Mot_de_passe`, `question`, `reponse`) VALUES ('" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtlogin.Text + "','" + a.CryptageMD5(txtMotdepass.Text) + "','" + cboquestion.Text + "','" + a.CryptageMD5(txtreponse.Text) + "')";
                a.ExecuteRequette(requete);
                chargement();
                MessageBox.Show("enregistrement effectué avec succes");
            }
            else
            {
                MessageBox.Show("saisir le mot de pass correct");
            }

        }
    }
}
