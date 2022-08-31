using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace APPSGestionDesInstallationsGPS
{
    public partial class frmMotDePassOublie : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete="";

            public frmMotDePassOublie()
        {
                InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtreponse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            requete = "select login from compte where question='" + cboquestion.Text + "' and reponse='" + txtreponse.Text +"'";
            //string login = "";
            if (a.ResultatRequette(requete) == txtlogin.Text)
            {
                requete = "update Mot_de_passe='" + txtnouveau.Text +"' from compte where question='" + cboquestion.Text +"' and reponse='"+ txtreponse.Text +"' and login='" + txtlogin.Text +"'";
                a.ExecuteRequette(requete);
                chargement();
                AccesDonnees.confirmation = "mot de passe changer";
                frmConfirmation f = new frmConfirmation();
                f.ShowDialog();
            }
            else
            {
                AccesDonnees.erreur ="veuillez saisir une reponse correct" ;
                frmErreur f = new frmErreur();
                f.ShowDialog();
            }

        }

        private void frmMotDePassOublie_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            
            txtlogin.Text = "";
            txtnouveau.Text = "";
            txtreponse.Text = "";
            cboquestion.Text = "";
            btnEnregistrer.Enabled = true;
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
