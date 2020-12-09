using Mutualite.BLL;
using Mutualite.BO;
using Mutualite.DAL;
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
    public partial class FrmUser : Form
    {
        private Action callBack;
        private User oldUser;
        public FrmUser()
        {
            InitializeComponent();
        }
        public FrmUser(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmUser(User user, Action callBack) : this(callBack)
        {
            this.oldUser = user;
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password.ToString();       

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form f = new FrmAccount();
            f.Show();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserBLO userBLO;
                foreach (var user in UserDAO.users)
                {
                    if (user.Username.Equals(txtUsername.Text, StringComparison.OrdinalIgnoreCase) && user.Password.Equals(txtPassword.Text))
                    {
                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();

                        Form f = new FrmParent();
                        f.Show();
                       
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show
                           (
                               "Please Create your account",
                               "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                           );

                        Form f = new FrmAccount();
                        f.Show();
                    }
                }
            }
            catch
            {
                        MessageBox.Show
                           (
                               "Account not exist",
                               "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                           );
            }
           
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {

        }
    }
}
