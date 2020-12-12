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
    public partial class FrmReunion : Form
    {
        private Action callBack;
        private Reunion oldReunion;
        public FrmReunion()
        {
            InitializeComponent();
        }
        public FrmReunion(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmReunion(Reunion reunion, Action callBack) : this(callBack)
        {
            this.oldReunion = reunion;
            guna2TxtNomReunion.Text = reunion.NomReunion;
            guna2TxtDescription.Text = reunion.DescriptionTontine.ToString();
            guna2ComboBoxTypeReunion.Text = reunion.TypeTontine;
            guna2TxtMontant.Text = reunion.MontantMinimum.ToString();
            guna2DateTimePicker1.Text = reunion.DateTontine.ToString();
            guna2TxtPenaliter.Text = reunion.Penalite.ToString();


        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientCreer_Click(object sender, EventArgs e)
        {
            try
            {
                    checkForm();

                    Reunion newReunion = new Reunion
                    (
                        guna2TxtNomReunion.Text.ToUpper(),
                        guna2TxtDescription.Text,
                        guna2ComboBoxTypeReunion.Text,
                        int.Parse(guna2TxtMontant.Text),
                        DateTime.Parse(guna2DateTimePicker1.Text),
                        int.Parse(guna2TxtPenaliter.Text)
                    );

                    ReunionBLO reunionBLO = new ReunionBLO(ConfigurationManager.AppSettings["DbFolder"]);

                    if (this.oldReunion == null)
                        reunionBLO.CreateReunion(newReunion);
                    else
                        reunionBLO.EditReunion(oldReunion, newReunion);

                    MessageBox.Show
                    (
                        "Reunion creer !",
                        "Confirmation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    if (callBack != null)
                        callBack();

                    if (oldReunion != null)
                        Close();

                    guna2TxtNomReunion.Clear();
                    guna2TxtDescription.Clear();
                    guna2TxtMontant.Clear();
                    guna2TxtPenaliter.Clear();
                    guna2TxtNomReunion.Focus();
               
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
            guna2TxtNomReunion.BackColor = Color.White;
            guna2TxtDescription.BackColor = Color.White;
            guna2TxtMontant.BackColor = Color.White;
            guna2TxtPenaliter.BackColor = Color.White;
            
            if (string.IsNullOrWhiteSpace(guna2TxtNomReunion.Text))
            {
                text += "- Please enter the title ! \n";
                guna2TxtNomReunion.BackColor = Color.Pink;
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
            if (string.IsNullOrWhiteSpace(guna2TxtPenaliter.Text))
            {
                text += "- Please enter the penalitie ! \n";
                guna2TxtPenaliter.BackColor = Color.Pink;
            }       

            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }

        private void guna2TxtNomReunion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmReunion_Load(object sender, EventArgs e)
        {

        }
    }
}
