using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GestionProjet
{
    
    using Dao;
    using Metier;

    
    public partial class Prévisions : Form
    {
        DataGridViewCell nbJours;
        DataGridViewCell cell;
        DataGridViewCell modif;
        DataGridViewCell codePrev;
        bool butModifierClick;
        bool butCreerClick;
        ProjetForfait projSelect;



        public Prévisions()
        {
            InitializeComponent();
        }

        private void Prévisions_Load(object sender, EventArgs e)
        {

            projetForfaitBindingSource.DataSource = DaoProjet.GetAllProjets();
            //previsionBindingSource.DataSource = DaoProjet.GetAllPrevisions();            
            qualificationBindingSource.DataSource = DaoProjet.GetAllQualifications();
            comboBoxProjets.SelectedItem = null;
            btnCreer.Enabled = false;
        }
        

        private void btnCreer_Click(object sender, EventArgs e)
        {
            grpboxPrevision.Visible = true;
            comboBoxProjets.Enabled = false;
            butCreerClick = true;
            btnCreer.Enabled = false;
            comboBoxQualification.ResetText();
            numericUpDownNbJours.Value=0;
        }

        private void comboBoxProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProjets.SelectedItem != null)
            {
                InitPrevisionDataBinding();
            }


            btnCreer.Enabled = true;
            

        }

        private void InitPrevisionDataBinding()
        {
            projSelect = ((ProjetForfait)comboBoxProjets.SelectedItem);
            projSelect.prevision = DaoProjet.GetAllPrevisions(projSelect.CodeProjet);
            previsionBindingSource.DataSource = projSelect.prevision;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            grpboxPrevision.Visible = false;
            comboBoxProjets.Enabled = true;
            btnCreer.Enabled = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Qualification qualif;
            if (butModifierClick)
            {
                
                if (!projSelect.prevision.Exists(x => x.LaQualif.CodeQualif == ((Qualification)comboBoxQualification.SelectedItem).CodeQualif)
                    ||((Qualification)comboBoxQualification.SelectedItem).CodeQualif== ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif.CodeQualif)
                {

                    
                    qualif = (Qualification)comboBoxQualification.SelectedItem;
                    nbJours.Value = numericUpDownNbJours.Value;
                    
                    Prevision pr = new Prevision((int)codePrev.Value,projSelect.CodeProjet, qualif, (short)numericUpDownNbJours.Value);
                    if (DaoProjet.UpgPrevision(pr))
                    {
                        projSelect.UpgPrevision(pr);
                    } 
                    butModifierClick = false;
                    grpboxPrevision.Visible = false;
                    comboBoxProjets.Enabled = true;
                    btnCreer.Enabled = true;

                    //Mets  a jours les données du databinding prevision.
                    previsionBindingSource.ResetBindings(true);
                    //previsionBindingSource.DataSource = projSelect.prevision;
                    

                }
                else
                {
                    MessageBox.Show("Qualification déjà présente");
                }
                    


            }
            else if (butCreerClick)
            {

                if (!projSelect.prevision.Exists(x=>x.LaQualif.CodeQualif==((Qualification)comboBoxQualification.SelectedItem).CodeQualif))
                {
                    

                    Prevision prev = new Prevision(projSelect.CodeProjet,(Qualification)comboBoxQualification.SelectedItem, (short)numericUpDownNbJours.Value);
                    if (DaoProjet.AddPrevision(prev))
                    {
                        projSelect.AddPrevision(prev);
                    } 
                    butCreerClick = false;
                    grpboxPrevision.Visible = false;
                    comboBoxProjets.Enabled = true;
                    btnCreer.Enabled = true;

                    //Mets  a jours les données du databinding prevision.
                    previsionBindingSource.DataSource = projSelect.prevision;
                    previsionBindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Qualification déjà présente");
                }
            }
        }

        private void dataGridViewLesPrevisions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                cell = dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[e.ColumnIndex];
                nbJours = dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[1];
                modif = dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[2];
                codePrev = dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[5];

                if (cell.Value.ToString() == "Supprimer")
                {
                    DialogResult result;
                    // Affiche la MessageBox.
                    string message = "Confirmez-vous la suppression de la prévision " ;
                    result = MessageBox.Show(message, "SUPPRESSION PREVISION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //Si yes est appuier sur la message box cela supprime le projet
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (DaoProjet.DelPrevision(((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem)))
                        {

                            projSelect.DelPrevision(((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem));
                            previsionBindingSource.ResetBindings(true);
                            MessageBox.Show("Prévision supprimer");
                        }
                        else
                        {
                            MessageBox.Show("Prévision non supprimer");
                        }
                    }
                    


                }
                else if (cell.Value.ToString() == "Modifier")//Permet de modifier la valeur des informations de la ligne.
                {   
                    //Active les controles de modification et désactive les controles inutile.
                    grpboxPrevision.Visible = true;
                    butModifierClick = true;
                    btnCreer.Enabled = false;
                    comboBoxProjets.Enabled = false;

                    comboBoxQualification.SelectedItem = ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif;
                    numericUpDownNbJours.Value = Convert.ToDecimal(nbJours.Value);

                }
            }
            

        }


    }
}
