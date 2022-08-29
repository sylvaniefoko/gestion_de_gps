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
    public partial class frminstallation : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete = "";
        int idclient,idcommande,compteur_vehicule,idvehicule, idtechnicien1,idtechnicien2, idtechnicien3, idtechnicien4, idtechnicien5,idinstallation = 0;
        int[] imei_gps = new int[100];
        int[] num_gps = new int[100];
        int[] idvehic = new int[100];

        public frminstallation()
        {
            InitializeComponent();
        }

        private void frminstallation_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {                   
            requete = "Select * from installation";
            a.ChargeTable(dataGridView1, requete);
            requete = "SELECT concat(nom,' ',prenom) FROM client";
            a.ChargeCombo(cboclient, requete);
            requete = "SELECT concat(nom,' ',prenom) FROM technicien";
            a.ChargeCombo(cbotechnicien, requete);
            a.ChargeCombo(cbotechnicien2, requete);
            a.ChargeCombo(cbotechnicien3, requete);
            a.ChargeCombo(cbotechnicien4, requete);
            a.ChargeCombo(cbotechnicien5, requete);
            txtimei.Text = "";
            txtnumerrogps.Text = "";
            cbotechnicien.Text = "";
            cbovehicule.Text ="";
            cbostatut.Text= "";
            cboclient.Text = "";
            requete = "SELECT id_commande,concat(nom,' ',prenom),Date_commande,lieu,quantite FROM commande c, client cc WHERE cc.id_client=c.id_client;";
            a.ChargeTable(dataGridView2, requete);
            cboclient.Enabled = false;
            dtpdate2.Enabled = false;
            btnmodifier.Enabled = false;
            btnEnregistrer.Enabled = false;
            btnmodifier2.Visible = false; 
                  
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        void charge_gps()
        {      
            requete = "select id_vehicule from vehicule,cat_vehicule where concat(categorie_vehicule,' ',marque_vehicule,' ',immatriculation_vehicule)='" + cbovehicule.Text + "' and vehicule.id_catvehicule = cat_vehicule.id_catvehicule";
            idvehicule = a.ResultatRequette1(requete);
            requete = "select num_gps from gps where id_vehicule='" + idvehicule + "'";
            txtnumerrogps.Text = (a.ResultatRequette1(requete)).ToString();
            requete = "select imei_gps from gps where id_vehicule='" + idvehicule + "'";
            txtimei.Text = (a.ResultatRequette1(requete)).ToString();
        }
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            idtechnicien();
            requete = "update installation set statut='" + cbostatut.Text + "', id_technicien1='"+idtechnicien1+ "', id_technicien2='" + idtechnicien2 + "' ,id_technicien3='" + idtechnicien3 + "', id_technicien4='" + idtechnicien4 + "',id_technicien5='"+idtechnicien5+"' where id_installation='" + idinstallation+"'" ;
            a.ExecuteRequette(requete);
            chargement();          
        }
        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            chargement();
            compteur_vehicule = 0;
            imei_gps[compteur_vehicule] = 0;
            num_gps[compteur_vehicule] = 0;
            idvehic[compteur_vehicule] = 0;
        }    
   void charge_champs()
        {
            idtechnicien1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            idtechnicien2 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            idtechnicien3 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            idtechnicien4 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            idtechnicien5 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            requete = "select concat(nom,' ',prenom) from technicien where id_technicien='"+idtechnicien1+"'";
            cbotechnicien.Text = a.ResultatRequette(requete);
            requete = "select concat(nom,' ',prenom) from technicien where id_technicien='" + idtechnicien2 + "'";
            cbotechnicien2.Text = a.ResultatRequette(requete);
            requete = "select concat(nom,' ',prenom) from technicien where id_technicien='" + idtechnicien3 + "'";
            cbotechnicien3.Text = a.ResultatRequette(requete);
            requete = "select concat(nom,' ',prenom) from technicien where id_technicien='" + idtechnicien4 + "'";
            cbotechnicien4.Text = a.ResultatRequette(requete);
            requete = "select concat(nom,' ',prenom) from technicien where id_technicien='" + idtechnicien5 + "'";
            cbotechnicien5.Text = a.ResultatRequette(requete);
            cbostatut.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idcommande = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);           
            requete = " SELECT concat(categorie_vehicule,' ',marque_vehicule,' ', immatriculation_vehicule) FROM vehicule , cat_vehicule  WHERE vehicule.id_catvehicule = cat_vehicule.id_catvehicule AND vehicule.id_commande = '" + idcommande + "'";
            a.ChargeCombo(cbovehicule, requete);                  
            requete = "select count(id_commande) from installation where id_commande='" + idcommande + "'";
            if (a.ResultatRequette1(requete) != 0)
            {
                AccesDonnees.erreur ="Cette commande a déjà été installée";
                frmerreur f = new frmerreur();
                f.ShowDialog();
                charge_champs();
                btnEnregistrer.Enabled = false;                                
                btnmodifier.Enabled = true;
                btnmodifier2.Visible = true;
                btnok.Visible = false;
            }
            if(a.ResultatRequette1(requete) == 0)
            {
                idclient = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                requete = "select concat(nom,' ',prenom) from client where id_client='" + idclient + "'";
                string client = a.ResultatRequette(requete);
                AccesDonnees.confirmation = "Vous venez de selectionner la commande du " + a.date_vers_mysql(dtpDate.Text) + "";
                frmConfirmation f = new frmConfirmation();
                f.ShowDialog();
                btnmodifier.Enabled = false;                
            }                     
        }

        private void nom_CheckedChanged(object sender, EventArgs e)
        {
            if (nom.Checked == true)
            {
                cboclient.Enabled = true;
            }
            else
            {
                cboclient.Enabled = false;
            }
        }

        private void date_CheckedChanged(object sender, EventArgs e)
        {
            if (date.Checked == true)
            {
                dtpdate2.Enabled = true;
            }
            else
            {
                dtpdate2.Enabled = false;
            }
        }

        private void dtpdate2_ValueChanged(object sender, EventArgs e)
        {

        }
        void idtechnicien()
        {
            requete = "select id_technicien from technicien where concat(Nom,' ',Prenom)='" + cbotechnicien.Text + "'";
            idtechnicien1 = a.ResultatRequette1(requete);
            requete = "select id_technicien from technicien where concat(Nom,' ',Prenom)='" + cbotechnicien2.Text + "'";
            idtechnicien2 = a.ResultatRequette1(requete);
            requete = "select id_technicien from technicien where concat(Nom,' ',Prenom)='" + cbotechnicien3.Text + "'";
            idtechnicien3 = a.ResultatRequette1(requete);
            requete = "select id_technicien from technicien where concat(Nom,' ',Prenom)='" + cbotechnicien4.Text + "'";
            idtechnicien4 = a.ResultatRequette1(requete);
            requete = "select id_technicien from technicien where concat(Nom,' ',Prenom)='" + cbotechnicien5.Text + "'";
            idtechnicien5 = a.ResultatRequette1(requete);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            idtechnicien();
            idcommande = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            requete = "INSERT INTO `installation`(`id_commande`, `id_technicien1`,`id_technicien2`,`id_technicien3`,`id_technicien4`,`id_technicien5` ,`date_installation`, `statut`) VALUES ('" + idcommande + "','" + idtechnicien1 + "','" + idtechnicien2 + "','" + idtechnicien3 + "','" + idtechnicien4 + "','" + idtechnicien5 + "','" + a.date_vers_mysql(dtpDate.Text) + "','" + cbostatut.Text + "')";
            a.ExecuteRequette(requete);
            requete = "select id_installation from installation where id_commande='" + idcommande + "'and `id_technicien1`='" + idtechnicien1 + "'and `id_technicien2`='" + idtechnicien2 + "'and `id_technicien3`='" + idtechnicien3 + "'and `id_technicien4`='" + idtechnicien4 + "'and `id_technicien5`='" + idtechnicien5 + "' and `date_installation`='" + a.date_vers_mysql(dtpDate.Text) + "'and  `statut`='" + cbostatut.Text + "'  ";
            idinstallation = a.ResultatRequette1(requete);
            for (int i = 0; i <= compteur_vehicule-1; i++)
            {
                requete = "insert into gps (id_vehicule,id_installation,num_gps,imei_gps) values ('"+idvehic[i]+"','"+idinstallation+"','" + num_gps[i] + "','" + imei_gps[i] + "')";
                a.ExecuteRequette(requete);               
            }
            chargement();
           
        }

        private void txtnumerrogps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                AccesDonnees.erreur="veuillez saisir des chiffres";
                frmerreur f = new frmerreur();
                f.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void btnmodifer2_Click(object sender, EventArgs e)
        {
            requete = "select gps.id_vehicule from gps,vehicule,cat_vehicule where concat(categorie_vehicule,' ',marque_vehicule,' ', immatriculation_vehicule)='" + cbovehicule.Text + "' and vehicule.id_catvehicule = cat_vehicule.id_catvehicule and vehicule.id_vehicule=gps.id_vehicule ";
            int idveh_gps = a.ResultatRequette1(requete);
            if (idveh_gps != 0)
            {
                requete = "update gps set num_gps='" + txtnumerrogps.Text + "', imei_gps='" + txtimei.Text + "' where id_vehicule='" + idvehicule + "'";
                a.ExecuteRequette(requete);
            }
            else
            {
                requete = "insert into gps ( num_gps, imei_gps,id_vehicule,id_installation) values('" + txtnumerrogps.Text + "','" + txtimei.Text + "','"+idvehicule+"','"+idinstallation+"') ";
                a.ExecuteRequette(requete);
            }
            txtimei.Text = "";
            txtnumerrogps.Text = "";
            cbovehicule.Text = "";
        }

        private void NOM_1_Click(object sender, EventArgs e)
        {

        }

        private void txtimei_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                AccesDonnees.erreur = "veuillez saisir des chiffres";
                frmerreur f = new frmerreur();
                f.ShowDialog();
                e.Handled = true;
                return;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idinstallation= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cbostatut.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            btnmodifier.Enabled = true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            int num = 0;
            int imei = 0;
            if (txtnumerrogps.Text == "")
            {
                num_gps[compteur_vehicule] = 0;
            }
            else {
                num = Convert.ToInt32(txtnumerrogps.Text);
                num_gps[compteur_vehicule] = num;
            }
            if (txtimei.Text =="")
            {
                imei_gps[compteur_vehicule] = 0;
            }
            else
            {
                imei=Convert.ToInt32(txtimei.Text);
                imei_gps[compteur_vehicule] = imei;
            }               
                requete = "SELECT id_vehicule FROM vehicule , cat_vehicule WHERE vehicule.id_catvehicule = cat_vehicule.id_catvehicule AND vehicule.id_commande = '" + idcommande + "' and concat(categorie_vehicule,' ', marque_vehicule,' ', immatriculation_vehicule)= '" + cbovehicule.Text + "'";
                idvehicule = a.ResultatRequette1(requete);
                idvehic[compteur_vehicule] = idvehicule;
                compteur_vehicule++;
                btnEnregistrer.Enabled = true;
                txtimei.Text = "";
                txtnumerrogps.Text = "";
                cbovehicule.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            
        }
        private void cbovehicule_SelectedIndexChanged(object sender, EventArgs e)
        {
            charge_gps();       
        }

        private void btntrier_Click(object sender, EventArgs e)
        {
            requete = "select id_client from client where concat(nom,' ',srenom)='" + cboclient.Text + "'";
            idclient = a.ResultatRequette1(requete);
            if (nom.Checked==true)
            {
                cboclient.Enabled = true;                
                requete = "select concat(nom,' ',prenom),Date_commande,lieu,quantite from commande c,client cl where c.id_client='" + idclient + "' and cl.id_client='"+idclient+"' and c.id_commande='"+idcommande+"'";
                a.ChargeTable(dataGridView2, requete);
            }
         
            if (date.Checked==true)
            {
                dtpdate2.Enabled = true;               
                requete = "select id_commande,concat(nom,' ',prenom),Date_commande,lieu,quantite from commande c,client cl where Date_commande='" + a.date_vers_mysql(dtpdate2.Text) + "'";
                a.ChargeTable(dataGridView2, requete);
            }
            if (date.Checked == true && nom.Checked == true)
            {
                dtpdate2.Enabled = true;
                cboclient.Enabled = true;              
                requete = "select id_commande,concat(nom,' ',prenom),Date_commande,lieu,quantite from commande c,client cl where Date_commande='" + a.date_vers_mysql(dtpdate2.Text) + "' and c.id_client='" + idclient+ "'and cl.id_client='" + idclient + "' and c.id_commande='" + idcommande + "'";
                a.ChargeTable(dataGridView2, requete);
            }
            cboclient.Text = "";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            
        }
    }
}
