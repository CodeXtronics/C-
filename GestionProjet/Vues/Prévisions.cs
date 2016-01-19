using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            numericUpDownNbJours.ResetText();
        }

        private void comboBoxProjets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxProjets.SelectedItem!=null)previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions();
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
                ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif = (Qualification)comboBoxQualification.SelectedItem;
                nbJours.Value = numericUpDownNbJours.Value;
                previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions();
                butModifierClick = false;
                grpboxPrevision.Visible = false;
                comboBoxProjets.Enabled = true;
                btnCreer.Enabled = true;
            }
            else if (butCreerClick)
            {
                DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].AddPrevision(new Prevision((Qualification)comboBoxQualification.SelectedItem, (short)numericUpDownNbJours.Value));
                butCreerClick = false;
                previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions();
                grpboxPrevision.Visible = false;
                comboBoxProjets.Enabled = true;
                btnCreer.Enabled = true;
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
            else if (cell.Value.ToString() == "Modifier")
            {
                grpboxPrevision.Visible = true;
                comboBoxQualification.SelectedItem = ((Prevision)laQualifDataGridViewTextBoxColumn.DataGridView.CurrentRow.DataBoundItem).LaQualif;
                numericUpDownNbJours.Value =Convert.ToDecimal(nbJours.Value);
                butModifierClick = true;
                btnCreer.Enabled = false;
            }

        }
    }
}
