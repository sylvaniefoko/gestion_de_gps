using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;

namespace APPSGestionDesInstallationsGPS
{
    public partial class frmCommande : Form
    {
        AccesDonnees a = new AccesDonnees();
        int idclient,commande, i, prixsuivi ,dure = 0;
        double p_remiser, remise, Prix_total, prix_poids_lourds, prix_vehicule_legers, prix_moto, prix_tricycle,
        Quantite_moto, Quantite_poids_lourds, Quantite_vehicule_legers, compte_vehicule, Prix_suivi,Prix_installation,
        Quantite_tricycle = 0;
        string requete = "";
        string[] marquevehicule = new string [100];
        string[] immatriculationvehicule = new string[100];
        int[] categorievehicule = new int[100];
        string[] durer = new string[100];
        int[] tab_suivi = new int[100];
        int compteur_vehicule = 0;
        
        public frmCommande()
        {
            InitializeComponent();
        }

        private void frmCommande_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            requete = "select categorie_vehicule from Cat_vehicule ";
            a.ChargeCombo(cbocategorie, requete);
            requete = "select * from commande";
            a.ChargeTable(dataGridView1, requete);
            requete = "SELECT concat(Nom,' ',prenom) FROM client";
            a.ChargeCombo(cboclient, requete);
            txtlegers.Text = "";
            txtlourds.Text = "";
            txtmoto.Text = "";
            txtprix_installation.Text = "";
            txttricycle.Text = "";
            txtmarque.Text = "";
            txtimmatriculation.Text = "";
            txtlieu.Text = "";
            dtpDate.Text = "";
            txtprix_reduit.Text = "";
            btnEnregistrer.Enabled = false;
            btnmodifier.Enabled = false;
            txtremise.Text = "";
            requete = "select type_suivi from suivi ";
            a.ChargeCombo(cbosuivi, requete);
        }


        private void txtprix_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtlegers_Click(object sender, EventArgs e)
        {
        }

        private void txttricycle_Click(object sender, EventArgs e)
        {

        }

        private void txtlourds_Click(object sender, EventArgs e)
        {

        }

