using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionProjet.Metier
{
    class ProjetForfait : Projet, IEquatable<object>
    {
        

        public decimal MontantContrat{ get; set; }       
        public Collaborateur ChefDeProjet{ get; set; }
        private List<Prevision> prevision;
        public Penalite PenaliteOuiNon { get; set; }

        public List<Prevision> GetPrevisions()
        {
            return prevision;
        }
        public bool AddPrevision(Prevision pr)
        {
            prevision.Add(pr);
            return true;
        }
        public bool UpgPrevision(Prevision pr)
        {
            return true;
        }
        public bool DelPrevision(Prevision pr)
        {
            prevision.Remove(pr);
            return true;
        }




        public ProjetForfait() { }
        public ProjetForfait(int co, string n, DateTime dDebP, DateTime dFinP, Client client,string cont,string ml, int montContract, bool ouinon, Collaborateur colla)
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
        public ProjetForfait(int co, string n, DateTime dDebP, DateTime dFinP, Client client, string cont, string ml, int montContract, bool ouinon, Collaborateur collaborateur, List<Prevision> list)
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

