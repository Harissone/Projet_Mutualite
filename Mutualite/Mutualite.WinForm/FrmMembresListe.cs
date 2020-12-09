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
    public partial class FrmMembresListe : Form
    {
       
        private MembreBLO membreBLO;
        public FrmMembresListe()
        {
            InitializeComponent();
            guna2DataGridViewEvenement.AutoGenerateColumns = false;
           membreBLO = new MembreBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }
        private void loadData()
        {
            string value = guna2TxtSearch.Text.ToLower();
            var membres = membreBLO.GetBy
            (
                x =>
                x.Username.ToLower().Contains(value)    
            ).OrderBy(x => x.Username).ToArray();
            guna2DataGridViewEvenement.DataSource = null;
            guna2DataGridViewEvenement.DataSource = membres;
            guna2HtmlLblLigne.Text = $"{guna2DataGridViewEvenement.RowCount} lignes";
            guna2DataGridViewEvenement.ClearSelection();
        }

        private void FrmMembresListe_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnaddmember_Click(object sender, EventArgs e)
        {
            FrmMembre fm = new FrmMembre();
            fm.Show();
            this.Hide();
        }

        private void btndeletemem_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewEvenement.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this member ?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < guna2DataGridViewEvenement.SelectedRows.Count; i++)
                    {
                        membreBLO.DeleteMembre(guna2DataGridViewEvenement.SelectedRows[i].DataBoundItem as Membre);
                    }
                    loadData();
                }
            }
        }

        private void btnmodifymem_Click(object sender, EventArgs e)
        {
            if (guna2DataGridViewEvenement.SelectedRows.Count > 0)
            {
                for (int i = 0; i < guna2DataGridViewEvenement.SelectedRows.Count; i++)
                {
                   FrmMembre fr = new FrmMembre
                          (
                        guna2DataGridViewEvenement.SelectedRows[i].DataBoundItem as Membre,
                        loadData
                    );
                    fr.ShowDialog();

                }
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TxtSearch.Text))
                loadData();
            else
                guna2TxtSearch.Clear();
        }
    }
}
