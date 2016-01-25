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
            if (comboBoxProjets.SelectedItem != null) previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions(((ProjetForfait)comboBoxProjets.SelectedItem).CodeProjet);
            btnCreer.Enabled = true;
            

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            grpboxPrevision.Visible = false;
            comboBoxProjets.Enabled = true;
            btnCreer.Enabled = true;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (butModifierClick)
            {
                
                if (DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions(((ProjetForfait)comboBoxProjets.SelectedItem).CodeProjet).Find(p => p.LaQualif.Equals(comboBoxQualification.SelectedItem)) == null 
                    || (Qualification)comboBoxQualification.SelectedItem == ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif)
                {

                    Qualification qualif = ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif;
                    qualif = (Qualification)comboBoxQualification.SelectedItem;
                    nbJours.Value = numericUpDownNbJours.Value;
                    
                    Prevision pr = new Prevision((int)codePrev.Value,((ProjetForfait)comboBoxProjets.SelectedItem).CodeProjet, qualif, (short)numericUpDownNbJours.Value);
                    DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].UpgPrevision(pr);
                    butModifierClick = false;
                    grpboxPrevision.Visible = false;
                    comboBoxProjets.Enabled = true;
                    btnCreer.Enabled = true;

                    //Mets  a jours les données du databinding prevision.
                    previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions(((ProjetForfait)comboBoxProjets.SelectedItem).CodeProjet);
                    previsionBindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Qualification déjà présente");
                }
                    


            }
            else if (butCreerClick)
            {
                if (DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions(((ProjetForfait)comboBoxProjets.SelectedItem).CodeProjet).Find(p => p.LaQualif.Equals(comboBoxQualification.SelectedItem)) == null)
                {
                    DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].AddPrevision(new Prevision((Qualification)comboBoxQualification.SelectedItem, (short)numericUpDownNbJours.Value));

                    Prevision prev = new Prevision((Qualification)comboBoxQualification.SelectedItem, (short)numericUpDownNbJours.Value);
                    DaoProjet.AddPrevision(prev);
                    butCreerClick = false;
                    grpboxPrevision.Visible = false;
                    comboBoxProjets.Enabled = true;
                    btnCreer.Enabled = true;

                    //Mets  a jours les données du databinding prevision.
                    previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions(((ProjetForfait)comboBoxProjets.SelectedItem).CodeProjet);
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
            cell = dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[e.ColumnIndex];
            nbJours = dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[1];
            modif = dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[2];
            codePrev = dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[5];

            if (cell.Value.ToString()=="Supprimer")
            {
                if (DaoProjet.DelPrevision((int)codePrev.Value))
                {
                    dataGridViewLesPrevisions.Rows.RemoveAt(e.RowIndex);
                    DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].DelPrevision((int)dataGridViewLesPrevisions.Rows[e.RowIndex].Cells[5].Value);
                    MessageBox.Show("Prévision supprimer");
                }
                else
                {
                    MessageBox.Show("Prévision non supprimer");
                }


            }
            else if (cell.Value.ToString() == "Modifier")//Permet de modifier la valeur des informations de la ligne.
            {   //Active les controles de modification et désactive les controles inutile.
                grpboxPrevision.Visible = true;
                butModifierClick = true;
                btnCreer.Enabled = false;
                comboBoxProjets.Enabled = false;

                comboBoxQualification.SelectedItem = ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif;
                numericUpDownNbJours.Value =Convert.ToDecimal(nbJours.Value);

            }

        }


    }
}
