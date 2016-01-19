﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionProjet.Metier
{
    abstract class Projet:Random
    {
        public int CodeProjet { get; set; }
        public string NomProjet { get; set; }
        public DateTime DDebut { get; set; }
        public DateTime DFin { get; set; }
        public Client LeClient { get; set; }
        public string Contact { get; set; }
        public string MailContact { get; set; }


    }
}
