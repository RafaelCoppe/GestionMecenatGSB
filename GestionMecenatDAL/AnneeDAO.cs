using GestionMecenatBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatDAL
{
    public class AnneeDAO
    {
        private static AnneeDAO uneInstance;

        // cette méthode crée un objet de la classe AnneeDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static AnneeDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AnneeDAO();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private AnneeDAO()
        {
        }


        public List<Annee> GetLesAnneesDisponiblePourUnPays(int idPays)
        {
            SqlCommand maCommand = Commande.GetObjCommande();
            // attributs + objet
            int lAnnee;

            List<Annee> lesAnnees = new List<Annee>();

            maCommand.CommandText = "getLesAnneesLimiteMecenat";

            maCommand.Parameters.Add("idPays", System.Data.SqlDbType.Int);
            maCommand.Parameters["idPays"].Value = idPays;

            SqlDataReader monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                lAnnee = (int)monLecteur["numAnnee"];

                lesAnnees.Add(new Annee(lAnnee));
            }

            // on ferme le DataReader

            monLecteur.Close();

            // on ferme la connexion

            maCommand.Connection.Close();

            // on retourne la collection
            return lesAnnees;
        }
    }
}
