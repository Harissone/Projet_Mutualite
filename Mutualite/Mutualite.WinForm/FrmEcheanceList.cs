using Mutualite.BLL;
using Mutualite.BO;
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
    public partial class FrmEcheanceList : Form
    {
        private EcheanceBLO echeanceBLO;
        public FrmEcheanceList()
        {
            InitializeComponent();
            guna2DataGridViewEcheance.AutoGenerateColumns = false;
            echeanceBLO = new EcheanceBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = guna2TxtSearch.Text.ToLower();
            var echeances = echeanceBLO.GetBy
            (
                x =>
                x.Titre.ToLower().Contains(value) ||
                x.Description.ToLower().Contains(value)
            ).OrderBy(x => x.Titre).ToArray();
            guna2DataGridViewEcheance.DataSource = null;
            guna2DataGridViewEcheance.DataSource = echeances;
            guna2HtmlLblLigne.Text = $"{guna2DataGridViewEcheance.RowCount} lignes";
            guna2DataGridViewEcheance.ClearSelection();
        }

        private void guna2GradientBtnCreerReunion_Click(object sender, EventArgs e)
        {
            Form f = new FrmEcheance(loadData);
            f.Show();
        }

        private void guna2GradientBtnSupprimerEcheance_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewEcheance.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this echeance ?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < guna2DataGridViewEcheance.SelectedRows.Count; i++)
                    {
                        echeanceBLO.DeleteEcheance(guna2DataGridViewEcheance.SelectedRows[i].DataBoundItem as Echeance);
                    }
                    loadData();
                }
            }
        }

        private void guna2GradientBtnModifierEcheance_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewEcheance.SelectedRows.Count > 0)
            {
                for (int i = 0; i < guna2DataGridViewEcheance.SelectedRows.Count; i++)
                {
                    Form f = new FrmEcheance
                    (
                        guna2DataGridViewEcheance.SelectedRows[i].DataBoundItem as Echeance,
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

        private void FrmEcheanceList_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
