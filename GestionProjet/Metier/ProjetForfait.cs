using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace GestionProjet.Metier
{
    using Dao;
    class ProjetForfait : Projet
    {
        

        public decimal MontantContrat{ get; set; }       
        public Collaborateur ChefDeProjet{ get; set; }
        public List<Prevision> prevision;
        public Penalite PenaliteOuiNon { get; set; }

        public List<Prevision> GetPrevisions(int idProj)
        {
            using (SqlConnection sqlConnect = DaoProjet.ConnectSQLServ())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {
                    try
                    {
                        // Ouvre la connection. 
                        sqlConnect.Open();
                        // Création de la commande  
                        SqlDataReader sqlRdr;
                        sqlCde.Connection = sqlConnect;
                        // Constitution Requête SQL  +++++++++
                        string strSql = string.Format("Select * from Prevision where idProjet = '{0}'", idProj);
                        // Positionnement des propriétés
                        sqlCde.CommandText = strSql;
                        //sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        //sqlCde.CommandText = "GetAllPrevisions";
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        // Lecture des données du DataReader 
                        prevision = new List<Prevision>();
                        while (sqlRdr.Read())
                        {

                            Prevision prev = new Prevision()
                            {
                                CodePrevision = sqlRdr.GetInt32(0),
                                CodeProjet = sqlRdr.GetInt32(1),
                                LaQualif=new Qualification()
                                {
                                     CodeQualif = (sbyte)sqlRdr.GetByte(2)
                                },
                                NbJours=sqlRdr.GetInt16(3)

                            };
                            prevision.Add(prev);


                        }
                        
                        // Fin des données  
                        sqlRdr.Close();
                        return prevision;
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                    finally { sqlConnect.Close(); }
                }
            }
            
        }
        public bool AddPrevision(Prevision pr)
        {
            using (SqlConnection sqlConnect = DaoProjet.ConnectSQLServ())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {//TODO verifier le conflict
                    try
                    {
                        // Ouvre la connection. 
                        sqlConnect.Open();
                        // Création de la commande  
                        SqlDataReader sqlRdr;
                        sqlCde.Connection = sqlConnect;
                        // Constitution Requête SQL  

                        //sqlCde.CommandText = strSql;
                        sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCde.CommandText = "AddPrevision";
                        //affectation du parametre à la procédure stockée
                        sqlCde.Parameters.Add(new SqlParameter("@idProjet", System.Data.SqlDbType.Int)).Value = pr.CodeProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@idQualif", System.Data.SqlDbType.TinyInt)).Value = pr.LaQualif.CodeQualif;
                        sqlCde.Parameters.Add(new SqlParameter("@nbJours", System.Data.SqlDbType.SmallInt)).Value = pr.NbJours;

                        //affectation du parametre OUT à la procédure stockée
                        SqlParameter pOut = new SqlParameter("@idPrevision", System.Data.SqlDbType.Int);
                        pOut.Direction = System.Data.ParameterDirection.Output;
                        sqlCde.Parameters.Add(pOut);

                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        sqlRdr.Close();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Ajout prévision impossible  : " + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }
        }
        public bool UpgPrevision(Prevision pr)
        {
            using (SqlConnection sqlConnect = DaoProjet.ConnectSQLServ())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {//TODO verifier le conflict
                    try
                    {
                        // Ouvre la connection. 
                        sqlConnect.Open();
                        // Création de la commande  
                        SqlDataReader sqlRdr;
                        sqlCde.Connection = sqlConnect;
                        // Constitution Requête SQL  

                        //sqlCde.CommandText = strSql;
                        sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCde.CommandText = "UpdPrevision";
                        //affectation du parametre à la procédure stockée
                        sqlCde.Parameters.Add(new SqlParameter("@idPrevision", System.Data.SqlDbType.Int)).Value = pr.CodePrevision;
                        sqlCde.Parameters.Add(new SqlParameter("@idProjet", System.Data.SqlDbType.Int)).Value = pr.CodeProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@idQualif", System.Data.SqlDbType.TinyInt)).Value = pr.LaQualif;
                        sqlCde.Parameters.Add(new SqlParameter("@nbJours", System.Data.SqlDbType.SmallInt)).Value = pr.NbJours;
                        
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        sqlRdr.Close();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Modification prévision impossible  : " + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }
        }
        public bool DelPrevision(int pr)
        {
            using (SqlConnection sqlConnect =DaoProjet.ConnectSQLServ())
            {
                using (SqlCommand sqlCde = new SqlCommand())
                {//TODO verifier le conflict
                    try
                    {
                        // Ouvre la connection. 
                        sqlConnect.Open();
                        // Création de la commande  
                        SqlDataReader sqlRdr;
                        sqlCde.Connection = sqlConnect;
                        // Constitution Requête SQL  

                        //sqlCde.CommandText = strSql;
                        sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCde.CommandText = "DelPrevision";
                        //affectation du parametre à la procédure stockée
                        sqlCde.Parameters.Add(new SqlParameter("@idprevision", System.Data.SqlDbType.Int)).Value = pr;
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        sqlRdr.Close();

                        return true;




                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Suppression prévision impossible  : " + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }
        }
        public ProjetForfait() { }
        public ProjetForfait(int co, string n, DateTime dDebP, DateTime dFinP, Client client,string cont,string ml, decimal montContract, bool ouinon, Collaborateur colla)
        {            
            this.CodeProjet = co;
            this.NomProjet = n;
            this.DDebut = dDebP;
            this.DFin = dFinP;
            this.LeClient = client;
            this.Contact = cont;
            this.MailContact = ml;
            this.MontantContrat = montContract;
            this.ChefDeProjet = colla;
            if (ouinon)
            {
                PenaliteOuiNon = Penalite.Oui;
            }
            else
            {
                PenaliteOuiNon = Penalite.Non;
            }
            this.prevision = new List<Prevision> { } ;   
        }
        public ProjetForfait(int co, string n, DateTime dDebP, DateTime dFinP, Client client, string cont, string ml, decimal montContract, bool ouinon, Collaborateur collaborateur, List<Prevision> list)
        {
            this.CodeProjet = co;
            this.NomProjet = n;
            this.DDebut = dDebP;
            this.DFin = dFinP;
            this.LeClient = client;
            this.Contact = cont;
            this.MailContact = ml;
            this.MontantContrat = montContract;            
            this.ChefDeProjet = collaborateur;
            this.prevision = list;
            if (ouinon)
            {                
                PenaliteOuiNon = Penalite.Oui;
            }
            else
            {
                PenaliteOuiNon = Penalite.Non;                
            }
        }        
        public bool Equals(object other,bool nom)
        {
            if (other is ProjetForfait)
            {
                if (nom)
                {
                    return NomProjet == ((ProjetForfait)other).NomProjet;
                }
                else
                {
                    return CodeProjet == ((ProjetForfait)other).CodeProjet;
                }
            }
            else
            {
                return false;
            }
           
        }
        public override string ToString()
        {
            return "Projet : "+ NomProjet + ", n° " + CodeProjet + ", "  + "Durée du projet du :" + DDebut + " au " + DFin + "\n," + LeClient + ",\n Contact : " +  Contact + ", mail : " + MailContact + ", Montant du contrat" + MontantContrat + ",\n" + ChefDeProjet + ", Penalité de retard :  " + PenaliteOuiNon;
        }


    }
}

