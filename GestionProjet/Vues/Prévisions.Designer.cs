namespace GestionProjet
{
    partial class Prévisions
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
            this.comboBoxProjets = new System.Windows.Forms.ComboBox();
            this.projetForfaitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.previsionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpboxPrevision = new System.Windows.Forms.GroupBox();
            this.numericUpDownNbJours = new System.Windows.Forms.NumericUpDown();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.comboBoxQualification = new System.Windows.Forms.ComboBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.lblProjets = new System.Windows.Forms.Label();
            this.lblPrevisions = new System.Windows.Forms.Label();
            this.dataGridViewLesPrevisions = new System.Windows.Forms.DataGridView();
            this.laQualifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nbJoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConnection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previsionBindingSource)).BeginInit();
            this.grpboxPrevision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbJours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLesPrevisions)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProjets
            // 
            this.comboBoxProjets.DataSource = this.projetForfaitBindingSource;
            this.comboBoxProjets.DisplayMember = "NomProjet";
            this.comboBoxProjets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjets.FormattingEnabled = true;
            this.comboBoxProjets.Location = new System.Drawing.Point(117, 13);
            this.comboBoxProjets.Name = "comboBoxProjets";
            this.comboBoxProjets.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProjets.TabIndex = 0;
            this.comboBoxProjets.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjets_SelectedIndexChanged);
            // 
            // projetForfaitBindingSource
            // 
            this.projetForfaitBindingSource.DataSource = typeof(GestionProjet.Metier.ProjetForfait);
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataSource = typeof(GestionProjet.Metier.Qualification);
            // 
            // previsionBindingSource
            // 
            this.previsionBindingSource.DataSource = typeof(GestionProjet.Metier.Prevision);
            // 
            // grpboxPrevision
            // 
            this.grpboxPrevision.Controls.Add(this.numericUpDownNbJours);
            this.grpboxPrevision.Controls.Add(this.btnAnnuler);
            this.grpboxPrevision.Controls.Add(this.btnValider);
            this.grpboxPrevision.Controls.Add(this.comboBoxQualification);
            this.grpboxPrevision.Location = new System.Drawing.Point(83, 291);
            this.grpboxPrevision.Name = "grpboxPrevision";
            this.grpboxPrevision.Size = new System.Drawing.Size(306, 100);
            this.grpboxPrevision.TabIndex = 2;
            this.grpboxPrevision.TabStop = false;
            this.grpboxPrevision.Text = "Prévision";
            this.grpboxPrevision.Visible = false;
            // 
            // numericUpDownNbJours
            // 
            this.numericUpDownNbJours.Location = new System.Drawing.Point(159, 20);
            this.numericUpDownNbJours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNbJours.Name = "numericUpDownNbJours";
            this.numericUpDownNbJours.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNbJours.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(159, 66);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(52, 66);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // comboBoxQualification
            // 
            this.comboBoxQualification.DataSource = this.qualificationBindingSource;
            this.comboBoxQualification.DisplayMember = "Libelle";
            this.comboBoxQualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQualification.FormattingEnabled = true;
            this.comboBoxQualification.Location = new System.Drawing.Point(7, 20);
            this.comboBoxQualification.Name = "comboBoxQualification";
            this.comboBoxQualification.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQualification.TabIndex = 0;
            this.comboBoxQualification.ValueMember = "CodeQualif";
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(83, 244);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 3;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Location = new System.Drawing.Point(76, 13);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(39, 13);
            this.lblProjets.TabIndex = 4;
            this.lblProjets.Text = "Projets";
            // 
            // lblPrevisions
            // 
            this.lblPrevisions.AutoSize = true;
            this.lblPrevisions.Location = new System.Drawing.Point(56, 68);
            this.lblPrevisions.Name = "lblPrevisions";
            this.lblPrevisions.Size = new System.Drawing.Size(74, 13);
            this.lblPrevisions.TabIndex = 5;
            this.lblPrevisions.Text = "Les prévisions";
            // 
            // dataGridViewLesPrevisions
            // 
            this.dataGridViewLesPrevisions.AllowUserToAddRows = false;
            this.dataGridViewLesPrevisions.AllowUserToDeleteRows = false;
            this.dataGridViewLesPrevisions.AutoGenerateColumns = false;
            this.dataGridViewLesPrevisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLesPrevisions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laQualifDataGridViewTextBoxColumn,
            this.nbJoursDataGridViewTextBoxColumn,
            this.Modifier,
            this.Supprimer});
            this.dataGridViewLesPrevisions.DataSource = this.previsionBindingSource;
            this.dataGridViewLesPrevisions.Location = new System.Drawing.Point(59, 88);
            this.dataGridViewLesPrevisions.Name = "dataGridViewLesPrevisions";
            this.dataGridViewLesPrevisions.ReadOnly = true;
            this.dataGridViewLesPrevisions.Size = new System.Drawing.Size(462, 150);
            this.dataGridViewLesPrevisions.TabIndex = 6;
            this.dataGridViewLesPrevisions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLesPrevisions_CellClick);
            // 
            // laQualifDataGridViewTextBoxColumn
            // 
            this.laQualifDataGridViewTextBoxColumn.DataPropertyName = "LaQualif";
            this.laQualifDataGridViewTextBoxColumn.DataSource = this.qualificationBindingSource;
            this.laQualifDataGridViewTextBoxColumn.DisplayMember = "Libelle";
            this.laQualifDataGridViewTextBoxColumn.HeaderText = "LaQualif";
            this.laQualifDataGridViewTextBoxColumn.Name = "laQualifDataGridViewTextBoxColumn";
            this.laQualifDataGridViewTextBoxColumn.ReadOnly = true;
            this.laQualifDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.laQualifDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.laQualifDataGridViewTextBoxColumn.ValueMember = "Self";
            // 
            // nbJoursDataGridViewTextBoxColumn
            // 
            this.nbJoursDataGridViewTextBoxColumn.DataPropertyName = "NbJours";
            this.nbJoursDataGridViewTextBoxColumn.HeaderText = "NbJours";
            this.nbJoursDataGridViewTextBoxColumn.Name = "nbJoursDataGridViewTextBoxColumn";
            this.nbJoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.ReadOnly = true;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseColumnTextForButtonValue = true;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(432, 10);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 7;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // Prévisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 422);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.dataGridViewLesPrevisions);
            this.Controls.Add(this.lblPrevisions);
            this.Controls.Add(this.lblProjets);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.grpboxPrevision);
            this.Controls.Add(this.comboBoxProjets);
            this.Name = "Prévisions";
            this.Text = "Prévisions";
            this.Load += new System.EventHandler(this.Prévisions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previsionBindingSource)).EndInit();
            this.grpboxPrevision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNbJours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLesPrevisions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProjets;
        private System.Windows.Forms.GroupBox grpboxPrevision;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox comboBoxQualification;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.Label lblPrevisions;
        private System.Windows.Forms.NumericUpDown numericUpDownNbJours;
        private System.Windows.Forms.BindingSource previsionBindingSource;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private System.Windows.Forms.BindingSource projetForfaitBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewLesPrevisions;
        private System.Windows.Forms.DataGridViewComboBoxColumn laQualifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Button btnConnection;
    }
}