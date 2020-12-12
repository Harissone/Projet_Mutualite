
namespace Mutualite.WinForm
{
    partial class FrmAssembleList
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
            this.guna2GradientBtnModifierAssemble = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnSupprimerAssemble = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnNouveau = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PanelContainerAssemble = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridViewVersement = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Compte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVersement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModePayement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnHistorique = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2PanelContainerAssemble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewVersement)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLblLigne
            // 
            this.guna2HtmlLblLigne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLblLigne.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLblLigne.Location = new System.Drawing.Point(736, 450);
            this.guna2HtmlLblLigne.Name = "guna2HtmlLblLigne";
            this.guna2HtmlLblLigne.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLblLigne.TabIndex = 38;
            this.guna2HtmlLblLigne.Text = "Lignes";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2GradientBtnRafraichir);
            this.guna2Panel1.Controls.Add(this.guna2GradientBtnNouveau);
            this.guna2Panel1.Controls.Add(this.guna2GradientBtnModifierAssemble);
            this.guna2Panel1.Controls.Add(this.guna2GradientBtnSupprimerAssemble);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(800, 113);
            this.guna2Panel1.TabIndex = 41;
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
            this.guna2GradientBtnRafraichir.Location = new System.Drawing.Point(631, 45);
            this.guna2GradientBtnRafraichir.Name = "guna2GradientBtnRafraichir";
            this.guna2GradientBtnRafraichir.ShadowDecoration.Parent = this.guna2GradientBtnRafraichir;
            this.guna2GradientBtnRafraichir.Size = new System.Drawing.Size(134, 37);
            this.guna2GradientBtnRafraichir.TabIndex = 45;
            this.guna2GradientBtnRafraichir.Text = "Rafraichir";
            this.guna2GradientBtnRafraichir.Click += new System.EventHandler(this.guna2GradientBtnRafraichir_Click);
            // 
            // guna2GradientBtnModifierAssemble
            // 
            this.guna2GradientBtnModifierAssemble.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnModifierAssemble.Animated = true;
            this.guna2GradientBtnModifierAssemble.BorderRadius = 20;
            this.guna2GradientBtnModifierAssemble.CheckedState.Parent = this.guna2GradientBtnModifierAssemble;
            this.guna2GradientBtnModifierAssemble.CustomImages.Parent = this.guna2GradientBtnModifierAssemble;
            this.guna2GradientBtnModifierAssemble.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnModifierAssemble.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GradientBtnModifierAssemble.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnModifierAssemble.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnModifierAssemble.HoverState.Parent = this.guna2GradientBtnModifierAssemble;
            this.guna2GradientBtnModifierAssemble.Image = global::Mutualite.WinForm.Properties.Resources.shift_50px;
            this.guna2GradientBtnModifierAssemble.Location = new System.Drawing.Point(399, 45);
            this.guna2GradientBtnModifierAssemble.Name = "guna2GradientBtnModifierAssemble";
            this.guna2GradientBtnModifierAssemble.ShadowDecoration.Parent = this.guna2GradientBtnModifierAssemble;
            this.guna2GradientBtnModifierAssemble.Size = new System.Drawing.Size(183, 37);
            this.guna2GradientBtnModifierAssemble.TabIndex = 44;
            this.guna2GradientBtnModifierAssemble.Text = "Modifier assemble";
            this.guna2GradientBtnModifierAssemble.Click += new System.EventHandler(this.guna2GradientBtnModifierAssemble_Click);
            // 
            // guna2GradientBtnSupprimerAssemble
            // 
            this.guna2GradientBtnSupprimerAssemble.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnSupprimerAssemble.Animated = true;
            this.guna2GradientBtnSupprimerAssemble.BorderRadius = 20;
            this.guna2GradientBtnSupprimerAssemble.CheckedState.Parent = this.guna2GradientBtnSupprimerAssemble;
            this.guna2GradientBtnSupprimerAssemble.CustomImages.Parent = this.guna2GradientBtnSupprimerAssemble;
            this.guna2GradientBtnSupprimerAssemble.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnSupprimerAssemble.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientBtnSupprimerAssemble.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnSupprimerAssemble.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnSupprimerAssemble.HoverState.Parent = this.guna2GradientBtnSupprimerAssemble;
            this.guna2GradientBtnSupprimerAssemble.Image = global::Mutualite.WinForm.Properties.Resources.drop_down_50px;
            this.guna2GradientBtnSupprimerAssemble.Location = new System.Drawing.Point(171, 45);
            this.guna2GradientBtnSupprimerAssemble.Name = "guna2GradientBtnSupprimerAssemble";
            this.guna2GradientBtnSupprimerAssemble.ShadowDecoration.Parent = this.guna2GradientBtnSupprimerAssemble;
            this.guna2GradientBtnSupprimerAssemble.Size = new System.Drawing.Size(188, 37);
            this.guna2GradientBtnSupprimerAssemble.TabIndex = 43;
            this.guna2GradientBtnSupprimerAssemble.Text = "Supprimer assemble";
            this.guna2GradientBtnSupprimerAssemble.Click += new System.EventHandler(this.guna2GradientBtnSupprimerAssemble_Click);
            // 
            // guna2GradientBtnNouveau
            // 
            this.guna2GradientBtnNouveau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnNouveau.Animated = true;
            this.guna2GradientBtnNouveau.BorderRadius = 20;
            this.guna2GradientBtnNouveau.CheckedState.Parent = this.guna2GradientBtnNouveau;
            this.guna2GradientBtnNouveau.CustomImages.Parent = this.guna2GradientBtnNouveau;
            this.guna2GradientBtnNouveau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnNouveau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientBtnNouveau.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnNouveau.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnNouveau.HoverState.Parent = this.guna2GradientBtnNouveau;
            this.guna2GradientBtnNouveau.Image = global::Mutualite.WinForm.Properties.Resources.add_50px;
            this.guna2GradientBtnNouveau.Location = new System.Drawing.Point(32, 45);
            this.guna2GradientBtnNouveau.Name = "guna2GradientBtnNouveau";
            this.guna2GradientBtnNouveau.ShadowDecoration.Parent = this.guna2GradientBtnNouveau;
            this.guna2GradientBtnNouveau.Size = new System.Drawing.Size(104, 37);
            this.guna2GradientBtnNouveau.TabIndex = 42;
            this.guna2GradientBtnNouveau.Text = "Nouveau";
            this.guna2GradientBtnNouveau.Click += new System.EventHandler(this.guna2GradientBtnNouveau_Click);
            // 
            // guna2PanelContainerAssemble
            // 
            this.guna2PanelContainerAssemble.Controls.Add(this.guna2GradientBtnHistorique);
            this.guna2PanelContainerAssemble.Controls.Add(this.guna2GradientButton1);
            this.guna2PanelContainerAssemble.Controls.Add(this.guna2DataGridViewVersement);
            this.guna2PanelContainerAssemble.Controls.Add(this.guna2ShadowPanel1);
            this.guna2PanelContainerAssemble.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PanelContainerAssemble.Location = new System.Drawing.Point(0, 113);
            this.guna2PanelContainerAssemble.Name = "guna2PanelContainerAssemble";
            this.guna2PanelContainerAssemble.ShadowDecoration.Parent = this.guna2PanelContainerAssemble;
            this.guna2PanelContainerAssemble.Size = new System.Drawing.Size(800, 460);
            this.guna2PanelContainerAssemble.TabIndex = 42;
            // 
            // guna2DataGridViewVersement
            // 
            this.guna2DataGridViewVersement.AllowUserToAddRows = false;
            this.guna2DataGridViewVersement.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewVersement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2DataGridViewVersement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridViewVersement.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridViewVersement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewVersement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewVersement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewVersement.ColumnHeadersHeight = 21;
            this.guna2DataGridViewVersement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Compte,
            this.Column1,
            this.Montant,
            this.DateVersement,
            this.ModePayement,
            this.Commentaire});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewVersement.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewVersement.EnableHeadersVisualStyles = false;
            this.guna2DataGridViewVersement.GridColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.Location = new System.Drawing.Point(26, 132);
            this.guna2DataGridViewVersement.Name = "guna2DataGridViewVersement";
            this.guna2DataGridViewVersement.ReadOnly = true;
            this.guna2DataGridViewVersement.RowHeadersVisible = false;
            this.guna2DataGridViewVersement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewVersement.Size = new System.Drawing.Size(745, 269);
            this.guna2DataGridViewVersement.TabIndex = 44;
            this.guna2DataGridViewVersement.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridViewVersement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DataGridViewVersement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewVersement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2DataGridViewVersement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2DataGridViewVersement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2DataGridViewVersement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewVersement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridViewVersement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewVersement.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridViewVersement.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewVersement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewVersement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridViewVersement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewVersement.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewVersement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewVersement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Compte
            // 
            this.Compte.DataPropertyName = "Hote";
            this.Compte.HeaderText = "Hote";
            this.Compte.Name = "Compte";
            this.Compte.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SanctionAbsence";
            this.Column1.HeaderText = "Sanction absence";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Montant
            // 
            this.Montant.DataPropertyName = "DateAssemble";
            this.Montant.HeaderText = "Date assemble";
            this.Montant.Name = "Montant";
            this.Montant.ReadOnly = true;
            // 
            // DateVersement
            // 
            this.DateVersement.DataPropertyName = "HeureAssemble";
            this.DateVersement.HeaderText = "Heure assemble";
            this.DateVersement.Name = "DateVersement";
            this.DateVersement.ReadOnly = true;
            // 
            // ModePayement
            // 
            this.ModePayement.DataPropertyName = "TypeAssemble";
            this.ModePayement.HeaderText = "Type assemble";
            this.ModePayement.Name = "ModePayement";
            this.ModePayement.ReadOnly = true;
            // 
            // Commentaire
            // 
            this.Commentaire.DataPropertyName = "SanctionRetard";
            this.Commentaire.HeaderText = "Sanction retard";
            this.Commentaire.Name = "Commentaire";
            this.Commentaire.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(29, 60);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.guna2ShadowPanel1.Radius = 16;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(745, 47);
            this.guna2ShadowPanel1.TabIndex = 43;
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
            this.guna2GroupBox1.Size = new System.Drawing.Size(739, 44);
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
            this.guna2TxtSearch.Location = new System.Drawing.Point(66, 5);
            this.guna2TxtSearch.Name = "guna2TxtSearch";
            this.guna2TxtSearch.PasswordChar = '\0';
            this.guna2TxtSearch.PlaceholderText = "";
            this.guna2TxtSearch.SelectedText = "";
            this.guna2TxtSearch.SelectionStart = 9;
            this.guna2TxtSearch.ShadowDecoration.Parent = this.guna2TxtSearch;
            this.guna2TxtSearch.Size = new System.Drawing.Size(644, 36);
            this.guna2TxtSearch.TabIndex = 2;
            this.guna2TxtSearch.TextChanged += new System.EventHandler(this.guna2TxtSearch_TextChanged);
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
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderRadius = 20;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::Mutualite.WinForm.Properties.Resources.add_50px;
            this.guna2GradientButton1.Location = new System.Drawing.Point(578, 7);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(187, 37);
            this.guna2GradientButton1.TabIndex = 46;
            this.guna2GradientButton1.Text = "Effectuer une cotisation";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientBtnHistorique
            // 
            this.guna2GradientBtnHistorique.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnHistorique.Animated = true;
            this.guna2GradientBtnHistorique.BorderRadius = 20;
            this.guna2GradientBtnHistorique.CheckedState.Parent = this.guna2GradientBtnHistorique;
            this.guna2GradientBtnHistorique.CustomImages.Parent = this.guna2GradientBtnHistorique;
            this.guna2GradientBtnHistorique.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnHistorique.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientBtnHistorique.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnHistorique.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnHistorique.HoverState.Parent = this.guna2GradientBtnHistorique;
            this.guna2GradientBtnHistorique.Image = global::Mutualite.WinForm.Properties.Resources.add_50px;
            this.guna2GradientBtnHistorique.Location = new System.Drawing.Point(32, 7);
            this.guna2GradientBtnHistorique.Name = "guna2GradientBtnHistorique";
            this.guna2GradientBtnHistorique.ShadowDecoration.Parent = this.guna2GradientBtnHistorique;
            this.guna2GradientBtnHistorique.Size = new System.Drawing.Size(203, 37);
            this.guna2GradientBtnHistorique.TabIndex = 47;
            this.guna2GradientBtnHistorique.Text = "Historique des cotisations";
            this.guna2GradientBtnHistorique.Click += new System.EventHandler(this.guna2GradientBtnHistorique_Click);
            // 
            // FrmAssembleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.guna2PanelContainerAssemble);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2HtmlLblLigne);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAssembleList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAssembleList";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2PanelContainerAssemble.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewVersement)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLblLigne;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnRafraichir;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnNouveau;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnModifierAssemble;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnSupprimerAssemble;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelContainerAssemble;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewVersement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVersement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModePayement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentaire;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtSearch;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnHistorique;
    }
}