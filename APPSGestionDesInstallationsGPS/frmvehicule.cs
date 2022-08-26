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
    public partial class frmvehicule : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete="";
        int  lematricule=0;
        public frmvehicule()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
          requete= "INSERT INTO `Cat_vehicule`( `categorie_vehicule`,`prix_installation`) VALUES ('" + txtcategorie.Text+"','"+txtPrix.Text+"')";
            a.ExecuteRequette(requete);
            chargement();           
            AccesDonnees.confirmation ="enregistrement effectué" ;
            frmConfirmation f = new frmConfirmation();
            f.ShowDialog();
        }
         private void btnmodifier_Click(object sender, EventArgs e)
        {
            requete = "UPDATE `Cat_vehicule` SET `categorie_vehicule`= '" + txtcategorie.Text + "',`prix_installation`= '" + txtPrix.Text + "' where id_catvehicule='"+lematricule+"'";
            a.ExecuteRequette(requete);
            chargement();           
            AccesDonnees.confirmation=  "modification effectué avec succes";
            frmConfirmation f = new frmConfirmation();
            f.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lematricule = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtcategorie.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtPrix.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);          
            btnEnregistrer.Enabled = false;
            btnmodifier.Enabled = true;
            btnSupprimer.Enabled = true;       
           
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            chargement();
        }

        private void frmvehicule_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            requete = "select * from Cat_vehicule ";
            a.ChargeTable(dataGridView1, requete);
            txtPrix.Text = "";      
            txtcategorie.Text = "";            
            btnEnregistrer.Enabled = true;
            btnmodifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            requete = "delete from Cat_vehicule where id_catvehicule='" + lematricule+"'";
            a.ExecuteRequette(requete);
            chargement();            
        }

        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcategorie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
