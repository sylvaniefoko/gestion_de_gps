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
    public partial class frmgestionCompte : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete;
        int lematricule;
        public frmgestionCompte()
        {
            InitializeComponent();
        }

        private void frmgestionCompte_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            requete = "select * from compte";
            a.ChargeTable(dataGridView1, requete);

           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            lematricule = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            btnSupprimer.Enabled = true;
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
                     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            requete = "DELETE FROM compte WHERE id_compte = '" + lematricule + "'";
            a.ExecuteRequette(requete);           
            AccesDonnees.confirmation = "suppression effectué";
            frmConfirmation f = new frmConfirmation();
            f.ShowDialog();
            chargement();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboquestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
