using GestionMecenatBO;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBLL
{
    public class PartenariatManager
    {
        public static PartenariatManager uneInstance;
        public static PartenariatManager GetInstance() //Création d'une instance du Manager
        {
            if (uneInstance == null)
            {
                uneInstance = new PartenariatManager();
            }
            return uneInstance;
        }

        private PartenariatManager()
        {
        }

        //Appel de la méthode GetPartenariats de la DAO
        public List<Partenariat> GetLesPartenariats()
        {
            return PartenariatDAO.GetInstance().GetPartenariats();
        }

        //Appel de la méthode AjoutPartenariat de la DAO
<<<<<<< HEAD
        public int AjoutPartenariat(float budgetPrevisionnel, float coutPartenariat, int uneActionMenee, int uneAssociation)
=======
        public int AjoutPartenariat(decimal budgetPrevisionnel, decimal coutPartenariat, ActionMenee uneActionMenee, Association uneAssociation)
>>>>>>> master
        {
            Partenariat unPartenariat = new Partenariat(budgetPrevisionnel, coutPartenariat, uneActionMenee, uneAssociation);
            return PartenariatDAO.GetInstance().AjoutPartenariat(unPartenariat);
        }
    }
}
