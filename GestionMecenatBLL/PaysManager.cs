using GestionMecenatBO;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBLL
{
    public class PaysManager
    {
        private static PaysManager uneInstance;

        // Création d'une instance du Manager
        public static PaysManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PaysManager();
            }
            return uneInstance;
        }

        private PaysManager()
        {
        }

        // Appel de la méthode GetLesPays de la DAO
        public List<Pays> GetLesPays()
        {
            return PaysDAO.GetInstance().GetLesPays();
        }

    }
}
