﻿using System;
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
    public partial class frmenrg_techniciens : Form
    {
        AccesDonnees a = new AccesDonnees();
        string requete="";
        int lematricule = 0;
        public frmenrg_techniciens()
        {
            InitializeComponent();
          
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {            
            requete = "INSERT INTO `technicien`(`Nom`, `prenom`, `Adresse`, `num_tel`) VALUES ('" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtAdresse.Text + "','" + txtTelephone.Text + "')";
            a.ExecuteRequette(requete);
            chargement();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {

            txtid_technicien.Text = (lematricule).ToString();
            requete = "UPDATE technicien SET Nom='" + txtNom.Text + "', prenom='" + txtPrenom.Text + "', Adresse='" + txtAdresse.Text + "', num_tel='" + txtTelephone.Text + "' WHERE id_technicien='" + lematricule + "'";
            a.ExecuteRequette(requete);
            chargement();
           
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            requete = "DELETE FROM technicien WHERE id_technicien = '" + lematricule + "'";
            a.ExecuteRequette(requete);            
            chargement();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void chargement()
        {
            requete = "select * from technicien ";
            a.ChargeTable(dataGridView1, requete);
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtAdresse.Text = "";
            txtTelephone.Text = "";           
            btnEnregistrer.Enabled = true;
            btnmodifier.Enabled = false;
            btnSupprimer.Enabled = false;
        }

        private void frmenrg_techniciens_Load(object sender, EventArgs e)
        {
            chargement();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_technicien.Text = (lematricule).ToString();
            lematricule = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            txtNom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtPrenom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtAdresse.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtTelephone.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);            
            btnEnregistrer.Enabled = false;
            btnmodifier.Enabled = true;
            btnSupprimer.Enabled = true;
           
        }
    }
}