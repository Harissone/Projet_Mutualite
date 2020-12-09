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
    public partial class FrmCycleList : Form
    {
        private CycleBLO cycleBLO;
        public FrmCycleList()
        {
            InitializeComponent();
            guna2DataGridViewCycle.AutoGenerateColumns = false;
            cycleBLO = new CycleBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = guna2TxtSearch.Text.ToLower();
            var cycles = cycleBLO.GetBy
            (
                x =>
                x.TypeRencontre.ToLower().Contains(value)
            ).OrderBy(x => x.TypeRencontre).ToArray();
            guna2DataGridViewCycle.DataSource = null;
            guna2DataGridViewCycle.DataSource = cycles;
            guna2HtmlLblLigne.Text = $"{guna2DataGridViewCycle.RowCount} lignes";
            guna2DataGridViewCycle.ClearSelection();
        }

        private void guna2TxtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void guna2GradientBtnSupprimerCycle_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewCycle.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this cycle ?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < guna2DataGridViewCycle.SelectedRows.Count; i++)
                    {
                        cycleBLO.DeleteCycle(guna2DataGridViewCycle.SelectedRows[i].DataBoundItem as Cycle);
                    }
                    loadData();
                }
            }
        }

        private void FrmCycleList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void guna2GradientBtnModifierCycle_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewCycle.SelectedRows.Count > 0)
            {
                for (int i = 0; i < guna2DataGridViewCycle.SelectedRows.Count; i++)
                {
                    Form f = new FrmCycle
                    (
                        guna2DataGridViewCycle.SelectedRows[i].DataBoundItem as Cycle,
                        loadData
                    ) ;
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
    }
}
