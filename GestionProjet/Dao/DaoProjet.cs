﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GestionProjet.Dao
{

    using GestionProjet.Metier;
    
    class DaoProjet
    {
        // pas de constructeurs
        // cette classe n'existe que pour accéder aux données

        public static List<ProjetForfait> Projets;
        private static List<Client> Clients;	
        private static List<Collaborateur> Collaborateurs;	
        private static List<Qualification> Qualifications;
        private static List<Prevision> Prevision;

        public static List<Qualification> GetAllQualifications()
        {
            using (SqlConnection sqlConnect = ConnectSQLServ())
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
                        // Constitution Requête SQL  

                        //sqlCde.CommandText = strSql;
                        sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCde.CommandText = "GetAllQualifications";
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        Qualifications = new List<Qualification>();
                        while (sqlRdr.Read())
                        {
                            Qualification qualif = new Qualification()
                            {
                                CodeQualif = (sbyte)sqlRdr.GetByte(0),
                                Libelle = sqlRdr.GetString(1),
                                PvJournee=sqlRdr.GetDecimal(2)
                            };
                            Qualifications.Add(qualif);
                        }
                        sqlRdr.Close();

                        return Qualifications;




                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Récupération des qualifications impossible  : " + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }
        }
        public static bool UpdProjet(ProjetForfait pr)
        {
            using (SqlConnection sqlConnect = ConnectSQLServ())
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
                        sqlCde.CommandText = "UpdProjet";
                        //affectation du parametre à la procédure stockée
                        sqlCde.Parameters.Add(new SqlParameter("@idProjet", System.Data.SqlDbType.Int)).Value = pr.CodeProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@idColl", System.Data.SqlDbType.Int)).Value = pr.ChefDeProjet.CodeColl;
                        sqlCde.Parameters.Add(new SqlParameter("@IdClient", System.Data.SqlDbType.Int)).Value = pr.LeClient.CodeClient;
                        sqlCde.Parameters.Add(new SqlParameter("@IdQualif", System.Data.SqlDbType.TinyInt)).Value = null;
                        sqlCde.Parameters.Add(new SqlParameter("@idtypep", System.Data.SqlDbType.TinyInt)).Value = 1;//TODO voir quoi faire pour le type
                        sqlCde.Parameters.Add(new SqlParameter("@nomprojet", System.Data.SqlDbType.VarChar, 30)).Value = pr.NomProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@ddebut", System.Data.SqlDbType.Date)).Value = pr.DDebut;
                        sqlCde.Parameters.Add(new SqlParameter("@dfin", System.Data.SqlDbType.Date)).Value = pr.DFin;
                        sqlCde.Parameters.Add(new SqlParameter("@contactclient", System.Data.SqlDbType.VarChar, 30)).Value = pr.Contact;
                        sqlCde.Parameters.Add(new SqlParameter("@mailcontact", System.Data.SqlDbType.VarChar, 30)).Value = pr.MailContact;
                        sqlCde.Parameters.Add(new SqlParameter("@tarifjournalier", System.Data.SqlDbType.Money)).Value = null;
                        sqlCde.Parameters.Add(new SqlParameter("@mtContrat", System.Data.SqlDbType.Money)).Value = pr.MontantContrat;
                        sqlCde.Parameters.Add(new SqlParameter("@penaliteOuiNon", System.Data.SqlDbType.Bit)).Value = pr.PenaliteOuiNon;
                        
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();

                        

                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Modification projet impossible  : " + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }            
        }
        public static bool DelProjet(ProjetForfait pr)
        {
            using (SqlConnection sqlConnect = ConnectSQLServ())
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
                        sqlCde.CommandText = "DelProjet";
                        //affectation du parametre à la procédure stockée
                        sqlCde.Parameters.Add(new SqlParameter("@IdProjet", System.Data.SqlDbType.Int)).Value = pr.CodeProjet;
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        sqlRdr.Close();

                        return true;




                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Suppression du projets impossible  : " + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }

        }        
      
        public static bool AddProjet(ProjetForfait pr,out int idproj)
        {

            using (SqlConnection sqlConnect = ConnectSQLServ())
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
                        sqlCde.CommandText = "AddProjet";
                        //affectation du parametre à la procédure stockée
                        sqlCde.Parameters.Add(new SqlParameter("@idColl", System.Data.SqlDbType.Int)).Value = pr.ChefDeProjet.CodeColl;
                        sqlCde.Parameters.Add(new SqlParameter("@IdClient", System.Data.SqlDbType.Int)).Value = pr.LeClient.CodeClient;
                        sqlCde.Parameters.Add(new SqlParameter("@IdQualif", System.Data.SqlDbType.TinyInt)).Value = null;
                        sqlCde.Parameters.Add(new SqlParameter("@idtypep", System.Data.SqlDbType.TinyInt)).Value = 1;//TODO voir quoi faire pour le type
                        sqlCde.Parameters.Add(new SqlParameter("@nomprojet", System.Data.SqlDbType.VarChar, 30)).Value = pr.NomProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@ddebut", System.Data.SqlDbType.Date)).Value = pr.DDebut;
                        sqlCde.Parameters.Add(new SqlParameter("@dfin", System.Data.SqlDbType.Date)).Value = pr.DFin;
                        sqlCde.Parameters.Add(new SqlParameter("@contactclient", System.Data.SqlDbType.VarChar, 30)).Value = pr.Contact;
                        sqlCde.Parameters.Add(new SqlParameter("@mailcontact", System.Data.SqlDbType.VarChar, 30)).Value = pr.MailContact;
                        sqlCde.Parameters.Add(new SqlParameter("@tarifjournalier", System.Data.SqlDbType.Money)).Value = null;
                        sqlCde.Parameters.Add(new SqlParameter("@mtContrat", System.Data.SqlDbType.Money)).Value = pr.MontantContrat;
                        sqlCde.Parameters.Add(new SqlParameter("@penaliteOuiNon", System.Data.SqlDbType.Bit)).Value = pr.PenaliteOuiNon;

                        //affectation du parametre OUT à la procédure stockée
                        SqlParameter pOut = new SqlParameter("@idProjet", System.Data.SqlDbType.Int);
                        pOut.Direction = System.Data.ParameterDirection.Output;
                        sqlCde.Parameters.Add(pOut);

                        

                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();

                        idproj = (int)sqlCde.Parameters[12].Value;

                        return true;
                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Ajout projet impossible  : " + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }
        }
        public static SqlConnection ConnectSQLServ()
        {                       
            SqlConnection sqlConnect;

            sqlConnect = new SqlConnection();
            sqlConnect.ConnectionString = "Data Source = (local);" + "Initial Catalog = GesProjet;" +
                "Integrated Security = True;" + "Connection TimeOut=5";
            try
            {
                // Ouvre la connection.
                sqlConnect.Open();
                return sqlConnect;
            }
            catch (Exception ex)
            {
                throw new DaoException("Connection impossible  : " + ex.Message, ex);
            }
            finally { sqlConnect.Close(); }

        }
        public static List<ProjetForfait> GetAllProjets()
        {
            using (SqlConnection sqlConnect = ConnectSQLServ())
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
                        // Constitution Requête SQL  
                        //string strSql = "Select * from Projet";
                        //// Positionnement des propriétés  
                        
                        //sqlCde.CommandText = strSql;
                        sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCde.CommandText = "GetAllProjetForfaits";
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        // Lecture des données du DataReader 
                        Projets = new List<ProjetForfait>();
                        while (sqlRdr.Read())
                        {
                            Penalite pen;
                            if (sqlRdr.GetBoolean(8))pen = Penalite.Oui;
                            else pen = Penalite.Non;
                            ProjetForfait proj = new ProjetForfait()
                            {
                                CodeProjet = sqlRdr.GetInt32(0),
                                NomProjet = sqlRdr.GetString(1),
                                DDebut = sqlRdr.GetDateTime(2),
                                DFin = sqlRdr.GetDateTime(3),
                                Contact = sqlRdr[4].ToString(),
                                MailContact = sqlRdr[5].ToString(),
                                LeClient = new Client()
                                {
                                    CodeClient = sqlRdr.GetInt32(6)
                                },
                                MontantContrat = sqlRdr.GetDecimal(7),
                                PenaliteOuiNon = pen,
                                ChefDeProjet = new Collaborateur()
                                {
                                    CodeColl = sqlRdr.GetInt32(9)

                                },
                                prevision = new List<Prevision>()
                                
                                
                                
                                    
                            };
                            Projets.Add(proj);
                            
                            
                        }

                        // Fin des données  
                        sqlRdr.Close();
                        return Projets;
                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Récupération des projets impossible  : " + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }
                
                    
        }
        public static List<Collaborateur> GetAllCollaborateurs()
        {
            using (SqlConnection sqlConnect = ConnectSQLServ())
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
                        // Constitution Requête SQL  
                        //string strSql = "Select * from Projet";
                        //// Positionnement des propriétés  

                        //sqlCde.CommandText = strSql;
                        sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCde.CommandText = "GetAllCollaborateur";
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        // Lecture des données du DataReader 
                        Collaborateurs = new List<Collaborateur>();
                        while (sqlRdr.Read())
                        {

                            Collaborateur coll = new Collaborateur()
                            {
                                CodeColl = sqlRdr.GetInt32(0),
                                LaQualif = new Qualification()
                                {
                                    CodeQualif = (sbyte)sqlRdr.GetByte(1)
                                },
                                Nom = sqlRdr.GetString(2),
                                PreNom = sqlRdr.GetString(3),
                                DEmbauche = sqlRdr.GetDateTime(4),
                                PrJournalier = sqlRdr.GetDecimal(5)
                               

                            };
                            Collaborateurs.Add(coll);


                        }

                        // Fin des données  
                        sqlRdr.Close();
                        return Collaborateurs;
                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Récupération des collaborateur impossible  :" + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }            
        }
        public static List<Client> GetAllClients()
        {
            using (SqlConnection sqlConnect = ConnectSQLServ())
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
                        // Constitution Requête SQL  
                        string strSql = "GetAllClients";
                        // Positionnement des propriétés  
                        sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlCde.CommandText = strSql;

                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        // Lecture des données du DataReader 
                        Clients = new List<Client>();
                        while (sqlRdr.Read())
                        {
                            Client clt = new Client()
                            {
                                CodeClient = sqlRdr.GetInt32(0),
                                RaisonSociale = sqlRdr.GetString(1),
                                Adresse1 = sqlRdr.GetString(2),
                                Adresse2 = sqlRdr[3].ToString(),
                                CP = sqlRdr.GetString(4),
                                Ville = sqlRdr.GetString(5),
                                Telephone = sqlRdr.GetString(6),
                                Mail = sqlRdr[7].ToString()                                
                            };
                            Clients.Add(clt);
                        }

                        // Fin des données  
                        sqlRdr.Close();
                        return Clients;
                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Récupération des clients impossible  :" + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }

            }

        }
        public static List<Prevision> GetAllPrevisions(int idProj)
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
                        //// Positionnement des propriétés
                        sqlCde.CommandText = strSql;
                        //sqlCde.CommandType = System.Data.CommandType.StoredProcedure;
                        //sqlCde.CommandText = "GetAllPrevisions";
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        // Lecture des données du DataReader 
                        Prevision = new List<Prevision>();
                        while (sqlRdr.Read())
                        {

                            Prevision prev = new Prevision()
                            {
                                CodePrevision = sqlRdr.GetInt32(0),
                                CodeProjet = sqlRdr.GetInt32(1),
                                LaQualif = new Qualification()
                                {
                                    CodeQualif = (sbyte)sqlRdr.GetByte(2)
                                },
                                NbJours = sqlRdr.GetInt16(3)

                            };
                            Prevision.Add(prev);


                        }

                        // Fin des données  
                        sqlRdr.Close();
                        
                        return Prevision;
                    }
                    catch (Exception ex)
                    {
                        throw new DaoException("Récupération des prevision impossible  :" + ex.Message, ex);
                    }
                    finally { sqlConnect.Close(); }
                }
            }

        }

        public static bool AddPrevision(Prevision pr)
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

        public static bool UpgPrevision(Prevision pr)
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
                        sqlCde.Parameters.Add(new SqlParameter("@idQualif", System.Data.SqlDbType.TinyInt)).Value = pr.LaQualif.CodeQualif;
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
        public static bool DelPrevision(Prevision pr)
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
                        sqlCde.CommandText = "DelPrevision";
                        //affectation du parametre à la procédure stockée
                        sqlCde.Parameters.Add(new SqlParameter("@idprevision", System.Data.SqlDbType.Int)).Value = pr.CodePrevision;
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

    }
}
