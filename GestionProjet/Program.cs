﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionProjet.Vues;

namespace GestionProjet
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Dao.DaoProjet.Init();
            Application.Run(new FrmAccueil());
            //Application.Run(new Prévisions());
        }
    }
}
