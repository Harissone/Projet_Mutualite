using Mutualite.BLL;
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
                x.TypeRencontre.ToLower().Contains(value) ||
                x.DureeCycle.ToLower().Contains(value)
            ).OrderBy(x => x.TypeRencontre).ToArray();
            guna2DataGridViewCycle.DataSource = null;
            guna2DataGridViewCycle.DataSource = cycles;
            guna2HtmlLblLigne.Text = $"{guna2DataGridViewCycle.RowCount} lignes";
            guna2DataGridViewCycle.ClearSelection();
        }

        private void guna2TxtSearch_TextChanged(object sender, EventArgs e)
        {
            //loadData();
        }

        private void guna2GradientBtnSupprimerCycle_Click(object sender, EventArgs e)
        {

        }
    }
}
