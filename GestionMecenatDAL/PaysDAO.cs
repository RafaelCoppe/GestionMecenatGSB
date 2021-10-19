using GestionMecenatBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatDAL
{
    public class PaysDAO
    {
        private static PaysDAO uneInstance;

        // cette méthode crée un objet de la classe AvoirPourLimiteDeMecenatDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static PaysDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PaysDAO();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private PaysDAO()
        {
        }

        public List<Pays> GetLesPays()
        {
            SqlCommand maCommand = Commande.GetObjCommande();
            // attributs + objet
            int leId;
            string leLibelle;

            List<Pays> lesPays = new List<Pays>();
            lesPays.Add(new Pays(0, "Veuillez séléctionner un pays"));

            maCommand.CommandText = "getLesPays";
            SqlDataReader monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                leId = (int)monLecteur["id"];
                leLibelle = monLecteur["libelle"].ToString();

                lesPays.Add(new Pays(leId, leLibelle));
            }

            // on ferme le DataReader

            monLecteur.Close();

            // on ferme la connexion

            maCommand.Connection.Close();

            // on retourne la collection
            return lesPays;
        }
    }
}
