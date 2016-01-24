using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Metier
{
    class Prevision
    {
        public int CodePrevision { get; set; }
        public int CodeProjet { get; set; }
        public Qualification LaQualif { get; set; }
        public short NbJours { get; set; }
        public Prevision() { }
        public Prevision(int idPrev,int idProj,Qualification qualification, short nbJ)
        {
            CodePrevision = idPrev;
            CodeProjet = idProj;
            LaQualif = qualification;
            NbJours = nbJ;
        }
        public Prevision( Qualification qualification, short nbJ)
        {
            
            LaQualif = qualification;
            NbJours = nbJ;
        }


    }
}
