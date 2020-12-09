using Mutualite.BO;
using Mutualite.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mutualite.WinForm
{
    public partial class FrmEnregistrerVersementList : Form
    {
        private CaisseBLO caisseBLO;
        public FrmEnregistrerVersementList()
        {
            InitializeComponent();
            guna2DataGridViewVersement.AutoGenerateColumns = false;
            caisseBLO = new CaisseBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = guna2TxtSearch.Text.ToLower();
            var caisses = caisseBLO.GetBy
            (
                x =>
                x.Compte.ToLower().Contains(value) ||
                x.ModePayement.ToLower().Contains(value)
            ).OrderBy(x => x.Compte).ToArray();
            guna2DataGridViewVersement.DataSource = null;
            guna2DataGridViewVersement.DataSource = caisses;
            guna2HtmlLblLigne.Text = $"{guna2DataGridViewVersement.RowCount} lignes";
            guna2DataGridViewVersement.ClearSelection();
        }

        private void guna2GradientBtnNouveau_Click(object sender, EventArgs e)
        {
            Form f = new FrmEnregistrerVersement(loadData);
            f.Show();
        }

        private void guna2GradientBtnSupprimerVersement_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewVersement.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this cash register ?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < guna2DataGridViewVersement.SelectedRows.Count; i++)
                    {
                        caisseBLO.DeleteCaisse(guna2DataGridViewVersement.SelectedRows[i].DataBoundItem as Caisse);
                    }
                    loadData();
                }
            }
        }

        private void guna2GradientBtnModifierVersement_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewVersement.SelectedRows.Count > 0)
            {
                for (int i = 0; i < guna2DataGridViewVersement.SelectedRows.Count; i++)
                {
                    Form f = new FrmEnregistrerVersement
                    (
                        guna2DataGridViewVersement.SelectedRows[i].DataBoundItem as Caisse,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void guna2GradientBtnRafraichir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TxtSearch.Text))
                loadData();
            else
                guna2TxtSearch.Clear();
        }

        private void guna2TxtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void FrmEnregistrerVersementList_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
