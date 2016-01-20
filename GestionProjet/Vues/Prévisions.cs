﻿using System;
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

        SqlCommand sqlCde;
        SqlDataReader sqlRdr;
        SqlConnection sqlConnect;
        


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
        private void ConnectSQLServ()
        {
            
            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = "Data Source = (local);" + "Initial Catalog = GesProjet;" +
                "Integrated Security = True;" + "Connection TimeOut=5";

            
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
            //if(comboBoxProjets.SelectedItem!=null)previsionBindingSource.DataSource = DaoProjet.GetAllProjets()[comboBoxProjets.SelectedIndex].GetPrevisions();
            //btnCreer.Enabled = true;
            try
            {
                // Ouvre la connection. 
                sqlConnect.Open();
                // Création de la commande  
                sqlCde = new SqlCommand();
                sqlCde.Connection = sqlConnect;
                // Constitution Requête SQL  
                string strSql = "exec GetAllProjet";
                // Positionnement des propriétés  
                sqlCde.CommandType = CommandType.Text;
                sqlCde.CommandText = strSql;
                // Exécution de la commande  
                sqlRdr = sqlCde.ExecuteReader();
                // Lecture des données du DataReader  
                while (sqlRdr.Read())
                {
                    //int numE = sqlRdr.GetInt16(0);
                    string nomE = sqlRdr.GetString(5);
                    MessageBox.Show(nomE, "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Fin des données  
                sqlRdr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de connexion à la base", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { sqlConnect.Close(); }

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
                //if(Previsio comboBoxQualification.SelectedItem)
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
            else if (butCreerClick)
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
            try
            {
                // Ouvre la connection. 
                sqlConnect.Open();
                // Création de la commande  
                sqlCde = new SqlCommand();
                sqlCde.Connection = sqlConnect;
                // Constitution Requête SQL  
                string strSql = "Select * from Projet";
                // Positionnement des propriétés  
                sqlCde.CommandType = CommandType.Text;
                sqlCde.CommandText = strSql;
                // Exécution de la commande  
                sqlRdr = sqlCde.ExecuteReader();
                // Lecture des données du DataReader  
                while (sqlRdr.Read())
                {
                    //int numE = sqlRdr.GetInt16(0);
                    string nomE = sqlRdr.GetString(5);
                    MessageBox.Show(nomE, "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                // Fin des données  
                sqlRdr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur de connexion à la base", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { sqlConnect.Close(); }
        }
    }
}
