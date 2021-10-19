using GestionMecenatBO;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBLL
{
    public class MissionManager
    {
        private static MissionManager uneInstance;


        public static MissionManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new MissionManager();
            }
            return uneInstance;
        }

        private MissionManager()
        {

        }

        public List<Mission> GetlesMissions()
        {
            return MissionDAO.GetInstance().GetlesMissions();
        }
    }
}
