using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Metier
{
    class Client :IEquatable<Client>
    {
        private string raisonSociale;
        public int CodeClient { get; set; }
        public string RaisonSociale
        {
            get { return raisonSociale; }
            set { raisonSociale = value; }
        }
        public string Adresse1 { get; set; }
        public string Adresse2 { get; set; }
        public string CP { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Mail { get; set; }

        public Client() { }
        public Client(int cC,string rS,string adress1,string adress2,string cP,string ville,string tel,string mail)
        {
            CodeClient = cC;
            raisonSociale = rS;
            Adresse1 = adress1;
            Adresse2 = adress2;
            CP = cP;
            Ville = ville;
            Telephone = tel;


        }

        public override string ToString()
        {
            return "Réf " + CodeClient + "," +RaisonSociale + "," + Adresse1 + "," + Adresse2 + "," + CP + "," + Ville + ", tél : " +Telephone + ", Mail : " +Mail;
        }

        public bool Equals(Client other)
        {
            if (other is Client)
            {
                return CodeClient == ((Client)other).CodeClient;
            }
            return false;
        }
    }
}
