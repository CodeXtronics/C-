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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.statusStripDate = new System.Windows.Forms.StatusStrip();
            this.tStripDatenow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripOption = new System.Windows.Forms.ToolStrip();
            this.toolStripConnection = new System.Windows.Forms.ToolStripDropDownButton();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownGestionProjet = new System.Windows.Forms.ToolStripDropDownButton();
            this.gérerProjetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prévisionnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownFenetre = new System.Windows.Forms.ToolStripDropDownButton();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripDate.SuspendLayout();
            this.toolStripOption.SuspendLayout();
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
            this.toolStripOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripConnection,
            this.toolStripDropDownGestionProjet,
            this.toolStripDropDownFenetre});
            this.toolStripOption.Location = new System.Drawing.Point(0, 0);
            this.toolStripOption.Name = "toolStripOption";
            this.toolStripOption.Size = new System.Drawing.Size(661, 25);
            this.toolStripOption.TabIndex = 1;
            this.toolStripOption.Text = "toolStrip1";
            // 
            // toolStripConnection
            // 
            this.toolStripConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripConnection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.toolStripConnection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConnection.Image")));
            this.toolStripConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConnection.Name = "toolStripConnection";
            this.toolStripConnection.Size = new System.Drawing.Size(82, 22);
            this.toolStripConnection.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem.Text = "S’identifier";
            this.sidentifierToolStripMenuItem.Click += new System.EventHandler(this.sidentifierToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // toolStripDropDownGestionProjet
            // 
            this.toolStripDropDownGestionProjet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownGestionProjet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerProjetsToolStripMenuItem,
            this.prévisionnelToolStripMenuItem});
            this.toolStripDropDownGestionProjet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownGestionProjet.Image")));
            this.toolStripDropDownGestionProjet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownGestionProjet.Name = "toolStripDropDownGestionProjet";
            this.toolStripDropDownGestionProjet.Size = new System.Drawing.Size(94, 22);
            this.toolStripDropDownGestionProjet.Text = "Gestion Projet";
            this.toolStripDropDownGestionProjet.Click += new System.EventHandler(this.toolStripDropDownGestionProjet_Click);
            // 
            // gérerProjetsToolStripMenuItem
            // 
            this.gérerProjetsToolStripMenuItem.Name = "gérerProjetsToolStripMenuItem";
            this.gérerProjetsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gérerProjetsToolStripMenuItem.Text = "Gérer projets";
            this.gérerProjetsToolStripMenuItem.Click += new System.EventHandler(this.gérerProjetsToolStripMenuItem_Click);
            // 
            // prévisionnelToolStripMenuItem
            // 
            this.prévisionnelToolStripMenuItem.Name = "prévisionnelToolStripMenuItem";
            this.prévisionnelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.prévisionnelToolStripMenuItem.Text = "Prévisionnel";
            this.prévisionnelToolStripMenuItem.Click += new System.EventHandler(this.prévisionnelToolStripMenuItem_Click);
            // 
            // toolStripDropDownFenetre
            // 
            this.toolStripDropDownFenetre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownFenetre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontaleToolStripMenuItem,
            this.verticaleToolStripMenuItem,
            this.toolStripSeparator1});
            this.toolStripDropDownFenetre.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownFenetre.Image")));
            this.toolStripDropDownFenetre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownFenetre.Name = "toolStripDropDownFenetre";
            this.toolStripDropDownFenetre.Size = new System.Drawing.Size(64, 22);
            this.toolStripDropDownFenetre.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontaleToolStripMenuItem
            // 
            this.horizontaleToolStripMenuItem.Name = "horizontaleToolStripMenuItem";
            this.horizontaleToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.horizontaleToolStripMenuItem.Text = "Horizontale";
            this.horizontaleToolStripMenuItem.Click += new System.EventHandler(this.horizontaleToolStripMenuItem_Click);
            // 
            // verticaleToolStripMenuItem
            // 
            this.verticaleToolStripMenuItem.Name = "verticaleToolStripMenuItem";
            this.verticaleToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.verticaleToolStripMenuItem.Text = "Verticale";
            this.verticaleToolStripMenuItem.Click += new System.EventHandler(this.verticaleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 261);
            this.Controls.Add(this.toolStripOption);
            this.Controls.Add(this.statusStripDate);
            this.IsMdiContainer = true;
            this.Name = "FrmAccueil";
            this.Text = "FrmAccueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAccueil_Load);
            this.statusStripDate.ResumeLayout(false);
            this.statusStripDate.PerformLayout();
            this.toolStripOption.ResumeLayout(false);
            this.toolStripOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripDate;
        private System.Windows.Forms.ToolStripStatusLabel tStripDatenow;
        private System.Windows.Forms.ToolStrip toolStripOption;
        private System.Windows.Forms.ToolStripDropDownButton toolStripConnection;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownGestionProjet;
        private System.Windows.Forms.ToolStripMenuItem gérerProjetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prévisionnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownFenetre;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}