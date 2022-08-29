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
    public partial class frmDashboard : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete = "";
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (int nleftRect,
          int nTopRect,
          int nBottomRect,
          int RightRect,
          int WidhtEllipse,
          int HeightEllipse);

        public frmDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlcommand.Height = btndashboard.Height;
            pnlcommand.Top = btndashboard.Top;
            pnlcommand.Left = btndashboard.Left;
            btndashboard.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void EndResponsive()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btng_installation_Click(object sender, EventArgs e)
        {
            pnlcommand.Height = btng_installation.Height;
            pnlcommand.Top = btng_installation.Top;
            pnlcommand.Left = btng_installation.Left;
            btng_installation.BackColor = Color.FromArgb(46, 51, 73);
         
        }

        private void btng_client_Click(object sender, EventArgs e)
        {
            pnlcommand.Height = btng_client.Height;
            pnlcommand.Top = btng_client.Top;
            pnlcommand.Left = btng_client.Left;
            btng_client.BackColor = Color.FromArgb(46, 51, 73);
            frmEnregistrementClients f = new frmEnregistrementClients();
            f.ShowDialog();
        }

        private void btng_parametre_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click_1(object sender, EventArgs e)
        {
            pnlcommand.Height = btndashboard.Height;
            pnlcommand.Top = btndashboard.Top;
            pnlcommand.Left = btndashboard.Left;
            btndashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btng_technicien_Click_1(object sender, EventArgs e)
        {
            pnlcommand.Height = btng_technicien.Height;
            pnlcommand.Top = btng_technicien.Top;
            pnlcommand.Left = btng_technicien.Left;
            btng_technicien.BackColor = Color.FromArgb(46, 51, 73);
         
        }

        private void btng_commande_Click_1(object sender, EventArgs e)
        {
            pnlcommand.Height = btng_commande.Height;
            pnlcommand.Top = btng_commande.Top;
            pnlcommand.Left = btng_commande.Left;
            btng_commande.BackColor = Color.FromArgb(46, 51, 73);
          
        }

        private void btnr_vente_Click_1(object sender, EventArgs e)
        {
            pnlcommand.Height = btnr_vente.Height;
            pnlcommand.Top = btnr_vente.Top;
            pnlcommand.Left = btnr_vente.Left;
            btnr_vente.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btng_parametre_Click_1(object sender, EventArgs e)
        {
            pnlcommand.Height = btng_parametre.Height;
            pnlcommand.Top = btng_parametre.Top;
            pnlcommand.Left = btng_parametre.Left;
            btng_parametre.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            Nom_utilisateur.Text = AccesDonnees.login;
        }

        private void btnfermerClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
