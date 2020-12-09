
namespace Mutualite.WinForm
{
    partial class FrmMembresListe
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
            this.guna2DataGridViewEvenement = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2TxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRafraichir = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnmodifymem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btndeletemem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnaddmember = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewEvenement)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2HtmlLblLigne
            // 
            this.guna2HtmlLblLigne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLblLigne.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLblLigne.Location = new System.Drawing.Point(753, 422);
            this.guna2HtmlLblLigne.Name = "guna2HtmlLblLigne";
            this.guna2HtmlLblLigne.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLblLigne.TabIndex = 31;
            this.guna2HtmlLblLigne.Text = "Lignes";
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
            this.Nom,
            this.Prenom,
            this.Telephone,
            this.Email,
            this.Adresse});
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
            this.guna2DataGridViewEvenement.Location = new System.Drawing.Point(14, 147);
            this.guna2DataGridViewEvenement.Name = "guna2DataGridViewEvenement";
            this.guna2DataGridViewEvenement.ReadOnly = true;
            this.guna2DataGridViewEvenement.RowHeadersVisible = false;
            this.guna2DataGridViewEvenement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridViewEvenement.Size = new System.Drawing.Size(773, 269);
            this.guna2DataGridViewEvenement.TabIndex = 28;
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
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.DataPropertyName = "Adresse";
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(14, 73);
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
            this.guna2TxtSearch.Size = new System.Drawing.Size(644, 36);
            this.guna2TxtSearch.TabIndex = 2;
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRafraichir.Animated = true;
            this.btnRafraichir.BorderRadius = 20;
            this.btnRafraichir.CheckedState.Parent = this.btnRafraichir;
            this.btnRafraichir.CustomImages.Parent = this.btnRafraichir;
            this.btnRafraichir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.btnRafraichir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRafraichir.ForeColor = System.Drawing.Color.White;
            this.btnRafraichir.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnRafraichir.HoverState.Parent = this.btnRafraichir;
            this.btnRafraichir.Image = global::Mutualite.WinForm.Properties.Resources.refresh_32px;
            this.btnRafraichir.Location = new System.Drawing.Point(650, 13);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.ShadowDecoration.Parent = this.btnRafraichir;
            this.btnRafraichir.Size = new System.Drawing.Size(134, 37);
            this.btnRafraichir.TabIndex = 32;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.Click += new System.EventHandler(this.btnRafraichir_Click);
            // 
            // btnmodifymem
            // 
            this.btnmodifymem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmodifymem.Animated = true;
            this.btnmodifymem.BorderRadius = 20;
            this.btnmodifymem.CheckedState.Parent = this.btnmodifymem;
            this.btnmodifymem.CustomImages.Parent = this.btnmodifymem;
            this.btnmodifymem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.btnmodifymem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnmodifymem.ForeColor = System.Drawing.Color.White;
            this.btnmodifymem.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnmodifymem.HoverState.Parent = this.btnmodifymem;
            this.btnmodifymem.Image = global::Mutualite.WinForm.Properties.Resources.shift_50px;
            this.btnmodifymem.Location = new System.Drawing.Point(430, 13);
            this.btnmodifymem.Name = "btnmodifymem";
            this.btnmodifymem.ShadowDecoration.Parent = this.btnmodifymem;
            this.btnmodifymem.Size = new System.Drawing.Size(189, 37);
            this.btnmodifymem.TabIndex = 30;
            this.btnmodifymem.Text = "Modifier membre";
            this.btnmodifymem.Click += new System.EventHandler(this.btnmodifymem_Click);
            // 
            // btndeletemem
            // 
            this.btndeletemem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndeletemem.Animated = true;
            this.btndeletemem.BorderRadius = 20;
            this.btndeletemem.CheckedState.Parent = this.btndeletemem;
            this.btndeletemem.CustomImages.Parent = this.btndeletemem;
            this.btndeletemem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.btndeletemem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletemem.ForeColor = System.Drawing.Color.White;
            this.btndeletemem.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btndeletemem.HoverState.Parent = this.btndeletemem;
            this.btndeletemem.Image = global::Mutualite.WinForm.Properties.Resources.drop_down_50px;
            this.btndeletemem.Location = new System.Drawing.Point(210, 13);
            this.btndeletemem.Name = "btndeletemem";
            this.btndeletemem.ShadowDecoration.Parent = this.btndeletemem;
            this.btndeletemem.Size = new System.Drawing.Size(195, 37);
            this.btndeletemem.TabIndex = 29;
            this.btndeletemem.Text = "Supprimer membre";
            this.btndeletemem.Click += new System.EventHandler(this.btndeletemem_Click);
            // 
            // btnaddmember
            // 
            this.btnaddmember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnaddmember.Animated = true;
            this.btnaddmember.BorderRadius = 20;
            this.btnaddmember.CheckedState.Parent = this.btnaddmember;
            this.btnaddmember.CustomImages.Parent = this.btnaddmember;
            this.btnaddmember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(34)))), ((int)(((byte)(89)))));
            this.btnaddmember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmember.ForeColor = System.Drawing.Color.White;
            this.btnaddmember.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnaddmember.HoverState.Parent = this.btnaddmember;
            this.btnaddmember.Image = global::Mutualite.WinForm.Properties.Resources.add_50px;
            this.btnaddmember.Location = new System.Drawing.Point(17, 13);
            this.btnaddmember.Name = "btnaddmember";
            this.btnaddmember.ShadowDecoration.Parent = this.btnaddmember;
            this.btnaddmember.Size = new System.Drawing.Size(164, 37);
            this.btnaddmember.TabIndex = 27;
            this.btnaddmember.Text = "Nouveau membre";
            this.btnaddmember.Click += new System.EventHandler(this.btnaddmember_Click);
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
            // FrmMembresListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.guna2HtmlLblLigne);
            this.Controls.Add(this.btnmodifymem);
            this.Controls.Add(this.btndeletemem);
            this.Controls.Add(this.guna2DataGridViewEvenement);
            this.Controls.Add(this.btnaddmember);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMembresListe";
            this.Text = "FrmMembres";
            this.Load += new System.EventHandler(this.FrmMembresListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewEvenement)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnRafraichir;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLblLigne;
        private Guna.UI2.WinForms.Guna2GradientButton btnmodifymem;
        private Guna.UI2.WinForms.Guna2GradientButton btndeletemem;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewEvenement;
        private Guna.UI2.WinForms.Guna2GradientButton btnaddmember;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TxtSearch;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
    }
}