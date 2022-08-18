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
            requete = "SELECT concat(Nom,' ',Prenom) FROM client";
            a.ChargeCombo(cboclient, requete);
            requete = "SELECT concat(Nom,' ',Prenom) FROM technicien";
            a.ChargeCombo(cbotechnicien, requete);
            a.ChargeCombo(cbotechnicien2, requete);
            a.ChargeCombo(cbotechnicien3, requete);
            a.ChargeCombo(cbotechnicien4, requete);
            a.ChargeCombo(cbotechnicien5, requete);
            txtemail.Text = "";
            txtnumerrogps.Text = "";
            cbotechnicien.Text = "";
            cbovehicule.Text ="";
            cbostatut.Text= "";
            cboclient.Text = "";
            requete = "SELECT * FROM `commande`";
            a.ChargeTable(dataGridView2, requete);
            cboclient.Enabled = false;
            dtpdate2.Enabled = false;
            btnmodifier.Enabled = false;
            btnEnregistrer.Enabled = false;       
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            requete = "update installation set statut='" + cbostatut.Text + "' where id_installation='"+idinstallation+"'" ;
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
   
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idcommande = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            requete = "select id_commande from installation where id_commande='"+idcommande+"'";
            if (a.ResultatRequette1(requete) != 0)
            {
                MessageBox.Show("Cette commande a déjà été installée");
                btnEnregistrer.Enabled = false;                                
                btnmodifier.Enabled = true;
            }
            if(a.ResultatRequette1(requete) == 0)
            {
                idclient = Convert.ToInt32(dataGridView2.CurrentRow.Cells[1].Value);
                requete = "select concat(Nom,' ',Prenom) from client where id_client='" + idclient + "'";
                string client = a.ResultatRequette(requete);
                MessageBox.Show("Vous venez de selectionner la commande de " + client + " du " + a.date_vers_mysql(dtpDate.Text) + " ");
                requete = " SELECT concat(categorie_vehicule,' ',marque_vehicule,' ', immatriculation_vehicule) FROM vehicule , cat_vehicule  WHERE vehicule.id_catvehicule = cat_vehicule.id_catvehicule AND vehicule.id_commande = '" + idcommande + "'";
                a.ChargeCombo(cbovehicule, requete);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idinstallation= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            cbostatut.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            btnmodifier.Enabled = true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
                num_gps[compteur_vehicule] = Convert.ToInt32(txtnumerrogps.Text);
                imei_gps[compteur_vehicule] = Convert.ToInt32(txtemail.Text);
                requete = "SELECT id_vehicule FROM vehicule , cat_vehicule WHERE vehicule.id_catvehicule = cat_vehicule.id_catvehicule AND vehicule.id_commande = '" + idcommande + "' and concat(categorie_vehicule,' ', marque_vehicule,' ', immatriculation_vehicule)= '" + cbovehicule.Text + "'";
                idvehicule = a.ResultatRequette1(requete);
                idvehic[compteur_vehicule] = idvehicule;
                compteur_vehicule++;
                btnEnregistrer.Enabled = true;
                txtemail.Text = "";
                txtnumerrogps.Text = "";
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

        }

        private void btntrier_Click(object sender, EventArgs e)
        {
            requete = "select id_client from client where concat(Nom,' ',Prenom)='" + cboclient.Text + "'";
            idclient = a.ResultatRequette1(requete);
            if (nom.Checked==true)
            {
                cboclient.Enabled = true;                
                requete = "select * from commande where id_client='" + idclient + "'";
                a.ChargeTable(dataGridView2, requete);
            }
         
            if (date.Checked==true)
            {
                dtpdate2.Enabled = true;               
                requete = "select * from commande where Date_commande='" + a.date_vers_mysql(dtpdate2.Text) + "'";
                a.ChargeTable(dataGridView2, requete);
            }
            if (date.Checked == true && nom.Checked == true)
            {
                dtpdate2.Enabled = true;
                cboclient.Enabled = true;              
                requete = "select * from commande where Date_commande='" + a.date_vers_mysql(dtpdate2.Text) + "' and Nom_client='"+idclient+"'";
                a.ChargeTable(dataGridView2, requete);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            
        }
    }
}
