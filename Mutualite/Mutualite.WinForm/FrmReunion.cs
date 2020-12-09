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
    public partial class FrmReunion : Form
    {
        public FrmReunion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reunion reunion = new Reunion
            (
                txtNomReunion.Text,
                rtbDescriptionTontine.Text,
                txtTypeTontine.Text,
                int.Parse(txtMontantTontine.Text),
                dtpDate.Value,
                int.Parse(txtPenalite.Text)
            );

            ReunionBLO reunionBLO = new ReunionBLO();
            reunionBLO.CreateReunion(reunion);

            MessageBox.Show
            (
                "reunion creer avec succes!",
                "Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
