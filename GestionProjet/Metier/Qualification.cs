using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionProjet.Metier
{
    class Qualification
    {
        public sbyte CodeQualif { get; set; }
        public string Libelle { get; set; }
        public decimal PvJournee { get; set; }
        public Qualification Self { get { return this; }  }
        public Qualification(sbyte cq,string l,decimal pj)
        {
            CodeQualif = cq;
            Libelle = l;
            PvJournee = pj;
        }
        public override string ToString()
        {
            return CodeQualif + "," + Libelle + "," + PvJournee;
        }
    }
}
