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

        public List<AvoirPourLimiteDeMecenat> GetLimiteDeMecenat()
        {
            SqlCommand maCommand = Commande.GetObjCommande();
            int plafondMecenat;
            Pays lePays;
            Annee uneAnnee;

            List<AvoirPourLimiteDeMecenat> lesLimitesDeMecenat;
            lesLimitesDeMecenat = new List<AvoirPourLimiteDeMecenat>();

            maCommand.CommandText = "GetLesLimitesDeMecenat";

            SqlDataReader monLecteur = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Client que l'on ajoute dans la collection lesClients

            while (monLecteur.Read())
            {
                plafondMecenat = (int)monLecteur["plafondMecenat"];
                lePays = new Pays(((int)monLecteur["idPays"]), (monLecteur["libelle"].ToString()));
                uneAnnee = new Annee(((int)monLecteur["idAnnee"]));

                lesLimitesDeMecenat.Add(new AvoirPourLimiteDeMecenat(plafondMecenat, lePays, uneAnnee ));
            }

            monLecteur.Close();

            maCommand.Connection.Close();

            return lesLimitesDeMecenat;
        }
    }
}
