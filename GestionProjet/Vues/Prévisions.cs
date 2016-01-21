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
        bool butModifierClick;
        bool butCreerClick;

        

        public Prévisions()
        {
            InitializeComponent();
        }

        private void Prévisions_Load(object sender, EventArgs e)
        {

            projetForfaitBindingSource.DataSource = DaoProjet.GetAllProjets();            
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
            if (comboBoxProjets.SelectedItem != null) previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions();
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
                
                if (DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions().Find(p => p.LaQualif.Equals(comboBoxQualification.SelectedItem)) == null 
                    || (Qualification)comboBoxQualification.SelectedItem == ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif)
                {
                    ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif = (Qualification)comboBoxQualification.SelectedItem;
                    nbJours.Value = numericUpDownNbJours.Value;

                    butModifierClick = false;
                    grpboxPrevision.Visible = false;
                    comboBoxProjets.Enabled = true;
                    btnCreer.Enabled = true;

                    //Mets  a jours les données du databinding prevision.
                    previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions();
                    previsionBindingSource.ResetBindings(true);
                }
                else
                {
                    MessageBox.Show("Qualification déjà présente");
                }
                    


            }
            else if (butCreerClick)
            {
                if (DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions().Find(p => p.LaQualif.Equals(comboBoxQualification.SelectedItem)) == null)
                {
                    DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].AddPrevision(new Prevision((Qualification)comboBoxQualification.SelectedItem, (short)numericUpDownNbJours.Value));
                    butCreerClick = false;

                    grpboxPrevision.Visible = false;
                    comboBoxProjets.Enabled = true;
                    btnCreer.Enabled = true;

                    //Mets  a jours les données du databinding prevision.
                    previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions();
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

            if (cell.Value.ToString()=="Supprimer")
            {                
                dataGridViewLesPrevisions.Rows.RemoveAt(e.RowIndex);
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

        private void btnConnection_Click(object sender, EventArgs e)
        {
            
            // création de la connection 
           
        }
    }
}
