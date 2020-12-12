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
    public partial class FrmCaisseList : Form
    {
        private CaisseBLO caisseBLO;
        public FrmCaisseList()
        {
            InitializeComponent();
            guna2DataGridViewCaisse.AutoGenerateColumns = false;
            caisseBLO = new CaisseBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            guna2PanelContainerCaisse.Controls.Add(childForm);
            guna2PanelContainerCaisse.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            guna2DataGridViewCaisse.DataSource = null;
            guna2DataGridViewCaisse.DataSource = caisses;
            guna2HtmlLblLigne.Text = $"{guna2DataGridViewCaisse.RowCount} lignes";
            guna2DataGridViewCaisse.ClearSelection();
        }

        private void guna2GradientBtnNouveau_Click(object sender, EventArgs e)
        {
            Form f = new FrmEnregistrerVersement(loadData);
            f.Show();
        }

        private void guna2GradientBtnSupprimerVersement_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewCaisse.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this ?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < guna2DataGridViewCaisse.SelectedRows.Count; i++)
                    {
                        caisseBLO.DeleteCaisse(guna2DataGridViewCaisse.SelectedRows[i].DataBoundItem as Caisse);
                    }
                    loadData();
                }
            }
        }

        private void guna2GradientBtnModifierVersement_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewCaisse.SelectedRows.Count > 0)
            {
                for (int i = 0; i < guna2DataGridViewCaisse.SelectedRows.Count; i++)
                {
                    Form f = new FrmEnregistrerVersement
                    (
                        guna2DataGridViewCaisse.SelectedRows[i].DataBoundItem as Caisse,
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

        private void FrmCaisseList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void guna2TxtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void guna2GradientBtnNouveau_Click_1(object sender, EventArgs e)
        {
            openChildForm( new FrmEnregistrerVersement(loadData));
        }

        private void guna2GradientBtnSupprimerVersement_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridViewCaisse.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this ?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < guna2DataGridViewCaisse.SelectedRows.Count; i++)
                    {
                        caisseBLO.DeleteCaisse(guna2DataGridViewCaisse.SelectedRows[i].DataBoundItem as Caisse);
                    }
                    loadData();
                }
            }
        }

        private void guna2GradientBtnModifierVersement_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridViewCaisse.SelectedRows.Count > 0)
            {
                for (int i = 0; i < guna2DataGridViewCaisse.SelectedRows.Count; i++)
                {
                    Form f = new FrmEnregistrerVersement
                    (
                        guna2DataGridViewCaisse.SelectedRows[i].DataBoundItem as Caisse,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }

        private void guna2GradientBtnRafraichir_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TxtSearch.Text))
                loadData();
            else
                guna2TxtSearch.Clear();
        }

        private void guna2TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
