
namespace Mutualite.WinForm
{
    partial class FrmReunionAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReunionAccess));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreateMeeting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Purple;
            this.guna2Panel1.Controls.Add(this.btnCreateMeeting);
            this.guna2Panel1.Controls.Add(this.button2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(173, 302);
            this.guna2Panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "List of meetings";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCreateMeeting
            // 
            this.btnCreateMeeting.BackColor = System.Drawing.Color.Purple;
            this.btnCreateMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateMeeting.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnCreateMeeting.FlatAppearance.BorderSize = 0;
            this.btnCreateMeeting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateMeeting.Location = new System.Drawing.Point(12, 87);
            this.btnCreateMeeting.Name = "btnCreateMeeting";
            this.btnCreateMeeting.Size = new System.Drawing.Size(152, 60);
            this.btnCreateMeeting.TabIndex = 2;
            this.btnCreateMeeting.Text = "Create Meeting";
            this.btnCreateMeeting.UseVisualStyleBackColor = false;
            this.btnCreateMeeting.Click += new System.EventHandler(this.btnCreateMeeting_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 302);
            this.panel1.TabIndex = 1;
            // 
            // FrmReunionAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReunionAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReunionAccess";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btnCreateMeeting;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}