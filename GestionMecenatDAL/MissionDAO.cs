using GestionMecenatBO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatDAL
{
    public class MissionDAO
    {
        private static MissionDAO uneInstance;
        public static MissionDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new MissionDAO();
            }
            return uneInstance;
        }

        private MissionDAO()
        {

        }

        public List<Mission> GetlesMissions()
        {
            Mission laMission;

            List<Mission> lesMissions = new List<Mission>();
            laMission = new Mission(0, "Veuillez sélectionner une mission");

            lesMissions.Add(laMission);
            SqlCommand commande = Commande.GetObjCommande();

            //commande.CommandText = "Select id, libelle FROM Mission;";
            commande.CommandText = "GetLesMissions";


            SqlDataReader monLecteur;
            monLecteur = commande.ExecuteReader();

            int idMis;
            string libMis;

            while (monLecteur.Read())
            {

                idMis = (int)monLecteur["id"];

                if (monLecteur["libelle"] == DBNull.Value)
                {
                    libMis = default(string);
                }
                else
                {
                    libMis = (string)monLecteur["libelle"];
                }

                laMission = new Mission(idMis, libMis);
                lesMissions.Add(laMission);
            }
            monLecteur.Close();
            commande.Connection.Close();
            return lesMissions;
        }

    }
}
