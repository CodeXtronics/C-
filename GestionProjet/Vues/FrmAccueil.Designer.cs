namespace GestionProjet.Vues
{
    partial class FrmAccueil
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
            this.components = new System.ComponentModel.Container();
            this.statusStripDate = new System.Windows.Forms.StatusStrip();
            this.tStripDatenow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripOption = new System.Windows.Forms.ToolStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStripOption = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verticaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerProjetsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prévisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripDate.SuspendLayout();
            this.menuStripOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripDate
            // 
            this.statusStripDate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripDatenow});
            this.statusStripDate.Location = new System.Drawing.Point(0, 239);
            this.statusStripDate.Name = "statusStripDate";
            this.statusStripDate.Size = new System.Drawing.Size(661, 22);
            this.statusStripDate.TabIndex = 0;
            this.statusStripDate.Text = "statusStrip1";
            // 
            // tStripDatenow
            // 
            this.tStripDatenow.Name = "tStripDatenow";
            this.tStripDatenow.Size = new System.Drawing.Size(31, 17);
            this.tStripDatenow.Text = "Date";
            // 
            // toolStripOption
            // 
            this.toolStripOption.Location = new System.Drawing.Point(0, 24);
            this.toolStripOption.Name = "toolStripOption";
            this.toolStripOption.Size = new System.Drawing.Size(661, 25);
            this.toolStripOption.TabIndex = 1;
            this.toolStripOption.Text = "toolStrip1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStripOption
            // 
            this.menuStripOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.gestionProjetToolStripMenuItem,
            this.fenêtresToolStripMenuItem});
            this.menuStripOption.Location = new System.Drawing.Point(0, 0);
            this.menuStripOption.MdiWindowListItem = this.fenêtresToolStripMenuItem;
            this.menuStripOption.Name = "menuStripOption";
            this.menuStripOption.Size = new System.Drawing.Size(661, 24);
            this.menuStripOption.TabIndex = 3;
            this.menuStripOption.Text = "Option";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem1,
            this.quitterToolStripMenuItem1});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // gestionProjetToolStripMenuItem
            // 
            this.gestionProjetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerProjetsToolStripMenuItem1,
            this.prévisionToolStripMenuItem});
            this.gestionProjetToolStripMenuItem.Name = "gestionProjetToolStripMenuItem";
            this.gestionProjetToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.gestionProjetToolStripMenuItem.Text = "Gestion projet";
            this.gestionProjetToolStripMenuItem.Click += new System.EventHandler(this.gestionProjetToolStripMenuItem_Click);
            // 
            // sidentifierToolStripMenuItem1
            // 
            this.sidentifierToolStripMenuItem1.Name = "sidentifierToolStripMenuItem1";
            this.sidentifierToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sidentifierToolStripMenuItem1.Text = "S\'identifier";
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // fenêtresToolStripMenuItem
            // 
            this.fenêtresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadesToolStripMenuItem,
            this.horizontaleToolStripMenuItem1,
            this.verticaleToolStripMenuItem1});
            this.fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            this.fenêtresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadesToolStripMenuItem
            // 
            this.cascadesToolStripMenuItem.Name = "cascadesToolStripMenuItem";
            this.cascadesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadesToolStripMenuItem.Text = "Cascade";
            this.cascadesToolStripMenuItem.Click += new System.EventHandler(this.cascadesToolStripMenuItem_Click);
            // 
            // horizontaleToolStripMenuItem1
            // 
            this.horizontaleToolStripMenuItem1.Name = "horizontaleToolStripMenuItem1";
            this.horizontaleToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.horizontaleToolStripMenuItem1.Text = "Horizontale";
            this.horizontaleToolStripMenuItem1.Click += new System.EventHandler(this.horizontaleToolStripMenuItem1_Click);
            // 
            // verticaleToolStripMenuItem1
            // 
            this.verticaleToolStripMenuItem1.Name = "verticaleToolStripMenuItem1";
            this.verticaleToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.verticaleToolStripMenuItem1.Text = "Verticale";
            this.verticaleToolStripMenuItem1.Click += new System.EventHandler(this.verticaleToolStripMenuItem1_Click);
            // 
            // gérerProjetsToolStripMenuItem1
            // 
            this.gérerProjetsToolStripMenuItem1.Name = "gérerProjetsToolStripMenuItem1";
            this.gérerProjetsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.gérerProjetsToolStripMenuItem1.Text = "Gérer projets";
            this.gérerProjetsToolStripMenuItem1.Click += new System.EventHandler(this.gérerProjetsToolStripMenuItem1_Click);
            // 
            // prévisionToolStripMenuItem
            // 
            this.prévisionToolStripMenuItem.Name = "prévisionToolStripMenuItem";
            this.prévisionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prévisionToolStripMenuItem.Text = "Prévisionnel";
            this.prévisionToolStripMenuItem.Click += new System.EventHandler(this.prévisionToolStripMenuItem_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 261);
            this.Controls.Add(this.toolStripOption);
            this.Controls.Add(this.statusStripDate);
            this.Controls.Add(this.menuStripOption);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripOption;
            this.Name = "FrmAccueil";
            this.Text = "FrmAccueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStripDate.ResumeLayout(false);
            this.statusStripDate.PerformLayout();
            this.menuStripOption.ResumeLayout(false);
            this.menuStripOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripDate;
        private System.Windows.Forms.ToolStripStatusLabel tStripDatenow;
        private System.Windows.Forms.ToolStrip toolStripOption;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStripOption;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionProjetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verticaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gérerProjetsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prévisionToolStripMenuItem;
    }
}