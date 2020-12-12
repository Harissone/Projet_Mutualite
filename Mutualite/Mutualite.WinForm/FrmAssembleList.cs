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
    public partial class FrmAssembleList : Form
    {
        private AssembleBLO assembleBLO;
        public FrmAssembleList()
        {
            InitializeComponent();
            guna2DataGridViewVersement.AutoGenerateColumns = false;
            assembleBLO = new AssembleBLO(ConfigurationManager.AppSettings["DbFolder"]);
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
            guna2PanelContainerAssemble.Controls.Add(childForm);
            guna2PanelContainerAssemble.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void loadData()
        {
            string value = guna2TxtSearch.Text.ToLower();
            var assembles = assembleBLO.GetBy
            (
                x =>
                x.Hote.ToLower().Contains(value) 

            ).OrderBy(x => x.Hote).ToArray();
            guna2DataGridViewVersement.DataSource = null;
            guna2DataGridViewVersement.DataSource = assembles;
            guna2HtmlLblLigne.Text = $"{guna2DataGridViewVersement.RowCount} lignes";
            guna2DataGridViewVersement.ClearSelection();
        }

        private void guna2GradientBtnNouveau_Click(object sender, EventArgs e)
        {
            openChildForm( new FrmAssemble(loadData));
           
        }

        private void guna2GradientBtnSupprimerAssemble_Click(object sender, EventArgs e)
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
                        assembleBLO.DeleteAssemble(guna2DataGridViewVersement.SelectedRows[i].DataBoundItem as Assemble);
                    }
                    loadData();
                }
            }
        }

        private void guna2GradientBtnModifierAssemble_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewVersement.SelectedRows.Count > 0)
            {
                for (int i = 0; i < guna2DataGridViewVersement.SelectedRows.Count; i++)
                {
                    Form f = new FrmAssemble
                    (
                        guna2DataGridViewVersement.SelectedRows[i].DataBoundItem as Assemble,
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

        private void FrmAssembleList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEnregistrerVersement());
           
        }

        private void guna2GradientBtnHistorique_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEnregistrerVersementList());
        }

        private void guna2GradientBtnListeAssemble_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAssembleList());
        }
    }
}
