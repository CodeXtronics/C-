using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Metier
{
    class Collaborateur
    {
        public int CodeColl { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public DateTime DEmbauche { get; set; }
        public decimal PrJournalier { get; set; }
        public Qualification LaQualif { get; set; }
        public Collaborateur() { }
        public Collaborateur(int cc,string nom,string prenom,DateTime dEmbauche,decimal prixJrn,Qualification laQualif) 
        {
            CodeColl = cc;
            Nom = nom;
            PreNom = prenom;
            DEmbauche = dEmbauche;
            PrJournalier = prixJrn;
            LaQualif = laQualif;
        }
        public override string ToString()
        {
            return "N° "+CodeColl+", "+Nom + " " +PreNom + ", Date d'embauche : " +DEmbauche + ", Prix journalier : " +PrJournalier + ", Qualification " +LaQualif;
        }
    }
}
