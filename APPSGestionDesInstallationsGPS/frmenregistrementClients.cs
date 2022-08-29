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
    public partial class frmEnregistrementClients : Form
    {
        AccesDonnees a = new AccesDonnees ();
        string requete="";
        string lematricule="";
        public frmEnregistrementClients()
        {
           
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_Telephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            requete = "UPDATE client SET Nom='" + txtNom.Text + "', Prenom='" + txtPrenom.Text + "',Adresse='" + txtAdresse.Text + "', Telephone='" + txtTelephone.Text + "', Ville='" + txtVille.Text + "' WHERE id_client='" + lematricule + "'";
            a.ExecuteRequette(requete);
            chargement();
            AccesDonnees.confirmation ="Modification effectué avec succes" ;
            frmConfirmation f = new frmConfirmation();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {   
            requete = "INSERT INTO `client`(`Nom`, `Prenom`, `Adresse`, `Telephone`, `Ville`) VALUES ('" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtAdresse.Text + "','" + txtTelephone.Text + "','" + txtVille.Text + "')";
            a.ExecuteRequette (requete);
            chargement();
            AccesDonnees.confirmation = "enregistrement effectué avec succes";
            frmConfirmation f = new frmConfirmation();
            f.ShowDialog();
        }

        private void btnSupprimmer_Click(object sender, EventArgs e)
        {
             requete = "DELETE FROM client WHERE id_client = '" + lematricule + "'";
            a.ExecuteRequette(requete);
            AccesDonnees.confirmation = "Suppression effectuée avec succes";
            frmConfirmation f = new frmConfirmation();
            f.ShowDialog();
            chargement();
        }

        private void frmenregistrementClients_Load(object sender, EventArgs e)
        {
            chargement();
        }
         void chargement()
        {
            requete = "select * from client";
            a.ChargeTable(dataGridView1, requete);
            txtid_client.Text = "";
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtAdresse.Text = "";
            txtTelephone.Text = "";
            txtVille.Text = "";
            btnEnregistrer.Enabled = true;
            btnmodifier.Enabled = false;
            btnSupprimer.Enabled = false;
            txtid_client.Enabled = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lematricule = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtNom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtPrenom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtAdresse.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtTelephone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtVille.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txtid_client.Text = lematricule;
            btnEnregistrer.Enabled = false;
            btnmodifier.Enabled = true;
            btnSupprimer.Enabled = true;
            txtid_client.Enabled = false;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncommande_Click(object sender, EventArgs e)
        {

        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                AccesDonnees.erreur = "veuillez saisir des chiffres";
                frmErreur f = new frmErreur();
                f.ShowDialog();
                e.Handled = true;
                return;
            }
        }
    }
}
