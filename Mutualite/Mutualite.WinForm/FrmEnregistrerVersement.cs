using Mutualite.BLL;
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
    public partial class FrmEnregistrerVersement : Form
    {
        private Action callBack;
        private Caisse oldCaisse;
        public FrmEnregistrerVersement()
        {
            InitializeComponent();
        }
        public FrmEnregistrerVersement(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmEnregistrerVersement(Caisse caisse, Action callBack) : this(callBack)
        {
            this.oldCaisse = caisse;
            guna2TxtCompte.Text = caisse.Compte;
            guna2TxtMontant.Text = caisse.Montant.ToString();
            guna2DateTimePickerDateVersement.Text = caisse.DateVersement.ToString();
            guna2ComboBoxModePayement.Text = caisse.ModePayement.ToString();
            guna2TxtDescription.Text = caisse.Commentaire;

        }
        private void checkForm()
        {
            string text = string.Empty;
            guna2TxtCompte.BackColor = Color.White;
            guna2TxtMontant.BackColor = Color.White;
            guna2DateTimePickerDateVersement.BackColor = Color.White;
            guna2ComboBoxModePayement.BackColor = Color.White;
            guna2TxtDescription.BackColor = Color.White;
            
            if (string.IsNullOrWhiteSpace(guna2TxtCompte.Text))
            {
                text += "- Please enter your account name ! \n";
                guna2TxtCompte.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2TxtMontant.Text))
            {
                text += "- Please enter the mount ! \n";
                guna2TxtMontant.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2DateTimePickerDateVersement.Text))
            {
                text += "- Please enter the date ! \n";
                guna2DateTimePickerDateVersement.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2ComboBoxModePayement.Text))
            {
                text += "- Please enter the mode! \n";
                guna2ComboBoxModePayement.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2TxtDescription.Text))
            {
                text += "- Please enter the description! \n";
                guna2TxtDescription.BackColor = Color.Pink;
            }
            
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientCreer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                    Caisse newCaisse = new Caisse
                (
                    guna2TxtCompte.Text,
                    int.Parse(guna2TxtMontant.Text),
                    DateTime.Parse(guna2DateTimePickerDateVersement.Text),
                    guna2ComboBoxModePayement.Text,
                    guna2TxtDescription.Text               
                );

                CaisseBLO caisseBLO = new CaisseBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldCaisse == null)
                    caisseBLO.CreateCaisse(newCaisse);
                else
                    caisseBLO.EditCaisse(oldCaisse, newCaisse);

                MessageBox.Show
                (
                    "Cotisation effectuer !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldCaisse != null)
                    Close();

                guna2TxtCompte.Clear();

                guna2TxtDescription.Clear();

                guna2TxtCompte.Focus();
               
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
    }
}
