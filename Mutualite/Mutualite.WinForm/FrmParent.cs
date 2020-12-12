using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mutualite.BO;

namespace Mutualite.WinForm
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
            
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
            guna2PanelContainer.Controls.Add(childForm);
            guna2PanelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ButtonParametre_Click(object sender, EventArgs e)
        {
            //openChildForm(new FrmAssembleList());
        }

        private void guna2ButtonSeance_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCycle());
        }

        private void guna2ButtonEcheance_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEcheanceList());
        }

        private void guna2ButtonEvenement_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEvenementList());
        }

        private void guna2ButtonReunion_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmReunionList());
            
        }

        private void guna2ButtonExit_Click(object sender, EventArgs e)
        {
            
            Form f = new FrmAccount();
            f.Show();
            this.Hide();
            
        }

        private void guna2ButtonAcceuil_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form f = new FrmAccount();
            f.Show();
            this.Hide();
        }

        private void FrmParent_Load(object sender, EventArgs e)
        {
         
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2BtnAssembleGenerale_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAssembleList());
        }
    }
}
