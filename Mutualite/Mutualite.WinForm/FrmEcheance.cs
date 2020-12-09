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
    public partial class FrmEcheance : Form
    {
        private Action callBack;
        private Echeance oldEcheance;
        public FrmEcheance()
        {
            InitializeComponent();
        }
        public FrmEcheance(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmEcheance(Echeance echeance, Action callBack) : this(callBack)
        {
            this.oldEcheance = echeance;
            guna2TxtTitre.Text = echeance.Titre;
            guna2TxtDescription.Text = echeance.Description.ToString();
            guna2TxtMontant.Text = echeance.Montant.ToString();
            guna2DateTimePickerDateDebut.Text = echeance.DateDebut.ToString();
            guna2DateTimePickerDateFin.Text = echeance.DateFin.ToString();
            guna2DateTimePickerDelai.Text = echeance.DelaisPayement.ToString();           
        }
        private void checkForm()
        {
            string text = string.Empty;
            guna2TxtTitre.BackColor = Color.White;
            guna2TxtDescription.BackColor = Color.White;
            guna2TxtMontant.BackColor = Color.White;           

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
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void guna2GradientCreer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                Echeance newEcheance = new Echeance
                (
                    int.Parse(guna2TxtMontant.Text),
                    guna2TxtTitre.Text.ToUpper(),
                    guna2TxtDescription.Text,
                    DateTime.Parse(guna2DateTimePickerDateDebut.Text),
                    DateTime.Parse(guna2DateTimePickerDateFin.Text),
                    DateTime.Parse(guna2DateTimePickerDelai.Text)
                );

                EcheanceBLO echeanceBLO = new EcheanceBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEcheance == null)
                    echeanceBLO.CreateEcheance(newEcheance);
                else
                    echeanceBLO.EditEcheance(oldEcheance, newEcheance);

                MessageBox.Show
                (
                    "Echeance creer !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldEcheance != null)
                    Close();

                guna2TxtTitre.Clear();
                guna2TxtDescription.Clear();
                guna2TxtMontant.Clear();
                
                guna2TxtTitre.Focus();
                Form f = new FrmEcheanceList();
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
