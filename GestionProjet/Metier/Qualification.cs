using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionProjet.Metier
{
    class Qualification:IEquatable<object>
    {
        public sbyte CodeQualif { get; set; }
        public string Libelle { get; set; }
        public decimal PvJournee { get; set; }
        public Qualification Self { get { return this; }  }
        public Qualification() { }
        public Qualification(sbyte cq,string l,decimal pj)
        {
            CodeQualif = cq;
            Libelle = l;
            PvJournee = pj;
        }
        public override bool Equals(object obj)
        {
            if(obj is Qualification)
            {
                return Libelle == ((Qualification)obj).Libelle;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return CodeQualif + "," + Libelle + "," + PvJournee;
        }
    }
}
