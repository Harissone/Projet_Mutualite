﻿
namespace Mutualite.WinForm
{
    partial class FrmEvenement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GradientCreer = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLblLieu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TxtLieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLblMontant = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TxtMontant = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabelDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TxtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabelNomReunion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TxtTitre = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabelCreationTontine = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2GradientCreer);
            this.guna2ShadowPanel1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLblDate);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLblLieu);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TxtLieu);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLblMontant);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TxtMontant);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabelDescription);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TxtDescription);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabelNomReunion);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TxtTitre);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(52, 68);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(587, 487);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // guna2GradientCreer
            // 
            this.guna2GradientCreer.Animated = true;
            this.guna2GradientCreer.BorderRadius = 20;
            this.guna2GradientCreer.CheckedState.Parent = this.guna2GradientCreer;
            this.guna2GradientCreer.CustomImages.Parent = this.guna2GradientCreer;
            this.guna2GradientCreer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientCreer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientCreer.ForeColor = System.Drawing.Color.White;
            this.guna2GradientCreer.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientCreer.HoverState.Parent = this.guna2GradientCreer;
            this.guna2GradientCreer.Location = new System.Drawing.Point(201, 417);
            this.guna2GradientCreer.Name = "guna2GradientCreer";
            this.guna2GradientCreer.ShadowDecoration.Parent = this.guna2GradientCreer;
            this.guna2GradientCreer.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientCreer.TabIndex = 12;
            this.guna2GradientCreer.Text = "Creer";
            this.guna2GradientCreer.Click += new System.EventHandler(this.guna2GradientCreer_Click);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderRadius = 20;
            this.guna2DateTimePicker1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(34, 247);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(531, 36);
            this.guna2DateTimePicker1.TabIndex = 4;
            this.guna2DateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2DateTimePicker1.UseTransparentBackground = true;
            this.guna2DateTimePicker1.Value = new System.DateTime(2020, 12, 8, 17, 54, 26, 488);
            // 
            // guna2HtmlLblDate
            // 
            this.guna2HtmlLblDate.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLblDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLblDate.Location = new System.Drawing.Point(43, 222);
            this.guna2HtmlLblDate.Name = "guna2HtmlLblDate";
            this.guna2HtmlLblDate.Size = new System.Drawing.Size(128, 19);
            this.guna2HtmlLblDate.TabIndex = 11;
            this.guna2HtmlLblDate.Text = "Date de l\'evenement";
            // 
            // guna2HtmlLblLieu
            // 
            this.guna2HtmlLblLieu.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLblLieu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLblLieu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLblLieu.Location = new System.Drawing.Point(43, 133);
            this.guna2HtmlLblLieu.Name = "guna2HtmlLblLieu";
            this.guna2HtmlLblLieu.Size = new System.Drawing.Size(124, 19);
            this.guna2HtmlLblLieu.TabIndex = 9;
            this.guna2HtmlLblLieu.Text = "Lieu de l\'evenement";
            // 
            // guna2TxtLieu
            // 
            this.guna2TxtLieu.BorderRadius = 20;
            this.guna2TxtLieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtLieu.DefaultText = "";
            this.guna2TxtLieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtLieu.DisabledState.Parent = this.guna2TxtLieu;
            this.guna2TxtLieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtLieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtLieu.FocusedState.Parent = this.guna2TxtLieu;
            this.guna2TxtLieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtLieu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TxtLieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtLieu.HoverState.Parent = this.guna2TxtLieu;
            this.guna2TxtLieu.Location = new System.Drawing.Point(34, 158);
            this.guna2TxtLieu.Name = "guna2TxtLieu";
            this.guna2TxtLieu.PasswordChar = '\0';
            this.guna2TxtLieu.PlaceholderText = "";
            this.guna2TxtLieu.SelectedText = "";
            this.guna2TxtLieu.ShadowDecoration.Parent = this.guna2TxtLieu;
            this.guna2TxtLieu.Size = new System.Drawing.Size(531, 36);
            this.guna2TxtLieu.TabIndex = 3;
            // 
            // guna2HtmlLblMontant
            // 
            this.guna2HtmlLblMontant.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLblMontant.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLblMontant.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLblMontant.Location = new System.Drawing.Point(374, 48);
            this.guna2HtmlLblMontant.Name = "guna2HtmlLblMontant";
            this.guna2HtmlLblMontant.Size = new System.Drawing.Size(122, 19);
            this.guna2HtmlLblMontant.TabIndex = 7;
            this.guna2HtmlLblMontant.Text = "Montant necessaire";
            // 
            // guna2TxtMontant
            // 
            this.guna2TxtMontant.BorderRadius = 20;
            this.guna2TxtMontant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtMontant.DefaultText = "";
            this.guna2TxtMontant.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtMontant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtMontant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtMontant.DisabledState.Parent = this.guna2TxtMontant;
            this.guna2TxtMontant.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtMontant.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtMontant.FocusedState.Parent = this.guna2TxtMontant;
            this.guna2TxtMontant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtMontant.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TxtMontant.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtMontant.HoverState.Parent = this.guna2TxtMontant;
            this.guna2TxtMontant.Location = new System.Drawing.Point(365, 73);
            this.guna2TxtMontant.Name = "guna2TxtMontant";
            this.guna2TxtMontant.PasswordChar = '\0';
            this.guna2TxtMontant.PlaceholderText = "";
            this.guna2TxtMontant.SelectedText = "";
            this.guna2TxtMontant.ShadowDecoration.Parent = this.guna2TxtMontant;
            this.guna2TxtMontant.Size = new System.Drawing.Size(200, 36);
            this.guna2TxtMontant.TabIndex = 1;
            // 
            // guna2HtmlLabelDescription
            // 
            this.guna2HtmlLabelDescription.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabelDescription.Location = new System.Drawing.Point(43, 314);
            this.guna2HtmlLabelDescription.Name = "guna2HtmlLabelDescription";
            this.guna2HtmlLabelDescription.Size = new System.Drawing.Size(71, 19);
            this.guna2HtmlLabelDescription.TabIndex = 2;
            this.guna2HtmlLabelDescription.Text = "Description";
            // 
            // guna2TxtDescription
            // 
            this.guna2TxtDescription.BorderRadius = 20;
            this.guna2TxtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtDescription.DefaultText = "";
            this.guna2TxtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtDescription.DisabledState.Parent = this.guna2TxtDescription;
            this.guna2TxtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtDescription.FocusedState.Parent = this.guna2TxtDescription;
            this.guna2TxtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TxtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtDescription.HoverState.Parent = this.guna2TxtDescription;
            this.guna2TxtDescription.Location = new System.Drawing.Point(34, 339);
            this.guna2TxtDescription.Name = "guna2TxtDescription";
            this.guna2TxtDescription.PasswordChar = '\0';
            this.guna2TxtDescription.PlaceholderText = "";
            this.guna2TxtDescription.SelectedText = "";
            this.guna2TxtDescription.ShadowDecoration.Parent = this.guna2TxtDescription;
            this.guna2TxtDescription.Size = new System.Drawing.Size(531, 36);
            this.guna2TxtDescription.TabIndex = 5;
            // 
            // guna2HtmlLabelNomReunion
            // 
            this.guna2HtmlLabelNomReunion.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelNomReunion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelNomReunion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabelNomReunion.Location = new System.Drawing.Point(43, 48);
            this.guna2HtmlLabelNomReunion.Name = "guna2HtmlLabelNomReunion";
            this.guna2HtmlLabelNomReunion.Size = new System.Drawing.Size(30, 19);
            this.guna2HtmlLabelNomReunion.TabIndex = 0;
            this.guna2HtmlLabelNomReunion.Text = "Titre";
            // 
            // guna2TxtTitre
            // 
            this.guna2TxtTitre.BorderRadius = 20;
            this.guna2TxtTitre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtTitre.DefaultText = "";
            this.guna2TxtTitre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtTitre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtTitre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtTitre.DisabledState.Parent = this.guna2TxtTitre;
            this.guna2TxtTitre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtTitre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtTitre.FocusedState.Parent = this.guna2TxtTitre;
            this.guna2TxtTitre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TxtTitre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TxtTitre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtTitre.HoverState.Parent = this.guna2TxtTitre;
            this.guna2TxtTitre.Location = new System.Drawing.Point(34, 73);
            this.guna2TxtTitre.Name = "guna2TxtTitre";
            this.guna2TxtTitre.PasswordChar = '\0';
            this.guna2TxtTitre.PlaceholderText = "";
            this.guna2TxtTitre.SelectedText = "";
            this.guna2TxtTitre.ShadowDecoration.Parent = this.guna2TxtTitre;
            this.guna2TxtTitre.Size = new System.Drawing.Size(200, 36);
            this.guna2TxtTitre.TabIndex = 0;
            // 
            // guna2HtmlLabelCreationTontine
            // 
            this.guna2HtmlLabelCreationTontine.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabelCreationTontine.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabelCreationTontine.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabelCreationTontine.Location = new System.Drawing.Point(62, 18);
            this.guna2HtmlLabelCreationTontine.Name = "guna2HtmlLabelCreationTontine";
            this.guna2HtmlLabelCreationTontine.Size = new System.Drawing.Size(262, 27);
            this.guna2HtmlLabelCreationTontine.TabIndex = 4;
            this.guna2HtmlLabelCreationTontine.Text = "CREATION D\'UN EVENEMENT";
            // 
            // FrmEvenement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 572);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.guna2HtmlLabelCreationTontine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvenement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvenement";
            this.Load += new System.EventHandler(this.FrmEvenement_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientCreer;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLblMontant;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtMontant;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelDescription;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelNomReunion;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtTitre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabelCreationTontine;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLblLieu;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtLieu;
    }
}