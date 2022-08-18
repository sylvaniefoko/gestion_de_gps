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
    public partial class frmConnexion : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete="";
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            txtmotpass.Text = "";
            txtlogin.Text = "";
            btnlogin.Enabled = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            requete = "SELECT id_compte FROM compte WHERE Mot_de_passe='" + a.CryptageMD5(txtmotpass.Text) + "' and  login='"+txtlogin.Text+"'";
            if (a.ResultatRequette1(requete) !=0) 
            {
                frmMenu f = new frmMenu();
                f.ShowDialog();
                MessageBox.Show("connexion reussi");     

            }
            else
            {
                MessageBox.Show("saisissez un mot de passe ou un nom d'utilisteur correct");
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMotDePassOublie f = new frmMotDePassOublie();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtmotpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCreationCompte f = new frmCreationCompte();
            f.ShowDialog();
        }
    }
}
