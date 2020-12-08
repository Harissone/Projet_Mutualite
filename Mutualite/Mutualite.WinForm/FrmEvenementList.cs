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
    public partial class FrmEvenementList : Form
    {
        private EvenementBLO evenementBLO;
        public FrmEvenementList()
        {
            InitializeComponent();
            guna2DataGridViewEvenement.AutoGenerateColumns = false;
            evenementBLO = new EvenementBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = guna2TxtSearch.Text.ToLower();
            var evenements = evenementBLO.GetBy
            (
                x =>
                x.Titre.ToLower().Contains(value) ||
                x.Description.ToLower().Contains(value)
            ).OrderBy(x => x.Titre).ToArray();
            guna2DataGridViewEvenement.DataSource = null;
            guna2DataGridViewEvenement.DataSource = evenements;
            guna2HtmlLblLigne.Text = $"{guna2DataGridViewEvenement.RowCount} lignes";
            guna2DataGridViewEvenement.ClearSelection();
        }

        private void guna2GradientBtnCreerReunion_Click(object sender, EventArgs e)
        {
            Form f = new FrmEvenement(loadData);
            f.Show();
        }

        private void guna2GradientBtnSupprimerReunion_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewEvenement.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this event ?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < guna2DataGridViewEvenement.SelectedRows.Count; i++)
                    {
                        evenementBLO.DeleteEvenement(guna2DataGridViewEvenement.SelectedRows[i].DataBoundItem as Evenement);
                    }
                    loadData();
                }
            }
        }

        private void guna2GradientBtnModifierReunion_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewEvenement.SelectedRows.Count > 0)
            {
                for (int i = 0; i < guna2DataGridViewEvenement.SelectedRows.Count; i++)
                {
                    Form f = new FrmEvenement
                    (
                        guna2DataGridViewEvenement.SelectedRows[i].DataBoundItem as Evenement,
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

        private void FrmEvenementList_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
