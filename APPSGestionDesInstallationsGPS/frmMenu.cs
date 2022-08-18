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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmenregistrementClients f = new frmenregistrementClients();
            f.ShowDialog();
        }      
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void comptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmgestionCompte f = new frmgestionCompte();
            f.ShowDialog();
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vehiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvehicule f = new frmvehicule();
            f.ShowDialog();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCommande f = new frmCommande();
            f.ShowDialog();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void technicienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmenrg_techniciens f = new frmenrg_techniciens();
            f.ShowDialog();
        }

        private void installationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frminstallation f = new frminstallation();
            f.ShowDialog();
        }

        private void suiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsuivi f = new frmsuivi();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void commandeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCommande f = new frmCommande();
            f.ShowDialog();
        }
    }
}