        private void txtmoto_Click(object sender, EventArgs e)
        {
        }


        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            
        }
     
        private void btncalcul_Click_1(object sender, EventArgs e)
        {
            requete = "select prix_installation from Cat_vehicule where categorie_vehicule='Poids lourds'";
            prix_poids_lourds = a.ResultatRequette1(requete);
            requete = "select prix_installation from Cat_vehicule where categorie_vehicule='Vehicule legers' ";
            prix_vehicule_legers = a.ResultatRequette1(requete);
            requete = "select prix_installation from Cat_vehicule where categorie_vehicule='Moto cyclette'";
            prix_moto = a.ResultatRequette1(requete);
            requete = "select prix_installation from Cat_vehicule where categorie_vehicule='Tricycle a moteur'";
            prix_tricycle = a.ResultatRequette1(requete);
            Quantite_de_chaque_vehicule();
            if (txtlegers.Text == "") {
                Quantite_vehicule_legers = 0;
            }
            if (txtlourds.Text == "") {
                Quantite_poids_lourds = 0;
            } 
            if (txttricycle.Text == "") {
                Quantite_tricycle = 0;
            } 
            if (txtmoto.Text == "") {
                Quantite_moto = 0;
            } 
            prix_poids_lourds = prix_poids_lourds * Quantite_poids_lourds;
            prix_vehicule_legers = prix_vehicule_legers * Quantite_vehicule_legers;
            prix_moto = prix_moto * Quantite_moto;
            prix_tricycle = prix_tricycle * Quantite_tricycle;
            Prix_installation = prix_poids_lourds + prix_vehicule_legers + prix_moto + prix_tricycle+Convert.ToDouble(txtsejour.Text)+Convert.ToDouble(txtdeplacement.Text);
            compte_vehicule = Quantite_tricycle + Quantite_vehicule_legers + Quantite_poids_lourds + Quantite_moto;            
            if (cbosuivi.Text != "") {
                txtprix_installation.Text = (Prix_installation).ToString();
                txtprix_suivi.Text =(prixsuivi).ToString();
                txtprix_total.Text = (Prix_suivi + Prix_installation).ToString();
                btnEnregistrer.Enabled = true;
            } else {
                MessageBox.Show("remplir le champ suivi");
            }       
        }

        private void txtlegers_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
           
            requete = "select id_client from client where concat(Nom,' ',Prenom)='" + cboclient.Text + "'";
            idclient = a.ResultatRequette1(requete);
            requete = "INSERT INTO `commande`( `id_client`, `Date_commande`, `lieu`,  `prix`,`prix_reduit`,`quantite`) VALUES('" + idclient + "','" + a.date_vers_mysql(dtpDate.Text) + "','" + txtlieu.Text + "','" + txtprix_installation.Text + "','" + txtprix_reduit.Text + "','" + compte_vehicule + "')";
            a.ExecuteRequette(requete);
            requete = "SELECT `id_commande` FROM `commande` WHERE  `id_client`='" + idclient + "' and `Date_commande`='" + a.date_vers_mysql(dtpDate.Text) + "' and `lieu`='" + txtlieu.Text + "' and   `prix`='" + txtprix_installation.Text + "' and `prix_reduit`='" + txtprix_reduit.Text + "' and  `quantite`='" + compte_vehicule + "'";
            int id_commande = a.ResultatRequette1(requete);
            for (int i= 0; i <= compteur_vehicule-1; i++)
            {
                requete = "insert into vehicule (immatriculation_vehicule,marque_vehicule,id_catvehicule,id_commande) values ('" + marquevehicule[i] + "','" + immatriculationvehicule[i] + "','" + categorievehicule[i] + "','" + id_commande + "')";
                a.ExecuteRequette(requete);
            }
            compte_vehicule = 0;
            chargement();
            Prix_total = 0;
            Prix_installation = 0;
            Prix_suivi = 0;
        }

        private void dtpDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtlegers_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        void Quantite_de_chaque_vehicule()
        {
            if (cbocategorie.Text == "Poids lourds")
            {
                Quantite_poids_lourds++;
                txtlourds.Text = (Quantite_poids_lourds).ToString();
            }
            if (cbocategorie.Text == "Vehicule legers")
            {
                Quantite_vehicule_legers++;
                txtlegers.Text = (Quantite_vehicule_legers).ToString();
            }
            if (cbocategorie.Text == "Tricycle a moteur")
            {
                Quantite_tricycle++;
                txttricycle.Text = (Quantite_tricycle).ToString();
            }
            if (cbocategorie.Text == "Moto cyclette")
            {
                Quantite_moto++;
                txtmoto.Text = (Quantite_moto).ToString();
            }
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            categorievehicule[compteur_vehicule] = a.ResultatRequette1("SELECT `id_catvehicule` FROM `cat_vehicule` WHERE `categorie_vehicule`='" + cbocategorie.Text + "'");
            marquevehicule[compteur_vehicule] = txtmarque.Text;
            immatriculationvehicule[compteur_vehicule] = txtimmatriculation.Text;
            tab_suivi[compteur_vehicule] = a.ResultatRequette1("select id_suivi from suivi where type_suivi='"+cbosuivi.Text+"'");
            durer[compteur_vehicule] = txtdure.Text;
            dure = dure + Convert.ToInt16(txtdure.Text);
            prixsuivi = prixsuivi + a.ResultatRequette1("select prix_suivi from suivi where type_suivi='" + cbosuivi.Text + "'") ;
            prixsuivi = prixsuivi * dure;
            compteur_vehicule++;
            Quantite_de_chaque_vehicule();   
            cbocategorie.Text = "";
            txtimmatriculation.Text = "";
            txtmarque.Text = "";
            txtdure.Text = "";
            cbosuivi.Text = "";
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {           
                requete = "UPDATE  `commande` SET `lieu`='" + txtlieu.Text + "',`prix_total`='" + txtprix_installation.Text + "',`prix_reduit`='" + txtprix_reduit.Text + "',`quantite`='" + compte_vehicule + "'  WHERE id_commande='" + commande + "'";
                a.ExecuteRequette(requete);
                chargement();
          
        }
        private void cboclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void txtmarque_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            chargement();
            Quantite_tricycle = 0;
            Quantite_poids_lourds = 0;
            Quantite_moto = 0;
            Quantite_vehicule_legers = 0;
            Prix_total = 0;
            Prix_installation = 0;
            Prix_suivi = 0;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {                       
            commande = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);            
            requete = "select id_client from commande where id_commande='" + commande + "'";
            idclient = a.ResultatRequette1(requete);
            requete = "SELECT concat(Nom,' ',Prenom) FROM client where id_client='" + idclient + "'";
            MessageBox.Show(requete);
            cboclient.Text = a.ResultatRequette(requete);
            cboclient.Text = (idclient).ToString();          
            dtpDate.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtlieu.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            cbosuivi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtprix_installation.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txtprix_reduit.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            btnmodifier.Enabled = true;
            btnEnregistrer.Enabled = false;
            dtpDate.Enabled = false;
            cboclient.Enabled = false;
            btncalcul.Enabled = false;
           
        }

        private void btnremise_Click_1(object sender, EventArgs e)
        {
            if (btnmodifier.Enabled == false)
            { 
                remise = Convert.ToInt64(txtremise.Text);
                if (remise < Prix_total && remise > 0)
                {
                    p_remiser = Prix_total - remise;
                    txtprix_reduit.Text = (p_remiser).ToString();

                }
                else
                {
                    MessageBox.Show("entrer une remise positif et inférieur au prix");
                }
            }else {
                Prix_total = Convert.ToInt64(txtprix_installation.Text);
                remise = Convert.ToInt64(txtremise.Text);
                if (remise < Prix_total && remise > 0)
                {
                    p_remiser = Prix_total - remise;
                    txtprix_reduit.Text = (p_remiser).ToString();

                }
                else
                {                    
                    MessageBox.Show("entrer une remise positif et inférieur au prix");
                }
            }
      }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
