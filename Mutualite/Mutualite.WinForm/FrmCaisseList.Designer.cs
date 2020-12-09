
namespace Mutualite.WinForm
{
    partial class FrmCaisseList
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
            this.guna2DataGridViewCaisse = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penaliter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientBtnRafraichir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnModifierVersement = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnSupprimerVersement = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientBtnNouveau = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCaisse)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLblLigne
            // 
            this.guna2HtmlLblLigne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLblLigne.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLblLigne.Location = new System.Drawing.Point(753, 466);
            this.guna2HtmlLblLigne.Name = "guna2HtmlLblLigne";
            this.guna2HtmlLblLigne.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLblLigne.TabIndex = 31;
            this.guna2HtmlLblLigne.Text = "Lignes";
            // 
            // guna2DataGridViewCaisse
            // 
            this.guna2DataGridViewCaisse.AllowUserToAddRows = false;
            this.guna2DataGridViewCaisse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewCaisse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridViewCaisse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2DataGridViewCaisse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridViewCaisse.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridViewCaisse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridViewCaisse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewCaisse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewCaisse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridViewCaisse.ColumnHeadersHeight = 21;
            this.guna2DataGridViewCaisse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.guna2DataGridViewCaisse.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridViewCaisse.EnableHeadersVisualStyles = false;
            this.guna2DataGridViewCaisse.GridColor = System.Drawing.Color.White;
            this.guna2DataGridViewCaisse.Location = new System.Drawing.Point(14, 191);
            this.guna2DataGridViewCaisse.Name = "guna2DataGridViewCaisse";
            this.guna2DataGridViewCaisse.ReadOnly = true;
            this.guna2DataGridViewCaisse.RowHeadersVisible = false;
            this.guna2DataGridViewCaisse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewCaisse.Size = new System.Drawing.Size(773, 269);
            this.guna2DataGridViewCaisse.TabIndex = 28;
            this.guna2DataGridViewCaisse.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridViewCaisse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2DataGridViewCaisse.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewCaisse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2DataGridViewCaisse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2DataGridViewCaisse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewCaisse.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCaisse.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.guna2DataGridViewCaisse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(165)))));
            this.guna2DataGridViewCaisse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewCaisse.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridViewCaisse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewCaisse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewCaisse.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridViewCaisse.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewCaisse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewCaisse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewCaisse.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridViewCaisse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewCaisse.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewCaisse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewCaisse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(14, 117);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 2);
            this.guna2ShadowPanel1.Radius = 16;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(773, 55);
            this.guna2ShadowPanel1.TabIndex = 26;
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
            this.guna2TxtSearch.TextChanged += new System.EventHandler(this.guna2TxtSearch_TextChanged);
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
            this.guna2GradientBtnRafraichir.Location = new System.Drawing.Point(650, 57);
            this.guna2GradientBtnRafraichir.Name = "guna2GradientBtnRafraichir";
            this.guna2GradientBtnRafraichir.ShadowDecoration.Parent = this.guna2GradientBtnRafraichir;
            this.guna2GradientBtnRafraichir.Size = new System.Drawing.Size(134, 37);
            this.guna2GradientBtnRafraichir.TabIndex = 32;
            this.guna2GradientBtnRafraichir.Text = "Rafraichir";
            this.guna2GradientBtnRafraichir.Click += new System.EventHandler(this.guna2GradientBtnRafraichir_Click);
            // 
            // guna2GradientBtnModifierVersement
            // 
            this.guna2GradientBtnModifierVersement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnModifierVersement.Animated = true;
            this.guna2GradientBtnModifierVersement.BorderRadius = 20;
            this.guna2GradientBtnModifierVersement.CheckedState.Parent = this.guna2GradientBtnModifierVersement;
            this.guna2GradientBtnModifierVersement.CustomImages.Parent = this.guna2GradientBtnModifierVersement;
            this.guna2GradientBtnModifierVersement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnModifierVersement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GradientBtnModifierVersement.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnModifierVersement.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnModifierVersement.HoverState.Parent = this.guna2GradientBtnModifierVersement;
            this.guna2GradientBtnModifierVersement.Image = global::Mutualite.WinForm.Properties.Resources.shift_50px;
            this.guna2GradientBtnModifierVersement.Location = new System.Drawing.Point(430, 57);
            this.guna2GradientBtnModifierVersement.Name = "guna2GradientBtnModifierVersement";
            this.guna2GradientBtnModifierVersement.ShadowDecoration.Parent = this.guna2GradientBtnModifierVersement;
            this.guna2GradientBtnModifierVersement.Size = new System.Drawing.Size(189, 37);
            this.guna2GradientBtnModifierVersement.TabIndex = 30;
            this.guna2GradientBtnModifierVersement.Text = "Modifier un versement";
            this.guna2GradientBtnModifierVersement.Click += new System.EventHandler(this.guna2GradientBtnModifierVersement_Click);
            // 
            // guna2GradientBtnSupprimerVersement
            // 
            this.guna2GradientBtnSupprimerVersement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientBtnSupprimerVersement.Animated = true;
            this.guna2GradientBtnSupprimerVersement.BorderRadius = 20;
            this.guna2GradientBtnSupprimerVersement.CheckedState.Parent = this.guna2GradientBtnSupprimerVersement;
            this.guna2GradientBtnSupprimerVersement.CustomImages.Parent = this.guna2GradientBtnSupprimerVersement;
            this.guna2GradientBtnSupprimerVersement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.guna2GradientBtnSupprimerVersement.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientBtnSupprimerVersement.ForeColor = System.Drawing.Color.White;
            this.guna2GradientBtnSupprimerVersement.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientBtnSupprimerVersement.HoverState.Parent = this.guna2GradientBtnSupprimerVersement;
            this.guna2GradientBtnSupprimerVersement.Image = global::Mutualite.WinForm.Properties.Resources.drop_down_50px;
            this.guna2GradientBtnSupprimerVersement.Location = new System.Drawing.Point(183, 57);
            this.guna2GradientBtnSupprimerVersement.Name = "guna2GradientBtnSupprimerVersement";
            this.guna2GradientBtnSupprimerVersement.ShadowDecoration.Parent = this.guna2GradientBtnSupprimerVersement;
            this.guna2GradientBtnSupprimerVersement.Size = new System.Drawing.Size(195, 37);
            this.guna2GradientBtnSupprimerVersement.TabIndex = 29;
            this.guna2GradientBtnSupprimerVersement.Text = "Supprimer un versement";
            this.guna2GradientBtnSupprimerVersement.Click += new System.EventHandler(this.guna2GradientBtnSupprimerVersement_Click);
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
            this.guna2GradientBtnNouveau.Location = new System.Drawing.Point(17, 57);
            this.guna2GradientBtnNouveau.Name = "guna2GradientBtnNouveau";
            this.guna2GradientBtnNouveau.ShadowDecoration.Parent = this.guna2GradientBtnNouveau;
            this.guna2GradientBtnNouveau.Size = new System.Drawing.Size(104, 37);
            this.guna2GradientBtnNouveau.TabIndex = 27;
            this.guna2GradientBtnNouveau.Text = "Nouveau";
            this.guna2GradientBtnNouveau.Click += new System.EventHandler(this.guna2GradientBtnNouveau_Click);
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
            // FrmCaisseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.guna2GradientBtnRafraichir);
            this.Controls.Add(this.guna2HtmlLblLigne);
            this.Controls.Add(this.guna2GradientBtnModifierVersement);
            this.Controls.Add(this.guna2GradientBtnSupprimerVersement);
            this.Controls.Add(this.guna2DataGridViewCaisse);
            this.Controls.Add(this.guna2GradientBtnNouveau);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaisseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCaisseList";
            this.Load += new System.EventHandler(this.FrmCaisseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewCaisse)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnRafraichir;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLblLigne;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnModifierVersement;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnSupprimerVersement;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewCaisse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penaliter;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientBtnNouveau;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtSearch;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
    }
}