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
    public partial class FrmEvenement : Form
    {
        public FrmEvenement()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Evenement evenement = new Evenement
            (
                txtTitre.Text,
                rtbDescription.Text,
                dtpDate.Value,
                txtLieu.Text,
                int.Parse(txtMontant.Text)
             );

            EvenementBLO evenementBLO = new EvenementBLO();
            evenementBLO.CreateEvenement(evenement);

            MessageBox.Show
            (
                "evenement creer avec succes!",
                "Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
