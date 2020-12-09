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
    public partial class FrmEvenement : Form
    {
        private Action callBack;
        private Evenement oldEvenement;
        public FrmEvenement()
        {
            InitializeComponent();
        }
        public FrmEvenement(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmEvenement(Evenement evenement, Action callBack) : this(callBack)
        {
            this.oldEvenement = evenement;
            guna2TxtTitre.Text = evenement.Titre;
            guna2TxtDescription.Text = evenement.Description.ToString();
            guna2TxtMontant.Text = evenement.Montant.ToString();
            guna2DateTimePickerDateEvenement.Text = evenement.Date.ToString();   
            guna2TxtLieux.Text = evenement.Lieu.ToString();
        }
        private void checkForm()
        {
            string text = string.Empty;
            guna2TxtTitre.BackColor = Color.White;
            guna2TxtDescription.BackColor = Color.White;
            guna2TxtMontant.BackColor = Color.White;
            guna2TxtLieux.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(guna2TxtTitre.Text))
            {
                text += "- Please enter the title ! \n";
                guna2TxtTitre.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2TxtDescription.Text))
            {
                text += "- Please enter the description ! \n";
                guna2TxtDescription.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2TxtMontant.Text))
            {
                text += "- Please enter the mount ! \n";
                guna2TxtMontant.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2TxtLieux.Text))
            {
                text += "- Please enter the mount ! \n";
                guna2TxtLieux.BackColor = Color.Pink;
            }
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void FrmEvenement_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientCreer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                Evenement newEvenement = new Evenement
                (
                    guna2TxtTitre.Text,
                    guna2TxtDescription.Text,
                    DateTime.Parse(guna2DateTimePickerDateEvenement.Text),
                    guna2TxtLieux.Text,
                    int.Parse(guna2TxtMontant.Text)
                );

                EvenementBLO evenementBLO = new EvenementBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEvenement == null)
                    evenementBLO.CreateEvenement(newEvenement);
                else
                    evenementBLO.EditEvenement(oldEvenement, newEvenement);

                MessageBox.Show
                (
                    "Echeance creer !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldEvenement != null)
                    Close();

                guna2TxtTitre.Clear();
                guna2TxtDescription.Clear();
                guna2TxtMontant.Clear();
                guna2TxtLieux.Clear();

                guna2TxtTitre.Focus();
                Form f = new FrmEvenementList();
                f.Show();
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
