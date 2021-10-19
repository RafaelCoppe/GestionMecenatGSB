using GestionMecenatBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatDAL
{
    public class AvoirPourLimiteDeMecenatDAO
    {
        private static AvoirPourLimiteDeMecenatDAO uneInstance;

        // cette méthode crée un objet de la classe AvoirPourLimiteDeMecenatDAO s'il n'existe pas déjà un
        // puis retourne la référence à cet objet
        public static AvoirPourLimiteDeMecenatDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AvoirPourLimiteDeMecenatDAO();
            }
            return uneInstance;
        }

        // le constructeur par défaut est privé : il ne sera donc pas possible de créer un
        // objet à l'extérieur de la classe avec l'instruction new ...
        private AvoirPourLimiteDeMecenatDAO()
        {
        }

        public int AjoutLimiteDeMecenat(AvoirPourLimiteDeMecenat uneLimiteMecenat)
        {
            int nbEnregAjout;

            // on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée

            SqlCommand maCommand = Commande.GetObjCommande();

            //Création des paramètres
            maCommand.Parameters.Add("idAnnee", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("idPays", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("sommeMaximum", System.Data.SqlDbType.Float);

            maCommand.Parameters["idAnnee"].Value = uneLimiteMecenat.UneAnnee.NumAnnee;
            maCommand.Parameters["idPays"].Value = uneLimiteMecenat.LePays.Id;
            maCommand.Parameters["sommeMaximum"].Value = uneLimiteMecenat.PlafondMecenat;


            //Stocker la requête dans la commande
            maCommand.CommandText = "AjoutLimiteMecenat";

            // on exécute la requête
            nbEnregAjout = maCommand.ExecuteNonQuery();

            //On ferme la connexion
            maCommand.Connection.Close();

            // on retourne le nombre d'enregistrements ajoutés
            return nbEnregAjout;
        }

    }
}
