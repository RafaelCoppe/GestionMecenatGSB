using GestionMecenatBO;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBLL
{
    public class AnneeManager
    {
        private static AnneeManager uneInstance;

        // Création d'une instance du Manager
        public static AnneeManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AnneeManager();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private AnneeManager()
        {
        }

        // Appel de la méthode GetLesAnnees de la DAO
        public List<Annee> GetLesAnneesDisponiblePourUnPays(int idPays)
        {
            return AnneeDAO.GetInstance().GetLesAnneesDisponiblePourUnPays(idPays);
        }

    }
}
