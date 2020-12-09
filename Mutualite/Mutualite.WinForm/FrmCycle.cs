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
    public partial class FrmCycle : Form
    {
        private Action callBack;
        private Cycle oldCycle;
        public FrmCycle()
        {
            InitializeComponent();
        }
        public FrmCycle(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmCycle(Cycle cycle, Action callBack) : this(callBack)
        {
            this.oldCycle = cycle;
            guna2TxtDureeCycle.Text = cycle.DureeCycle;
            guna2ComboBoxFrequenceAssemble.Text = cycle.DureeCycle.ToString();
            guna2ComboBoxTypeRencontre.Text = cycle.TypeRencontre.ToString();
            guna2ComboBoxJourSemaine.Text = cycle.JourSemaine.ToString();
            guna2DateTimePickerDatePremiereRencontre.Text = cycle.DatePremiereRencontre.ToString();
            guna2DateTimePickerHeureRencontre.Text = cycle.HeureAssemble.ToString();
            guna2TxtSanctionRetard.Text = cycle.SanctionRetard.ToString();
            guna2TxtSanctionAbsence.Text = cycle.SanctionAbsence.ToString();
        }
        private void checkForm()
        {
            string text = string.Empty;
            guna2TxtDureeCycle.BackColor = Color.White;
            guna2ComboBoxTypeRencontre.BackColor = Color.White;
            guna2ComboBoxJourSemaine.BackColor = Color.White;
            guna2ComboBoxFrequenceAssemble.BackColor = Color.White;
            guna2DateTimePickerDatePremiereRencontre.BackColor = Color.White;
            guna2DateTimePickerHeureRencontre.BackColor = Color.White;
            guna2HtmlLblSanctionAbsence.BackColor = Color.White;
            guna2TxtSanctionRetard.BackColor = Color.White;

            if (string.IsNullOrWhiteSpace(guna2TxtDureeCycle.Text))
            {
                text += "- Please enter the cycle time ! \n";
                guna2TxtDureeCycle.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2ComboBoxTypeRencontre.Text))
            {
                text += "- Please enter the meeting type ! \n";
                guna2ComboBoxTypeRencontre.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2ComboBoxJourSemaine.Text))
            {
                text += "- Please enter the day ! \n";
                guna2ComboBoxJourSemaine.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2ComboBoxFrequenceAssemble.Text))
            {
                text += "- Please enter the frequence! \n";
                guna2ComboBoxFrequenceAssemble.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2DateTimePickerDatePremiereRencontre.Text))
            {
                text += "- Please enter the date of first meeting ! \n";
                guna2DateTimePickerDatePremiereRencontre.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2DateTimePickerHeureRencontre.Text))
            {
                text += "- Please enter the hour ! \n";
                guna2DateTimePickerHeureRencontre.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2HtmlLblSanctionAbsence.Text))
            {
                text += "- Please enter the sanction  ! \n";
                guna2HtmlLblSanctionAbsence.BackColor = Color.Pink;
            }
            if (string.IsNullOrWhiteSpace(guna2TxtSanctionRetard.Text))
            {
                text += "- Please enter the sanction  ! \n";
                guna2TxtSanctionRetard.BackColor = Color.Pink;
            }
            if (!string.IsNullOrEmpty(text))
                throw new TypingException(text);
        }


        private void guna2GradientCreer_Click(object sender, EventArgs e)
        {
            try
            {
                checkForm();

                    Cycle newCycle = new Cycle
                (
                    guna2TxtDureeCycle.Text,
                    guna2ComboBoxFrequenceAssemble.Text,
                    guna2ComboBoxTypeRencontre.Text,
                    guna2ComboBoxJourSemaine.Text,
                    DateTime.Parse(guna2DateTimePickerDatePremiereRencontre.Text),
                    DateTime.Parse(guna2DateTimePickerHeureRencontre.Text),
                    int.Parse(guna2TxtSanctionRetard.Text),
                    int.Parse(guna2TxtSanctionAbsence.Text)                               
                );

                CycleBLO cycleBLO = new CycleBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldCycle == null)
                    cycleBLO.CreateCycle(newCycle);
                else
                    cycleBLO.EditCycle(oldCycle, newCycle);

                MessageBox.Show
                (
                    "Cycle creer !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldCycle != null)
                    Close();

                guna2TxtDureeCycle.Clear();

                guna2TxtSanctionRetard.Clear();

                guna2TxtSanctionAbsence.Focus();
                Form f = new FrmCycleList();
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
