using System;
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
                        return null;
                    }
                    finally { sqlConnect.Close(); }
                }
            }
        }
        public static bool UpdProjet(int i,ProjetForfait pr)
        {
            if (Projets.Find(p => p.Equals(pr,false))!=null)
            {
                Projets.RemoveAt(i);            
                Projets.Insert(i,pr);
                return true;
            }
            else
            {
                return false;
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
                        return false;
                    }
                    finally { sqlConnect.Close(); }
                }
            }

        }        
      
        public static bool AddProjet(ProjetForfait pr)
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
                        sqlCde.Parameters.Add(new SqlParameter("@IdQualif", System.Data.SqlDbType.TinyInt)).Value = pr.ChefDeProjet.LaQualif.CodeQualif;
                        sqlCde.Parameters.Add(new SqlParameter("@idtypep", System.Data.SqlDbType.TinyInt)).Value = 1;//TODO voir quoi faire pour le type
                        sqlCde.Parameters.Add(new SqlParameter("@nomprojet", System.Data.SqlDbType.VarChar, 30)).Value = pr.NomProjet;
                        sqlCde.Parameters.Add(new SqlParameter("@ddebut", System.Data.SqlDbType.Date)).Value = pr.DDebut;
                        sqlCde.Parameters.Add(new SqlParameter("@dfin", System.Data.SqlDbType.Date)).Value = pr.DFin;
                        sqlCde.Parameters.Add(new SqlParameter("@contactclient", System.Data.SqlDbType.VarChar, 30)).Value = pr.Contact;
                        sqlCde.Parameters.Add(new SqlParameter("@mailcontact", System.Data.SqlDbType.VarChar, 30)).Value = pr.MailContact;
                        sqlCde.Parameters.Add(new SqlParameter("@tarifjournalier", System.Data.SqlDbType.Money)).Value = pr.ChefDeProjet.PrJournalier;
                        sqlCde.Parameters.Add(new SqlParameter("@mtContrat", System.Data.SqlDbType.Money)).Value = pr.MontantContrat;
                        sqlCde.Parameters.Add(new SqlParameter("@penaliteOuiNon", System.Data.SqlDbType.Bit)).Value = pr.PenaliteOuiNon;

                        //affectation du parametre OUT à la procédure stockée
                        SqlParameter pOut = new SqlParameter("@idProjet", System.Data.SqlDbType.Int);
                        pOut.Direction = System.Data.ParameterDirection.Output;
                        sqlCde.Parameters.Add(pOut);
                        // Exécution de la commande  
                        sqlRdr = sqlCde.ExecuteReader();
                        sqlRdr.Close();


                        return true;




                    }
                    catch (Exception ex)
                    {
                        return false;
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
            catch (Exception)
            {
                return null;
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
                                    CodeClient=sqlRdr.GetInt32(6)
                                },
                                MontantContrat = sqlRdr.GetDecimal(7),
                                PenaliteOuiNon = pen,
                                ChefDeProjet = new Collaborateur()
                                {
                                    CodeColl = sqlRdr.GetInt32(9)

                                }
                                
                                
                                    
                            };
                            Projets.Add(proj);
                            
                            
                        }

                        // Fin des données  
                        sqlRdr.Close();
                        return Projets;
                    }
                    catch (Exception ex)
                    {
                        return  null;
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
                        return null;
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
                        return null;
                    }
                    finally { sqlConnect.Close(); }
                }

            }

        }
        /*public static void Init()
        {

            
            Qualifications = new List<Qualification>
            {
                new Qualification(1,"Chef de projet", 800),
                new Qualification(2,"Concepteur Developpeur", 500),
                new Qualification(3,"Développeur", 400),
                new Qualification(4,"Architecte",800)
            };
            Collaborateurs = new List<Collaborateur>
            {
                new Collaborateur(1,"Valentini" , "Alain",new DateTime(2004,9,30), 500, Qualifications[0]),
                new Collaborateur(2,"Laridan" , "Louise",new DateTime(2014,1,15), 250, Qualifications[1]),
                new Collaborateur(3,"Bekchiche" , "Said",new DateTime(2012,9,1), 300, Qualifications[1]),
                new Collaborateur(4,"Paradis" , "Vanessa",new DateTime(2014,10,01), 200, Qualifications[2]),
                new Collaborateur(5,"Pitt" , "Brad",new DateTime(2014,10,01), 200, Qualifications[2]),
                new Collaborateur(6,"Bruel" , "Patrick",new DateTime(2014,9,01), 800, Qualifications[3])
            };
            Clients = new List<Client>
            {
                new Client(1,"Ets les moulins","Avenue du bateau blanc",null,"12345", "Champouxville","1111111111", "contact@lesmoulins.com"),
                new Client(2,"Haribo France","67, Avenue du Capitaine Geze", null, "13013", "Marseille", "0101010101", null)
            };

            Projets = new List<ProjetForfait>
            {
                new ProjetForfait(8520, "Gesbonbon", new DateTime(2015,02,01), new DateTime(2015,05,30),Clients[1],"Catherine Tagada","c.tagada@haribo.fr",100000,true,Collaborateurs[0],
                     new List<Prevision>
                    {
                        new Prevision(Qualifications[0],36),
                        new Prevision(Qualifications[1],72),
                        new Prevision(Qualifications[2],726)
                    }),
                new ProjetForfait(2003, "SansPrevision", new DateTime(2014,12,15),new DateTime(2014,05,30),Clients[0],"Catherine Tagada","ctagada@haribo.fr",100000,false,Collaborateurs[0])
                //new ProjetRegie(1001, "Gescom", new DateTime(2014,12,1),new DateTime(2015,03,31),Clients[0], "Catherine Tagada","ctagada@haribo.fr",450,Qualifications[1]),
                //new ProjetRegie(1002, "Gescom", new DateTime(2015,01,5),new DateTime(2015,01,31),Clients[0], "Catherine Tagada","ctagada@haribo.fr",400,Qualifications[2])
            };
        }*/
            

     
    }
}
