using GestionMecenatBO;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBLL
{
    public class ActionMeneeManager
    {
        public static ActionMeneeManager uneInstance;

        public static ActionMeneeManager GetInstance() //Création d'une instance du Manager
        {
            if (uneInstance == null)
            {
                uneInstance = new ActionMeneeManager();
            }
            return uneInstance;
        }

        private ActionMeneeManager()
        {
        }

        /*public int AjoutActionMenee(string libelleAction)
        {
            ActionMenee uneActionMenee = new ActionMenee(libelleAction);
            return ActionMeneeDAO.GetInstance().AjoutActionMenee(uneActionMenee);
        }*/

        public List<ActionMenee> GetLesActionsMenees() //Appel de la méthode GetLesActionMenees de la DAO
        {
            return ActionMeneeDAO.GetInstance().GetLesActionsMenees();
        }

        public ActionMenee GetUneActionMenee(int idPartenariat)
        {
            return ActionMeneeDAO.GetInstance().GetUneActionMenee(idPartenariat);
        }
    }
}
