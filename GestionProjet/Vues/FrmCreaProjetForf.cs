using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.Windows.Forms;

namespace GestionProjet    
{
    
    using Dao;
    using Metier;
    
    using System.Globalization;
    
    public partial class FrmCreationProjet : Form 
    {        

        bool butCreerClick = false;
        bool butModifierClick = false;
        ProjetForfait projModif = new ProjetForfait();
        int indexModif;
        public FrmCreationProjet()
        {
            InitializeComponent();
            
        }

        private void FrmCreationProjet_Load(object sender, EventArgs e)
        {
            projetForfaitBindingSource.DataSource = DaoProjet.GetAllProjets();
            clientBindingSource.DataSource = DaoProjet.GetAllClients();
            collaborateurBindingSource.DataSource = DaoProjet.GetAllCollaborateurs();
            ControlBox = false;
            Initialisation();
            

        }

        private void Initialisation()
        {

            comboBoxProjets.SelectedItem = null;
            grpboxForfait.Visible = false;
            grpboxProjet.Visible = false;            
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Affiche la MessageBox.
            result = MessageBox.Show("Fin de l'appliction", "Quitter", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            //Si yes est appuier sur la message box cela ferme l'application
            if (result == System.Windows.Forms.DialogResult.Yes) this.Close();
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DateTime datedebut;
            DateTime datefin;

            if (txtboxNomProjet.Text == string.Empty)
            {
                MessageBox.Show("Nom de projet obligatoire", "Information manquante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxNomProjet.Focus();
            }            
            else if (!msktxtboxDateDebut.MaskCompleted)
            {
                MessageBox.Show("Date de début obligatoire", "Information manquante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxtboxDateDebut.Focus();
            }
            else if (!msktxtboxDateFin.MaskCompleted)
            {
                MessageBox.Show("Date de fin obligatoire", "Information manquante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                msktxtboxDateFin.Focus();
            }
            else if (txtboxMontantContrat.Text == string.Empty)
            {
                MessageBox.Show("Montant obligatoire", "Information manquante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtboxMontantContrat.Focus();
            }
            else
            {
                datedebut = Convert.ToDateTime(msktxtboxDateDebut.Text);
                datefin = Convert.ToDateTime(msktxtboxDateFin.Text);

                if (datefin < datedebut)
                {
                    errorProviderObligatoire.SetError(msktxtboxDateFin, "Date de fin de projet < date de debut de projet");
                }
                else
                {
                    Random rdom = new Random();
                    string nom = txtboxNomProjet.Text;
                    Client clt = (Client)comboBoxClient.SelectedItem;
                    decimal montant = Convert.ToDecimal (txtboxMontantContrat.Text);
                    Collaborateur colla = (Collaborateur)comboBoxResponsable.SelectedItem;
                    ProjetForfait proj = new ProjetForfait(0, nom, datedebut, datefin, clt, msktxtboxContact.Text, txtboxMailContact.Text, montant, radbutPenalOui.Checked, colla);

                    if (butCreerClick)
                    { int codProj;
                        
                        if (!DaoProjet.AddProjet(proj,out codProj))
                        {
                            MessageBox.Show("Nom de projet déjâ présent");
                        }
                        else
                        {
                            //Affiche le projet forfait créer
                            MessageBox.Show(proj.ToString());
                            projetForfaitBindingSource.Add(proj);
                            BoxEnable(false);
                            comboBoxProjets.Enabled = true;
                            //projetForfaitBindingSource.ResetBindings(true);
                            InitDataBindingsBox(false);
                        }
                        proj.CodeProjet = codProj;
                        projetForfaitBindingSource.Add(proj);
                        butCreerClick = false;
                        btnSupprimer.Enabled = true;
                    }
                    else if (butModifierClick)
                    {
                        proj.CodeProjet = projModif.CodeProjet;

                        if (DaoProjet.UpdProjet(indexModif, proj))
                        {
                            projetForfaitBindingSource.RemoveAt(indexModif);
                            projetForfaitBindingSource.Add(proj);
                            //projetForfaitBindingSource.ResetCurrentItem();
                            MessageBox.Show("Projet modifier");
                        }
                        else
                        {
                            MessageBox.Show("Projet non modifier");
                        }
                        BoxEnable(false);
                        butModifierClick = false;
                        comboBoxProjets.Enabled = true;                        
                        projetForfaitBindingSource.ResetBindings(true);
                        InitDataBindingsBox(false);
                        btnModifier.Enabled = true;
                    }
                }
            }
           

        }
         
        private void msktxtboxDateDebut_Validating_1(object sender, CancelEventArgs e)
        {

            DateTime result;
            if (msktxtboxDateDebut.MaskCompleted && DateTime.TryParse(msktxtboxDateDebut.Text, out result))
            {
                msktxtboxDateDebut.Text = result.ToString();
                errorProviderObligatoire.SetError(msktxtboxDateDebut, string.Empty);
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
                errorProviderObligatoire.SetError(msktxtboxDateDebut, "Date pas complete format dd/mm/yyyy");

            }
        }

        private void msktxtboxDateFin_Validating(object sender, CancelEventArgs e)
        {

            DateTime result;
            if (msktxtboxDateFin.MaskCompleted && DateTime.TryParse(msktxtboxDateFin.Text, out result))
            {
                msktxtboxDateFin.Text = result.ToString();
                errorProviderObligatoire.SetError(msktxtboxDateFin, string.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProviderObligatoire.SetError(msktxtboxDateFin, "Date pas complete format dd/mm/yyyy");
                e.Cancel = true;
            }
        }

        private void txtboxMontantContrat_Validating(object sender, CancelEventArgs e)
        {
            
            
            if (txtboxMontantContrat.Text!=string.Empty)
            {
                
                errorProviderObligatoire.SetError(txtboxMontantContrat, string.Empty);
            }
            else
            {
                errorProviderObligatoire.SetError(txtboxMontantContrat, "Montant obligatoire");
                
            }
        }

        private void txtboxMontantContrat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtboxDateDebut_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressNumber(e);
        }

        private static void KeyPressNumber(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtboxDateFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressNumber(e);
        }
        private void txtboxMailContact_Validating(object sender, CancelEventArgs e)
        {
            if (txtboxMailContact.Text != string.Empty)
            {
                errorProviderObligatoire.SetError(txtboxMailContact, string.Empty);
                if (Regex.IsMatch(txtboxMailContact.Text, @"^([\w-\.])+@([\w]+\.)([a-zA-Z0-9]{2,4})$"))
                {
                    errorProviderObligatoire.SetError(txtboxMailContact, string.Empty);
                }
                else
                {
                    errorProviderObligatoire.SetError(txtboxMailContact, "Mail incomplet");
                    txtboxMailContact.Focus();
                }
            }
            
                
        }
       
        private void msktxtboxContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & e.KeyChar != (char)Keys.Back & e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void comboBoxProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProjets.SelectedItem != null)
            {
                grpboxForfait.Visible = true;
                grpboxProjet.Visible = true;
                btnSupprimer.Enabled = true;
                if (((ProjetForfait)comboBoxProjets.SelectedItem).PenaliteOuiNon == Penalite.Oui)
                {
                    radbutPenalOui.Checked = true;
                    radbutPenalNon.Checked = false;
                }
                else
                {
                    radbutPenalOui.Checked = false;
                    radbutPenalNon.Checked = true;
                }
                TimeSpan chrgAff = ((ProjetForfait)comboBoxProjets.SelectedItem).DFin - ((ProjetForfait)comboBoxProjets.SelectedItem).DDebut;
                mskTextboxChargeAffectee.Text = Convert.ToString(chrgAff.Days);
            }
            btnModifier.Enabled = true;
            
           
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {   
            DialogResult result;            
            // Affiche la MessageBox.
            string message= "Confirmez-vous la suppression du projet "+ txtboxNomProjet.Text ;
            result = MessageBox.Show(message,"SUPPRESSION PROJET",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //Si yes est appuier sur la message box cela supprime le projet
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (DaoProjet.DelProjet((ProjetForfait)comboBoxProjets.SelectedItem))
                {
                    projetForfaitBindingSource.RemoveAt(comboBoxProjets.SelectedIndex);
                    MessageBox.Show("Projet supprimer");
                    //Mets a jour le databinding source
                    projetForfaitBindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Projet non supprimer");
                }
            }

                
                       
            Initialisation();
            comboBoxProjets.Enabled = true;
            BoxEnable(false);
            butModifierClick = false;
            butCreerClick = false;

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            InitDataBindingsBox(false);
            Initialisation();
            BoxEnable(false);
            comboBoxProjets.Enabled = true;
            butModifierClick = false;
            butCreerClick = false;
            btnSupprimer.Enabled = true;
            btnModifier.Enabled = true;


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            projModif =  (ProjetForfait)comboBoxProjets.SelectedItem;
            indexModif = comboBoxProjets.SelectedIndex;
            InitDataBindingsBox(true);            
            

            txtboxNomProjet.Text = projModif.NomProjet;
            msktxtboxDateDebut.Text = Convert.ToString(projModif.DDebut);
            msktxtboxDateFin.Text = Convert.ToString(projModif.DFin);
            comboBoxClient.SelectedItem = projModif;
            msktxtboxContact.Text = projModif.Contact;
            txtboxMailContact.Text = projModif.MailContact;
            comboBoxResponsable.SelectedItem = projModif.ChefDeProjet;
            txtboxMontantContrat.Text = Convert.ToString(projModif.MontantContrat);
            if (projModif.PenaliteOuiNon==Penalite.Oui)
            {
                radbutPenalOui.Checked = true;
                radbutPenalNon.Checked = false;
            }
            else
            {
                radbutPenalOui.Checked = false;
                radbutPenalNon.Checked = true;
            }
            
            




            BoxEnable(true);            
            comboBoxProjets.Enabled = false;
            btnSupprimer.Enabled = false;
            txtboxNomProjet.Focus();
            btnModifier.Enabled = false;
            butModifierClick = true;
            

        }

        private void BoxEnable(bool enable)
        {
            
            txtboxNomProjet.Enabled = enable;
            msktxtboxDateDebut.Enabled = enable;
            msktxtboxDateFin.Enabled = enable;
            comboBoxClient.Enabled = enable;
            msktxtboxContact.Enabled = enable;
            txtboxMailContact.Enabled = enable;
            comboBoxResponsable.Enabled = enable;
            txtboxMontantContrat.Enabled = enable;
            grpboxPenalites.Enabled = enable;
            btnValider.Enabled = enable;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            //TODO terminer creer new projet forfait pour voir
            InitDataBindingsBox(true);
            Initialisation();
            grpboxForfait.Visible = true;
            grpboxProjet.Visible = true;
            comboBoxProjets.Enabled = false;
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            BoxEnable(true);
            txtboxNomProjet.Focus();
            butCreerClick = true;
            mskTextboxChargeAffectee.Clear();            
        }

        private void InitDataBindingsBox(bool enable)
        {
            if (enable)
            {
                projetForfaitBindingSource.SuspendBinding();
            }
            else if (!enable)
            {
                projetForfaitBindingSource.ResumeBinding();
            }
        }






    }
}
