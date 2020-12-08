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
using DocumentFormat.OpenXml.Spreadsheet;
using Mutualite.BLL;
using Mutualite.BO;
using Mutualite.DAL;

namespace Mutualite.WinForm
{
    public partial class FrmAccount : Form
    {
        //private static List<User> users;
        private Action callBack;
        private User oldUser;
        public FrmAccount()
        {
            InitializeComponent();
            
        }
        public FrmAccount(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmAccount(User user, Action callBack) : this(callBack)
        {
            this.oldUser = user;
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form f = new FrmUser();
            f.Show();
        }

        private void txtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();
                txtUsername.Focus();

                 if (txtPassword != txtConfirmPassword &&
                     string.IsNullOrEmpty(txtUsername.Text) &&
                     string.IsNullOrEmpty(txtPassword.Text) &&
                     string.IsNullOrEmpty(txtConfirmPassword.Text))
                 {
                         MessageBox.Show
                        (
                            "- Please Confirm password !" +
                            "- field can't empty",
                            "Error",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error
                        );
                 }
                 else
                 {
                        User newUser = new User
                            (
                                txtUsername.Text.ToUpper(),
                                txtPassword.Text,
                                txtConfirmPassword.Text
                            );

                            UserBLO userBLO = new UserBLO(ConfigurationManager.AppSettings["DbFolder"]);

                            if (this.oldUser == null)
                                userBLO.CreateUser(newUser);
                            else
                                userBLO.EditUser(oldUser, newUser);

                            MessageBox.Show
                         (
                             "Save done",
                             "Confirmation",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information
                         );

                            if (callBack != null)
                                callBack();

                            if (oldUser != null)
                                Close();
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtConfirmPassword.Clear();
                    this.Hide();
                           
                    }         

            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }

        }
        private void checkForm()
        {
            string text = string.Empty;
            txtUsername.BackColor = System.Drawing.Color.White;
            txtPassword.BackColor = System.Drawing.Color.White;
            txtConfirmPassword.BackColor = System.Drawing.Color.White;

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                text += "- Please enter your username ! \n";
                txtUsername.BackColor = System.Drawing.Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                text += "- Please enter your password  ! \n";
                txtPassword.BackColor = System.Drawing.Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                text += "- Please enter your confirm password  ! \n";
                txtConfirmPassword.BackColor = System.Drawing.Color.Pink;
            }


            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
