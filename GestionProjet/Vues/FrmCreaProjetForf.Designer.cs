namespace GestionProjet
{
    partial class FrmCreationProjet
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.grpboxProjet = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.msktxtboxContact = new System.Windows.Forms.MaskedTextBox();
            this.projetForfaitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.msktxtboxDateFin = new System.Windows.Forms.MaskedTextBox();
            this.msktxtboxDateDebut = new System.Windows.Forms.MaskedTextBox();
            this.lblMailContact = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblclient = new System.Windows.Forms.Label();
            this.lblDatFin = new System.Windows.Forms.Label();
            this.lblDatDebut = new System.Windows.Forms.Label();
            this.lblNomProjet = new System.Windows.Forms.Label();
            this.txtboxMailContact = new System.Windows.Forms.TextBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtboxNomProjet = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.grpboxForfait = new System.Windows.Forms.GroupBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblMontantContrat = new System.Windows.Forms.Label();
            this.comboBoxResponsable = new System.Windows.Forms.ComboBox();
            this.collaborateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtboxMontantContrat = new System.Windows.Forms.TextBox();
            this.grpboxPenalites = new System.Windows.Forms.GroupBox();
            this.radbutPenalOui = new System.Windows.Forms.RadioButton();
            this.radbutPenalNon = new System.Windows.Forms.RadioButton();
            this.errorProviderObligatoire = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblProjets = new System.Windows.Forms.Label();
            this.comboBoxProjets = new System.Windows.Forms.ComboBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.grpboxProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.grpboxForfait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurBindingSource)).BeginInit();
            this.grpboxPenalites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderObligatoire)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(418, 13);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // grpboxProjet
            // 
            this.grpboxProjet.Controls.Add(this.btnAnnuler);
            this.grpboxProjet.Controls.Add(this.btnSupprimer);
            this.grpboxProjet.Controls.Add(this.btnModifier);
            this.grpboxProjet.Controls.Add(this.msktxtboxContact);
            this.grpboxProjet.Controls.Add(this.msktxtboxDateFin);
            this.grpboxProjet.Controls.Add(this.msktxtboxDateDebut);
            this.grpboxProjet.Controls.Add(this.lblMailContact);
            this.grpboxProjet.Controls.Add(this.lblContact);
            this.grpboxProjet.Controls.Add(this.lblclient);
            this.grpboxProjet.Controls.Add(this.lblDatFin);
            this.grpboxProjet.Controls.Add(this.lblDatDebut);
            this.grpboxProjet.Controls.Add(this.lblNomProjet);
            this.grpboxProjet.Controls.Add(this.txtboxMailContact);
            this.grpboxProjet.Controls.Add(this.comboBoxClient);
            this.grpboxProjet.Controls.Add(this.txtboxNomProjet);
            this.grpboxProjet.Controls.Add(this.btnValider);
            this.grpboxProjet.Location = new System.Drawing.Point(13, 61);
            this.grpboxProjet.Name = "grpboxProjet";
            this.grpboxProjet.Size = new System.Drawing.Size(514, 183);
            this.grpboxProjet.TabIndex = 0;
            this.grpboxProjet.TabStop = false;
            this.grpboxProjet.Text = "Projet";
            this.grpboxProjet.Visible = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(405, 109);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(405, 79);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 8;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(405, 49);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // msktxtboxContact
            // 
            this.msktxtboxContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetForfaitBindingSource, "Contact", true));
            this.msktxtboxContact.Enabled = false;
            this.msktxtboxContact.Location = new System.Drawing.Point(193, 129);
            this.msktxtboxContact.Name = "msktxtboxContact";
            this.msktxtboxContact.Size = new System.Drawing.Size(120, 20);
            this.msktxtboxContact.TabIndex = 4;
            this.msktxtboxContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.msktxtboxContact_KeyPress);
            // 
            // projetForfaitBindingSource
            // 
            this.projetForfaitBindingSource.DataSource = typeof(GestionProjet.Metier.ProjetForfait);
            // 
            // msktxtboxDateFin
            // 
            this.msktxtboxDateFin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetForfaitBindingSource, "DFin", true));
            this.msktxtboxDateFin.Enabled = false;
            this.msktxtboxDateFin.Location = new System.Drawing.Point(193, 74);
            this.msktxtboxDateFin.Mask = "00/00/0000";
            this.msktxtboxDateFin.Name = "msktxtboxDateFin";
            this.msktxtboxDateFin.Size = new System.Drawing.Size(120, 20);
            this.msktxtboxDateFin.TabIndex = 2;
            this.msktxtboxDateFin.ValidatingType = typeof(System.DateTime);
            this.msktxtboxDateFin.Validating += new System.ComponentModel.CancelEventHandler(this.msktxtboxDateFin_Validating);
            // 
            // msktxtboxDateDebut
            // 
            this.msktxtboxDateDebut.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetForfaitBindingSource, "DDebut", true));
            this.msktxtboxDateDebut.Enabled = false;
            this.msktxtboxDateDebut.Location = new System.Drawing.Point(192, 47);
            this.msktxtboxDateDebut.Mask = "00/00/0000";
            this.msktxtboxDateDebut.Name = "msktxtboxDateDebut";
            this.msktxtboxDateDebut.Size = new System.Drawing.Size(121, 20);
            this.msktxtboxDateDebut.TabIndex = 1;
            this.msktxtboxDateDebut.ValidatingType = typeof(System.DateTime);
            this.msktxtboxDateDebut.Validating += new System.ComponentModel.CancelEventHandler(this.msktxtboxDateDebut_Validating_1);
            // 
            // lblMailContact
            // 
            this.lblMailContact.AutoSize = true;
            this.lblMailContact.Location = new System.Drawing.Point(115, 156);
            this.lblMailContact.Name = "lblMailContact";
            this.lblMailContact.Size = new System.Drawing.Size(71, 13);
            this.lblMailContact.TabIndex = 12;
            this.lblMailContact.Text = "Mail contact :";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(136, 129);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(50, 13);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "Contact :";
            // 
            // lblclient
            // 
            this.lblclient.AutoSize = true;
            this.lblclient.Location = new System.Drawing.Point(147, 101);
            this.lblclient.Name = "lblclient";
            this.lblclient.Size = new System.Drawing.Size(39, 13);
            this.lblclient.TabIndex = 10;
            this.lblclient.Text = "Client :";
            // 
            // lblDatFin
            // 
            this.lblDatFin.AutoSize = true;
            this.lblDatFin.Location = new System.Drawing.Point(136, 74);
            this.lblDatFin.Name = "lblDatFin";
            this.lblDatFin.Size = new System.Drawing.Size(50, 13);
            this.lblDatFin.TabIndex = 9;
            this.lblDatFin.Text = "Date fin :";
            // 
            // lblDatDebut
            // 
            this.lblDatDebut.AutoSize = true;
            this.lblDatDebut.Location = new System.Drawing.Point(120, 47);
            this.lblDatDebut.Name = "lblDatDebut";
            this.lblDatDebut.Size = new System.Drawing.Size(66, 13);
            this.lblDatDebut.TabIndex = 8;
            this.lblDatDebut.Text = "Date debut :";
            // 
            // lblNomProjet
            // 
            this.lblNomProjet.AutoSize = true;
            this.lblNomProjet.Location = new System.Drawing.Point(122, 20);
            this.lblNomProjet.Name = "lblNomProjet";
            this.lblNomProjet.Size = new System.Drawing.Size(64, 13);
            this.lblNomProjet.TabIndex = 7;
            this.lblNomProjet.Text = "Nom projet :";
            // 
            // txtboxMailContact
            // 
            this.txtboxMailContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetForfaitBindingSource, "MailContact", true));
            this.txtboxMailContact.Enabled = false;
            this.txtboxMailContact.Location = new System.Drawing.Point(192, 156);
            this.txtboxMailContact.Name = "txtboxMailContact";
            this.txtboxMailContact.Size = new System.Drawing.Size(121, 20);
            this.txtboxMailContact.TabIndex = 5;
            this.txtboxMailContact.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxMailContact_Validating);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.projetForfaitBindingSource, "LeClient", true));
            this.comboBoxClient.DataSource = this.clientBindingSource;
            this.comboBoxClient.DisplayMember = "RaisonSociale";
            this.comboBoxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient.Enabled = false;
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(192, 101);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 3;
            this.comboBoxClient.ValueMember = "CodeClient";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(GestionProjet.Metier.Client);
            // 
            // txtboxNomProjet
            // 
            this.txtboxNomProjet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetForfaitBindingSource, "NomProjet", true));
            this.txtboxNomProjet.Enabled = false;
            this.txtboxNomProjet.Location = new System.Drawing.Point(192, 20);
            this.txtboxNomProjet.Name = "txtboxNomProjet";
            this.txtboxNomProjet.Size = new System.Drawing.Size(121, 20);
            this.txtboxNomProjet.TabIndex = 0;
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(405, 20);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // grpboxForfait
            // 
            this.grpboxForfait.Controls.Add(this.lblResponsable);
            this.grpboxForfait.Controls.Add(this.lblMontantContrat);
            this.grpboxForfait.Controls.Add(this.comboBoxResponsable);
            this.grpboxForfait.Controls.Add(this.txtboxMontantContrat);
            this.grpboxForfait.Controls.Add(this.grpboxPenalites);
            this.grpboxForfait.Location = new System.Drawing.Point(13, 250);
            this.grpboxForfait.Name = "grpboxForfait";
            this.grpboxForfait.Size = new System.Drawing.Size(514, 179);
            this.grpboxForfait.TabIndex = 2;
            this.grpboxForfait.TabStop = false;
            this.grpboxForfait.Text = "Forfait";
            this.grpboxForfait.Visible = false;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(111, 47);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(75, 13);
            this.lblResponsable.TabIndex = 4;
            this.lblResponsable.Text = "Responsable :";
            // 
            // lblMontantContrat
            // 
            this.lblMontantContrat.AutoSize = true;
            this.lblMontantContrat.Location = new System.Drawing.Point(98, 20);
            this.lblMontantContrat.Name = "lblMontantContrat";
            this.lblMontantContrat.Size = new System.Drawing.Size(88, 13);
            this.lblMontantContrat.TabIndex = 3;
            this.lblMontantContrat.Text = "Montant contrat :";
            // 
            // comboBoxResponsable
            // 
            this.comboBoxResponsable.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.projetForfaitBindingSource, "ChefDeProjet", true));
            this.comboBoxResponsable.DataSource = this.collaborateurBindingSource;
            this.comboBoxResponsable.DisplayMember = "Nom";
            this.comboBoxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResponsable.Enabled = false;
            this.comboBoxResponsable.FormattingEnabled = true;
            this.comboBoxResponsable.Location = new System.Drawing.Point(192, 47);
            this.comboBoxResponsable.Name = "comboBoxResponsable";
            this.comboBoxResponsable.Size = new System.Drawing.Size(121, 21);
            this.comboBoxResponsable.TabIndex = 1;
            this.comboBoxResponsable.ValueMember = "CodeColl";
            // 
            // collaborateurBindingSource
            // 
            this.collaborateurBindingSource.DataSource = typeof(GestionProjet.Metier.Collaborateur);
            // 
            // txtboxMontantContrat
            // 
            this.txtboxMontantContrat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projetForfaitBindingSource, "MontantContrat", true));
            this.txtboxMontantContrat.Enabled = false;
            this.txtboxMontantContrat.Location = new System.Drawing.Point(192, 20);
            this.txtboxMontantContrat.MaxLength = 6;
            this.txtboxMontantContrat.Name = "txtboxMontantContrat";
            this.txtboxMontantContrat.Size = new System.Drawing.Size(121, 20);
            this.txtboxMontantContrat.TabIndex = 0;
            this.txtboxMontantContrat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxMontantContrat_KeyPress);
            this.txtboxMontantContrat.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxMontantContrat_Validating);
            // 
            // grpboxPenalites
            // 
            this.grpboxPenalites.Controls.Add(this.radbutPenalOui);
            this.grpboxPenalites.Controls.Add(this.radbutPenalNon);
            this.grpboxPenalites.Enabled = false;
            this.grpboxPenalites.Location = new System.Drawing.Point(114, 91);
            this.grpboxPenalites.Name = "grpboxPenalites";
            this.grpboxPenalites.Size = new System.Drawing.Size(173, 65);
            this.grpboxPenalites.TabIndex = 0;
            this.grpboxPenalites.TabStop = false;
            this.grpboxPenalites.Text = "Penalites";
            // 
            // radbutPenalOui
            // 
            this.radbutPenalOui.AutoSize = true;
            this.radbutPenalOui.Location = new System.Drawing.Point(99, 29);
            this.radbutPenalOui.Name = "radbutPenalOui";
            this.radbutPenalOui.Size = new System.Drawing.Size(41, 17);
            this.radbutPenalOui.TabIndex = 1;
            this.radbutPenalOui.Text = "Oui";
            this.radbutPenalOui.UseVisualStyleBackColor = true;
            // 
            // radbutPenalNon
            // 
            this.radbutPenalNon.AutoSize = true;
            this.radbutPenalNon.Location = new System.Drawing.Point(7, 29);
            this.radbutPenalNon.Name = "radbutPenalNon";
            this.radbutPenalNon.Size = new System.Drawing.Size(45, 17);
            this.radbutPenalNon.TabIndex = 0;
            this.radbutPenalNon.Text = "Non";
            this.radbutPenalNon.UseVisualStyleBackColor = true;
            // 
            // errorProviderObligatoire
            // 
            this.errorProviderObligatoire.ContainerControl = this;
            // 
            // lblProjets
            // 
            this.lblProjets.AutoSize = true;
            this.lblProjets.Location = new System.Drawing.Point(13, 13);
            this.lblProjets.Name = "lblProjets";
            this.lblProjets.Size = new System.Drawing.Size(39, 13);
            this.lblProjets.TabIndex = 3;
            this.lblProjets.Text = "Projets";
            // 
            // comboBoxProjets
            // 
            this.comboBoxProjets.DataSource = this.projetForfaitBindingSource;
            this.comboBoxProjets.DisplayMember = "NomProjet";
            this.comboBoxProjets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjets.FormattingEnabled = true;
            this.comboBoxProjets.Location = new System.Drawing.Point(55, 13);
            this.comboBoxProjets.Name = "comboBoxProjets";
            this.comboBoxProjets.Size = new System.Drawing.Size(144, 21);
            this.comboBoxProjets.TabIndex = 1;
            this.comboBoxProjets.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjets_SelectedIndexChanged);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(205, 13);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(75, 23);
            this.btnCreer.TabIndex = 2;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // FrmCreationProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 439);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.comboBoxProjets);
            this.Controls.Add(this.lblProjets);
            this.Controls.Add(this.grpboxForfait);
            this.Controls.Add(this.grpboxProjet);
            this.Controls.Add(this.btnQuitter);
            this.Name = "FrmCreationProjet";
            this.Text = "Création d\'un projet au forfait";
            this.Load += new System.EventHandler(this.FrmCreationProjet_Load);
            this.grpboxProjet.ResumeLayout(false);
            this.grpboxProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetForfaitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.grpboxForfait.ResumeLayout(false);
            this.grpboxForfait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collaborateurBindingSource)).EndInit();
            this.grpboxPenalites.ResumeLayout(false);
            this.grpboxPenalites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderObligatoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.GroupBox grpboxProjet;
        private System.Windows.Forms.TextBox txtboxMailContact;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.TextBox txtboxNomProjet;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox grpboxForfait;
        private System.Windows.Forms.ComboBox comboBoxResponsable;
        private System.Windows.Forms.TextBox txtboxMontantContrat;
        private System.Windows.Forms.GroupBox grpboxPenalites;
        private System.Windows.Forms.RadioButton radbutPenalOui;
        private System.Windows.Forms.RadioButton radbutPenalNon;
        private System.Windows.Forms.Label lblMailContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblclient;
        private System.Windows.Forms.Label lblDatFin;
        private System.Windows.Forms.Label lblDatDebut;
        private System.Windows.Forms.Label lblNomProjet;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblMontantContrat;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource collaborateurBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderObligatoire;
        private System.Windows.Forms.MaskedTextBox msktxtboxDateDebut;
        private System.Windows.Forms.MaskedTextBox msktxtboxDateFin;
        private System.Windows.Forms.MaskedTextBox msktxtboxContact;
        private System.Windows.Forms.ComboBox comboBoxProjets;
        private System.Windows.Forms.BindingSource projetForfaitBindingSource;
        private System.Windows.Forms.Label lblProjets;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnCreer;
    }
}

