using Mutualite.BLL;
using Mutualite.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutualite.WinForm
{
    public partial class FrmMembre : Form
    {
        public FrmMembre()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Membre membre = new Membre
            (
                txtNom.Text,
                int.Parse(txtTelephone.Text),
                txtEmail.Text
            );

            MembreBLO membreBLO = new MembreBLO();
            membreBLO.CreateMembre(membre);

            MessageBox.Show
            (
                "nouveau mambre ajouter avce succes!",
                "Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
