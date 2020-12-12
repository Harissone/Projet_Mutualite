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
using Mutualite.BLL;
using Mutualite.BO;

namespace Mutualite.WinForm
{
    public partial class FrmMembre : Form
    {
        private Action callBack;
        private Membre oldMembre;
        public FrmMembre()
        {
            InitializeComponent();
        }
        public FrmMembre(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmMembre(Membre membre, Action callBack) : this(callBack)
        {
            this.oldMembre = membre;
            txtbxnom.Text = membre.Nom;
            
            txtbxemail.Text = membre.Email.ToString();
            txtbxtelephone.Text = membre.Telephone.ToString();
        }
        private void checkForm()
        {
            string text = string.Empty;
            txtbxnom.BackColor = Color.White;
            
            txtbxemail.BackColor = Color.White;
            txtbxtelephone.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(txtbxnom.Text))
            {
                text += "- Please enter your name ! \n";
                txtbxnom.BackColor = Color.Pink;
            }
           
            
            if (string.IsNullOrWhiteSpace(txtbxemail.Text))
            {
                text += "- Please enter your email ! \n";
                txtbxemail.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(txtbxtelephone.Text))
            {
                text += "- Please enter your phone contact ! \n";
                txtbxtelephone.BackColor = Color.Pink;
            }
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }
        private void guna2GradientCreer_Click(object sender, EventArgs e)
        {

            try
            {
                checkForm();

                Membre newMembre = new Membre
                (
                    txtbxnom.Text.ToUpper(),     
                      txtbxemail.Text,
                  
                   
                    int.Parse(txtbxtelephone.Text)
                );

              MembreBLO membreBLO = new MembreBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldMembre == null)
                    membreBLO.CreateMembre(newMembre);
                else
                    membreBLO.EditMembre(oldMembre, newMembre);

                MessageBox.Show
                (
                    "Membre ajouter !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldMembre != null)
                    Close();

                txtbxnom.Clear();

                txtbxnom.Focus(); ;
                txtbxemail.Clear();
                txtbxtelephone.Focus();
               
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

        private void FrmMembre_Load(object sender, EventArgs e)
        {

        }
    }
    
}
