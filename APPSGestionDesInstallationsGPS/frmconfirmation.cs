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
    public partial class frmConfirmation : Form
    {
        AccesDonnees a = new AccesDonnees();
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void texte_confirm_Click(object sender, EventArgs e)
        {

        }

        private void frmconfirmation_Load(object sender, EventArgs e)
        {
            texte_confirm.Text = AccesDonnees.confirmation;
        }
    }
}
