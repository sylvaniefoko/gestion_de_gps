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
        int idclient,commande, i, prixsuivi ,dure,id_vehicule, nbre_veh_commande = 0;
        double p_remiser, remise, Prix_total, prix_poids_lourds, prix_vehicule_legers, prix_moto, prix_tricycle,
        Quantite_moto, Quantite_poids_lourds, Quantite_vehicule_legers, compte_vehicule, Prix_suivi,Prix_installation,
        Quantite_tricycle = 0;
        int compteur_vehicule_modif = 0;
        string requete = "";
        int[] tab_id_vehicule = new int[100];
        string[] marquevehicule = new string [100];
        //string[] immatriculationvehicule = new string[100];
        string[] tab_marque = new string[100];
        int[] tab_categorie = new int[100];
        //string[] durer = new string[100];
        string[] tab_immatriculation = new string[100];
        string[] tab_suivi = new string[100];
        int[] tableau_suivi  = new int[100];
        int[] tab_durer = new int[100];
        int compteur_vehicule = 0;
        string[] categorievehicule = new string[100];
        int compteur_veh = 0;
        public frmCommande()
        {
            InitializeComponent();
        }
        public static void uniquement_entier(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir des chiffres");              
                e.Handled = true;
                return;                
            }
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
            txtprix_suivi.Text = "";
            txtprix_total.Text = "";
            txtdeplacement.Text = "";
            txtdure.Text = "";
            txtsejour.Text = "";
            cbotype.Text = "";
            txtlieu.Text = "";
            dtpDate.Text = "";
            txtprix_reduit.Text = "";
            btnEnregistrer.Enabled = false;
            btnmodifier.Enabled = false;
            txtremise.Text = "";
            requete = "select type_suivi from suivi ";
            a.ChargeCombo(cbosuivi, requete);
            btnavancer.Visible = false;   
            btnmodifier2.Visible = false;
      
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

        private void btnavancer_Click(object sender, EventArgs e)
        {
            charge_group_vehicule(++compteur_vehicule_modif);
        }
        void charge_group_vehicule(int compteur_vehicule_modif)
        {
            requete = "select count(id_vehicule) from vehicule where id_commande='" + commande + "' ";
            nbre_veh_commande = a.ResultatRequette1(requete);
            if (nbre_veh_commande == compteur_vehicule_modif)
            {
                MessageBox.Show("ceci est le dernier véhicule de cette commande");
            }
            cbocategorie.Text = (categorievehicule[compteur_vehicule_modif]).ToString();
            txtimmatriculation.Text = tab_immatriculation[compteur_vehicule_modif];
            txtmarque.Text = marquevehicule[compteur_vehicule_modif];
            cbosuivi.Text = (tab_suivi[compteur_vehicule_modif]).ToString();
            txtdure.Text = (tab_durer[compteur_vehicule_modif]).ToString() ;
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
            int sejour = 0;
            int deplacement = 0;
            if (txtsejour.Text == ""){
                sejour = 0;
            }
            else
            {
                sejour = Convert.ToInt32(txtsejour.Text);
                if (sejour < 0)
                {
                    MessageBox.Show("Entrer une valeur positif");
                }
            }
            if (txtdeplacement.Text == "")
            {
                deplacement = 0;
            }
            else
            {
                deplacement = Convert.ToInt32(txtdeplacement.Text);
                if (deplacement < 0)
                {
                    MessageBox.Show("Entrer un chiffre positif");
                }
                if (txtlegers.Text == "")
                {
                    Quantite_vehicule_legers = 0;
                }
                if (txtlourds.Text == "")
                {
                    Quantite_poids_lourds = 0;
                }
                if (txttricycle.Text == "")
                {
                    Quantite_tricycle = 0;
                }
                if (txtmoto.Text == "")
                {
                    Quantite_moto = 0;
                }
                prix_poids_lourds = prix_poids_lourds * Quantite_poids_lourds;
                prix_vehicule_legers = prix_vehicule_legers * Quantite_vehicule_legers;
                prix_moto = prix_moto * Quantite_moto;
                prix_tricycle = prix_tricycle * Quantite_tricycle;
                Prix_installation = prix_poids_lourds + prix_vehicule_legers + prix_moto + prix_tricycle + sejour + deplacement;
                compte_vehicule = Quantite_tricycle + Quantite_vehicule_legers + Quantite_poids_lourds + Quantite_moto;

                if (cbosuivi.Text != "")
                {
                    txtprix_installation.Text = (Prix_installation).ToString();
                    txtprix_suivi.Text = (prixsuivi * dure).ToString();
                    Prix_total = (prixsuivi * dure) + Prix_installation;
                    txtprix_total.Text = (Prix_total).ToString();
                    btnEnregistrer.Enabled = true;
                }
                else
                {
                    MessageBox.Show("remplir le champ suivi");
                }
            }
        }

        private void txtlegers_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
           
            requete = "select id_client from client where concat(Nom,' ',Prenom)='" + cboclient.Text + "'";
            idclient = a.ResultatRequette1(requete);
            requete = "INSERT INTO `commande`( `id_client`,`quantite` ,`prix_reduit`, `prix_total`,`prix_suivi`,`prix_installation`,`Date_commande`,`frais_deplacement`, `frais_sejour`,`lieu`) VALUES('" + idclient + "','" + compte_vehicule + "','" +txtprix_reduit.Text + "','"+txtprix_total.Text+"','"+txtprix_suivi.Text+"','"+txtprix_installation.Text+"','" + a.date_vers_mysql(dtpDate.Text) + "','" + txtdeplacement.Text+"','" + txtsejour.Text+"','" + txtlieu.Text + "')";
            a.ExecuteRequette(requete);
            requete = "SELECT `id_commande` FROM `commande` WHERE  `id_client`='" + idclient + "' and `Date_commande`='" + a.date_vers_mysql(dtpDate.Text) + "' and `lieu`='" + txtlieu.Text + "' and   `prix_total`='" + txtprix_total.Text + "' and `prix_reduit`='" + txtprix_reduit.Text + "' and  `quantite`='" + compte_vehicule + "'";
            int id_commande = a.ResultatRequette1(requete);
            for (int i= 0; i <= compteur_veh-1; i++)
            {
                requete = "insert into vehicule (immatriculation_vehicule,marque_vehicule,id_catvehicule,dure,id_suivi,id_commande) values ('" + marquevehicule[i] + "','" + tab_immatriculation[i] + "','" + tab_categorie[i] + "','"+tab_durer[i]+"','"+tableau_suivi[i]+"','" + id_commande + "')";
                a.ExecuteRequette(requete);
            }
            compte_vehicule = 0;
            chargement();
            Prix_total = 0;
            Prix_installation = 0;
            Prix_suivi = 0;
        }

        private void cbosuivi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbosuivi.Text == "aucun")
            {
                txtdure.ReadOnly = true;
            }else { txtdure.ReadOnly = false; }
        }

        private void txtdure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir des chiffres");
                e.Handled = true;
               return;
            }
        }

        private void txtsejour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir des chiffres");
                e.Handled = true;
                return;
            }
        }

        private void txtdeplacement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir des chiffres");
                e.Handled = true;
                return;
            }
        }

        private void txtremise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("veuillez saisir des chiffres");
                e.Handled = true;
                return;
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtdure_TextChanged(object sender, EventArgs e)
        {
            if (cbosuivi.Text != "Aucun")
            {
                if (txtdure.Text == (0).ToString())
                {
                    MessageBox.Show("Entrer une valeur quantifiable");
                    txtdure.Text = "";
                }
                
            }
        }

        private void dtpDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnmodifier2_Click(object sender, EventArgs e)
        {
            requete = "select id_catvehicule from cat_vehicule where categorie_vehicule='" +cbocategorie.Text+ "'";
            int id_categorie = a.ResultatRequette1(requete);
            requete = "update vehicule set marque_vehicule='" + txtmarque.Text + "',immatriculation_vehicule='" + txtimmatriculation.Text + "', id_suivi='" + a.ResultatRequette1("select id_suivi from suivi where type_suivi='" + cbosuivi.Text + "'") + "',id_catvehicule='" + id_categorie+ "',dure='" + txtdure.Text + "' where id_vehicule='" + tab_id_vehicule[compteur_vehicule]+ "'";
            a.ExecuteRequette(requete);
            MessageBox.Show(requete);            
            compteur_vehicule++;
            vider_champs();
            btnavancer.Enabled = true;
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
            int valuedurer = 0;
                AccesDonnees.erreur = "Veuillez remplir tous les champs";
                frmerreur f = new frmerreur();
                marquevehicule[compteur_veh] = txtmarque.Text;
                tab_immatriculation[compteur_veh] = txtimmatriculation.Text;
                tab_categorie[compteur_veh] = a.ResultatRequette1("SELECT `id_catvehicule` FROM `cat_vehicule` WHERE `categorie_vehicule`= '" + cbocategorie.Text + "'");
                if (txtdure.Text == "")
                {
                    valuedurer = 0;
                }
                else
                {
                    valuedurer = Convert.ToInt32(txtdure.Text);
                    if (valuedurer < 0)
                    {
                        MessageBox.Show("Entrer un chiffre positif");
                    }
                }
                tab_durer[compteur_veh] = valuedurer;
                tableau_suivi[compteur_veh] = a.ResultatRequette1("select id_suivi from suivi where type_suivi='" + cbosuivi.Text + "'");
                compteur_veh++;
                dure = dure + valuedurer;
                requete = "select prix_suivi from suivi where type_suivi='" + cbosuivi.Text + "'";
                int prix = a.ResultatRequette1(requete);
                prixsuivi = prixsuivi + prix;
                Quantite_de_chaque_vehicule();
                vider_champs();        
        }
        void vider_champs()
        {
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
        }

        private void btnremise_Click_1(object sender, EventArgs e)
        {
            if (btnmodifier.Enabled == false)
            {
                if (txtremise.Text =="")
                {
                    remise = 0;
                } else {remise = Convert.ToInt64(txtremise.Text); }                
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
                Prix_total = Convert.ToInt64(txtprix_total.Text);
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
        void charge_vehicule()
        {
            commande = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            requete = "select count(id_vehicule) from vehicule where id_commande='" + commande + "' ";
            int nbre_veh_commande = a.ResultatRequette1(requete);
            int offset = 0;
            for (i = 0; i <= nbre_veh_commande; i++)
            {
                requete = "select id_vehicule from vehicule where id_commande='" + commande + "' LIMIT 1 OFFSET "+ offset +" ";
                id_vehicule = a.ResultatRequette1(requete);
                tab_id_vehicule[i] = id_vehicule;
                requete = "select marque_vehicule from vehicule where id_vehicule='" + id_vehicule + "'";
                marquevehicule[i]= a.ResultatRequette(requete);
                //txtmarque.Text = marquevehicule[i];
                requete = "select immatriculation_vehicule from vehicule where id_vehicule='" + id_vehicule + "'";
                tab_immatriculation[i] = a.ResultatRequette(requete);
                //txtimmatriculation.Text = tab_immatriculation[i];
                requete = "SELECT ca.categorie_vehicule FROM cat_vehicule ca, vehicule v WHERE v.id_vehicule='"+ id_vehicule + "' AND v.id_catvehicule=ca.id_catvehicule;";
                categorievehicule[i] = a.ResultatRequette(requete);
                requete = "select categorie_vehicule from cat_vehicule where id_catvehicule='" + categorievehicule[i] + "'";
                //cbocategorie.Text = a.ResultatRequette(requete);
                requete = "select dure from vehicule where id_vehicule='" + id_vehicule + "'";
                tab_durer[i] = a.ResultatRequette1(requete);
                //txtdure.Text = Convert.ToString(tab_durer[i]);
                requete = "SELECT s.type_suivi FROM suivi s, vehicule v WHERE v.id_vehicule='" + id_vehicule + "' AND v.id_suivi=s.id_suivi;";
                tab_suivi[i] = a.ResultatRequette(requete);
                offset++;
            }
            
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnok.Visible = false;
            btnmodifier2.Visible = true;
            btnavancer.Visible = true;        
            charge_vehicule();
            commande = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            requete = "select id_client from commande where id_commande='" + commande + "'";
            idclient = a.ResultatRequette1(requete);
            requete = "SELECT concat(nom,' ',prenom) FROM client where id_client='" + idclient + "'";           
            MessageBox.Show(requete);
            cboclient.Text = a.ResultatRequette(requete);
            dtpDate.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtlieu.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtprix_installation.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
            txtprix_total.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            txtprix_suivi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            txtsejour.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtdeplacement.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txtprix_reduit.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            charge_group_vehicule(compteur_vehicule_modif);

            btnmodifier.Enabled = true;
            btnEnregistrer.Enabled = false;
            dtpDate.Enabled = false;
            cboclient.Enabled = false;
            btncalcul.Enabled = false;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
