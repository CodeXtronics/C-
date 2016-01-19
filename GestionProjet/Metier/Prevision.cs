using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Metier
{
    class Prevision
    {

        public Qualification LaQualif { get; set; }
        public short NbJours { get; set; }
        public Prevision() { }
        public Prevision(Qualification qualification, short nbJ)
        {
            LaQualif = qualification;
            NbJours = nbJ;
        }



    }
}
