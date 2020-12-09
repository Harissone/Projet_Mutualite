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
    public partial class FrmReunionAccess : Form
    {
        public FrmReunionAccess()
        {
            InitializeComponent();
        }

        private void btnCreateMeeting_Click(object sender, EventArgs e)
        {
            FrmReunion fr = new FrmReunion();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmReunionList frl = new FrmReunionList();
            frl.Show();
            this.Hide();
        }
    }
}
