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
    public partial class frmsuivi : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete = "";
        int suivi = 0;
            public frmsuivi()
        {
                InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            requete = "insert into suivi (type_suivi,prix_suivi) values ('"+txtcategorie.Text+"','"+txtprix.Text+"')";
            a.ExecuteRequette(requete);
            chargement();
        }

        private void frmsuivi_Load(object sender, EventArgs e)
        {
            chargement();
        }
        void chargement()
        {
            requete = " Select * from suivi ";
            a.ChargeTable(dataGridView1, requete);
            txtcategorie.Text = "";
            txtprix.Text = "";
            btnmodifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnEnregistrer.Enabled = true;
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            requete = "update suivi set type_suivi='"+txtcategorie.Text+"', prix_suivi='"+txtprix.Text+"' where id_suivi='"+suivi+"'";
            a.ExecuteRequette(requete);
            chargement();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            chargement();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            requete = "delete from suivi where id_suivi='"+suivi+"'";
            a.ExecuteRequette(requete);
            chargement();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            suivi= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtprix.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtcategorie.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            btnEnregistrer.Enabled = false;
            btnmodifier.Enabled = true;
            btnSupprimer.Enabled = true;
        }

        private void txtprix_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
