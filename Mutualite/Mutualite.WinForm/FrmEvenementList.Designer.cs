﻿
namespace Mutualite.WinForm
{
    partial class FrmEvenementList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2HtmlLblLigne = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientBtnRafraichir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnModifierReunion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnSupprimerReunion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnCreerReunion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PanelContainerEvenement = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridViewEvenement = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penaliter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2PanelContainerEvenement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewEvenement)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLblLigne
            // 
            this.guna2HtmlLblLigne.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLblLigne.Location = new System.Drawing.Point(771, 432);
            this.guna2HtmlLblLigne.Name = "guna2HtmlLblLigne";
            this.guna2HtmlLblLigne.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLblLigne.TabIndex = 24;
            this.guna2HtmlLblLigne.Text = "Lignes";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2GradientBtnRafraichir);
            this.guna2Panel1.Controls.Add(this.guna2GradientBtnSupprimerReunion);
            this.guna2Panel1.Controls.Add(this.guna2GradientBtnModifierReunion);
            this.guna2Panel1.Controls.Add(this.guna2GradientBtnCreerReunion);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(833, 77);
            this.guna2Panel1.TabIndex = 25;
            // 
            // guna2GradientBtnRafraichir
            // 
            this.guna2GradientBtnRafraichir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnRafraichir.Animated = true;
            this.guna2GradientBtnRafraichir.BorderRadius = 20;
            this.guna2GradientBtnRafraichir.CheckedState.Parent = this.guna2GradientBtnRafraichir;
            this.guna2GradientBtnRafraichir.CustomImages.Parent = this.guna2GradientBtnRafraichir;
            this.guna2GradientBtnRafraichir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnRafraichir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GradientBtnRafraichir.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnRafraichir.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnRafraichir.HoverState.Parent = this.guna2GradientBtnRafraichir;
            this.guna2GradientBtnRafraichir.Image = global::Mutualite.WinForm.Properties.Resources.refresh_32px;
            this.guna2GradientBtnRafraichir.Location = new System.Drawing.Point(670, 25);
            this.guna2GradientBtnRafraichir.Name = "guna2GradientBtnRafraichir";
            this.guna2GradientBtnRafraichir.ShadowDecoration.Parent = this.guna2GradientBtnRafraichir;
            this.guna2GradientBtnRafraichir.Size = new System.Drawing.Size(134, 37);
            this.guna2GradientBtnRafraichir.TabIndex = 29;
            this.guna2GradientBtnRafraichir.Text = "Rafraichir";
            this.guna2GradientBtnRafraichir.Click += new System.EventHandler(this.guna2GradientBtnRafraichir_Click_1);
            // 
            // guna2GradientBtnModifierReunion
            // 
            this.guna2GradientBtnModifierReunion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnModifierReunion.Animated = true;
            this.guna2GradientBtnModifierReunion.BorderRadius = 20;
            this.guna2GradientBtnModifierReunion.CheckedState.Parent = this.guna2GradientBtnModifierReunion;
            this.guna2GradientBtnModifierReunion.CustomImages.Parent = this.guna2GradientBtnModifierReunion;
            this.guna2GradientBtnModifierReunion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnModifierReunion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GradientBtnModifierReunion.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnModifierReunion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnModifierReunion.HoverState.Parent = this.guna2GradientBtnModifierReunion;
            this.guna2GradientBtnModifierReunion.Image = global::Mutualite.WinForm.Properties.Resources.shift_50px;
            this.guna2GradientBtnModifierReunion.Location = new System.Drawing.Point(450, 25);
            this.guna2GradientBtnModifierReunion.Name = "guna2GradientBtnModifierReunion";
            this.guna2GradientBtnModifierReunion.ShadowDecoration.Parent = this.guna2GradientBtnModifierReunion;
            this.guna2GradientBtnModifierReunion.Size = new System.Drawing.Size(189, 37);
            this.guna2GradientBtnModifierReunion.TabIndex = 28;
            this.guna2GradientBtnModifierReunion.Text = "Modifier un evenement";
            this.guna2GradientBtnModifierReunion.Click += new System.EventHandler(this.guna2GradientBtnModifierReunion_Click_1);
            // 
            // guna2GradientBtnSupprimerReunion
            // 
            this.guna2GradientBtnSupprimerReunion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnSupprimerReunion.Animated = true;
            this.guna2GradientBtnSupprimerReunion.BorderRadius = 20;
            this.guna2GradientBtnSupprimerReunion.CheckedState.Parent = this.guna2GradientBtnSupprimerReunion;
            this.guna2GradientBtnSupprimerReunion.CustomImages.Parent = this.guna2GradientBtnSupprimerReunion;
            this.guna2GradientBtnSupprimerReunion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnSupprimerReunion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientBtnSupprimerReunion.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnSupprimerReunion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnSupprimerReunion.HoverState.Parent = this.guna2GradientBtnSupprimerReunion;
            this.guna2GradientBtnSupprimerReunion.Image = global::Mutualite.WinForm.Properties.Resources.drop_down_50px;
            this.guna2GradientBtnSupprimerReunion.Location = new System.Drawing.Point(230, 25);
            this.guna2GradientBtnSupprimerReunion.Name = "guna2GradientBtnSupprimerReunion";
            this.guna2GradientBtnSupprimerReunion.ShadowDecoration.Parent = this.guna2GradientBtnSupprimerReunion;
            this.guna2GradientBtnSupprimerReunion.Size = new System.Drawing.Size(195, 37);
            this.guna2GradientBtnSupprimerReunion.TabIndex = 27;
            this.guna2GradientBtnSupprimerReunion.Text = "Supprimer un evenement";
            this.guna2GradientBtnSupprimerReunion.Click += new System.EventHandler(this.guna2GradientBtnSupprimerReunion_Click_1);
            // 
            // guna2GradientBtnCreerReunion
            // 
            this.guna2GradientBtnCreerReunion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnCreerReunion.Animated = true;
            this.guna2GradientBtnCreerReunion.BorderRadius = 20;
            this.guna2GradientBtnCreerReunion.CheckedState.Parent = this.guna2GradientBtnCreerReunion;
            this.guna2GradientBtnCreerReunion.CustomImages.Parent = this.guna2GradientBtnCreerReunion;
            this.guna2GradientBtnCreerReunion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnCreerReunion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientBtnCreerReunion.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnCreerReunion.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnCreerReunion.HoverState.Parent = this.guna2GradientBtnCreerReunion;
            this.guna2GradientBtnCreerReunion.Image = global::Mutualite.WinForm.Properties.Resources.add_50px;
            this.guna2GradientBtnCreerReunion.Location = new System.Drawing.Point(37, 25);
            this.guna2GradientBtnCreerReunion.Name = "guna2GradientBtnCreerReunion";
            this.guna2GradientBtnCreerReunion.ShadowDecoration.Parent = this.guna2GradientBtnCreerReunion;
            this.guna2GradientBtnCreerReunion.Size = new System.Drawing.Size(164, 37);
            this.guna2GradientBtnCreerReunion.TabIndex = 26;
            this.guna2GradientBtnCreerReunion.Text = "Creer un evenement";
            this.guna2GradientBtnCreerReunion.Click += new System.EventHandler(this.guna2GradientBtnCreerReunion_Click_1);
            // 
            // guna2PanelContainerEvenement
            // 
            this.guna2PanelContainerEvenement.Controls.Add(this.guna2DataGridViewEvenement);
            this.guna2PanelContainerEvenement.Controls.Add(this.guna2ShadowPanel1);
            this.guna2PanelContainerEvenement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContainerEvenement.Location = new System.Drawing.Point(0, 77);
            this.guna2PanelContainerEvenement.Name = "guna2PanelContainerEvenement";
            this.guna2PanelContainerEvenement.ShadowDecoration.Parent = this.guna2PanelContainerEvenement;
            this.guna2PanelContainerEvenement.Size = new System.Drawing.Size(833, 373);
            this.guna2PanelContainerEvenement.TabIndex = 26;
            // 
            // guna2DataGridViewEvenement
            // 
            this.guna2DataGridViewEvenement.AllowUserToAddRows = false;
            this.guna2DataGridViewEvenement.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewEvenement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewEvenement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2DataGridViewEvenement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridViewEvenement.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridViewEvenement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridViewEvenement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewEvenement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewEvenement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewEvenement.ColumnHeadersHeight = 21;
            this.guna2DataGridViewEvenement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titre,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Penaliter});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewEvenement.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewEvenement.EnableHeadersVisualStyles = false;
            this.guna2DataGridViewEvenement.GridColor = System.Drawing.Color.White;
            this.guna2DataGridViewEvenement.Location = new System.Drawing.Point(30, 89);
            this.guna2DataGridViewEvenement.Name = "guna2DataGridViewEvenement";
            this.guna2DataGridViewEvenement.ReadOnly = true;
            this.guna2DataGridViewEvenement.RowHeadersVisible = false;
            this.guna2DataGridViewEvenement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewEvenement.Size = new System.Drawing.Size(773, 269);
            this.guna2DataGridViewEvenement.TabIndex = 25;
            this.guna2DataGridViewEvenement.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridViewEvenement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DataGridViewEvenement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewEvenement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2DataGridViewEvenement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2DataGridViewEvenement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewEvenement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewEvenement.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.guna2DataGridViewEvenement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2DataGridViewEvenement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewEvenement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridViewEvenement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewEvenement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewEvenement.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridViewEvenement.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewEvenement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewEvenement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewEvenement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridViewEvenement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewEvenement.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewEvenement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewEvenement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Titre
            // 
            this.Titre.DataPropertyName = "Titre";
            this.Titre.HeaderText = "Titre";
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Montant";
            this.Column1.HeaderText = "Montant";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "date evenement";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Description";
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Penaliter
            // 
            this.Penaliter.DataPropertyName = "Lieu";
            this.Penaliter.HeaderText = "Lieux evenement";
            this.Penaliter.Name = "Penaliter";
            this.Penaliter.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(30, 15);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.guna2ShadowPanel1.Radius = 16;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(773, 55);
            this.guna2ShadowPanel1.TabIndex = 24;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.White;
            this.guna2GroupBox1.BorderRadius = 26;
            this.guna2GroupBox1.Controls.Add(this.guna2TxtSearch);
            this.guna2GroupBox1.Controls.Add(this.guna2CircleButton1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 1);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(767, 52);
            this.guna2GroupBox1.TabIndex = 0;
            // 
            // guna2TxtSearch
            // 
            this.guna2TxtSearch.BorderColor = System.Drawing.Color.White;
            this.guna2TxtSearch.BorderRadius = 15;
            this.guna2TxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TxtSearch.DefaultText = "Recherche";
            this.guna2TxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtSearch.DisabledState.Parent = this.guna2TxtSearch;
            this.guna2TxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtSearch.FocusedState.Parent = this.guna2TxtSearch;
            this.guna2TxtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TxtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2TxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TxtSearch.HoverState.Parent = this.guna2TxtSearch;
            this.guna2TxtSearch.Location = new System.Drawing.Point(66, 8);
            this.guna2TxtSearch.Name = "guna2TxtSearch";
            this.guna2TxtSearch.PasswordChar = '\0';
            this.guna2TxtSearch.PlaceholderText = "";
            this.guna2TxtSearch.SelectedText = "";
            this.guna2TxtSearch.SelectionStart = 9;
            this.guna2TxtSearch.ShadowDecoration.Parent = this.guna2TxtSearch;
            this.guna2TxtSearch.Size = new System.Drawing.Size(679, 36);
            this.guna2TxtSearch.TabIndex = 2;
            this.guna2TxtSearch.TextChanged += new System.EventHandler(this.guna2TxtSearch_TextChanged_1);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2CircleButton1.HoverState.Image = global::Mutualite.WinForm.Properties.Resources.search_26px1;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::Mutualite.WinForm.Properties.Resources.search_26px;
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.guna2CircleButton1.Location = new System.Drawing.Point(30, 11);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.TabIndex = 1;
            // 
            // FrmEvenementList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.guna2PanelContainerEvenement);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2HtmlLblLigne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvenementList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvenementList";
            this.Load += new System.EventHandler(this.FrmEvenementList_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2PanelContainerEvenement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewEvenement)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLblLigne;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnRafraichir;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnSupprimerReunion;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnModifierReunion;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnCreerReunion;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelContainerEvenement;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewEvenement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penaliter;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtSearch;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}