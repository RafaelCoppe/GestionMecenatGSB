using GestionMecenatBO;
using GestionMecenatDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatBLL
{
    public class AssociationManager
    {
        private static AssociationManager uneInstance;


        public static AssociationManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AssociationManager();
            }
            return uneInstance;
        }

        private AssociationManager()
        {

        }

        public List<Association> GetAssociations()
        {
            return AssociationDAO.GetInstance().GetAssociations();
        }

        public int CreerAssociation(string nomAssociation, string nomResponsable, Pays lePays, Mission laMission)
        {
            Association uneAssociation = new Association(nomAssociation, nomResponsable, laMission, lePays);
            return AssociationDAO.GetInstance().AjoutAssociation(uneAssociation);
        }

        public int ModifAssociation(string nomAssociation, string nomResponsable, int idMission, int idPays)
        {
            Pays unPays = new Pays(idPays);
            Mission uneMission = new Mission(idMission);
            Association uneAssociation = new Association(nomAssociation, nomResponsable, uneMission, unPays);
            return AssociationDAO.GetInstance().ModifAssociation(uneAssociation);
        }

        public Association RecupererAssociation(int id)
        {
            return AssociationDAO.GetInstance().RecupererAssociation(id);
        }
    }
}