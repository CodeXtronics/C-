using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionProjet.Dao
{
    class DaoException : Exception
    {
        public DaoException() : base()
        {
        }

        public DaoException(string message)
            : base(message)
        {
        }
        public DaoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
