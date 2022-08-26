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
    public partial class frmerreur : Form
    {
        AccesDonnees a = new AccesDonnees();
        public frmerreur()
        {
            InitializeComponent();
        }

        private void frmerreur_Load(object sender, EventArgs e)
        {
            texte_erreur.Text=AccesDonnees.erreur;           
        }
    }
}
