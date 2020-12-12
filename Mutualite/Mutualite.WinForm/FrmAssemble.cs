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
    public partial class FrmAssemble : Form
    {
        private Action callBack;
        private Assemble oldAssemble;
        public FrmAssemble()
        {
            InitializeComponent();
        }
        public FrmAssemble(Action callBack) : this()
        {
            this.callBack = callBack;
        }
        public FrmAssemble(Assemble assemble, Action callBack) : this(callBack)
        {
            this.oldAssemble = assemble;
            guna2TxtHote.Text = assemble.Hote;
            guna2DateTimePickerDatePremiereRencontre.Text = assemble.DateAssemble.ToString();
            guna2DateTimePickerHeureAssemble.Text = assemble.HeureAssemble.ToString();
            guna2ComboBoxTypeAssemble.Text = assemble.TypeAssemble.ToString();
            guna2TxtSanctionRetard.Text = assemble.SanctionRetard.ToString();
            guna2TxtSanctionAbsence.Text = assemble.SanctionAbsence.ToString();
        }

        private void guna2GradientCreer_Click(object sender, EventArgs e)
        {
            try
            {
                // checkForm();

                Assemble newAssemble = new Assemble
            (
                guna2TxtHote.Text,                
                DateTime.Parse(guna2DateTimePickerDatePremiereRencontre.Text),
                DateTime.Parse(guna2DateTimePickerHeureAssemble.Text),
                guna2ComboBoxTypeAssemble.Text,
                guna2TxtSanctionRetard.Text,
                guna2TxtSanctionAbsence.Text
            );

                AssembleBLO assembleBLO = new AssembleBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldAssemble == null)
                    assembleBLO.CreateAssemble(newAssemble);
                else
                    assembleBLO.EditAssemble(oldAssemble, newAssemble);

                MessageBox.Show
                (
                    "Assembler creer !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldAssemble != null)
                    Close();

                guna2TxtHote.Clear();
               
                guna2TxtSanctionRetard.Clear();

                guna2TxtSanctionAbsence.Focus();
               
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
