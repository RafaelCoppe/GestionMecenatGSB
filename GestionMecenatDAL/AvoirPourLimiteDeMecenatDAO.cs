
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

        public static AvoirPourLimiteDeMecenatDAO GetInstance() //Création d'une instance de la DAO
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
            maCommand.Parameters.Add("sommeMaximum", System.Data.SqlDbType.Decimal);

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
            decimal plafondMecenat;
            Pays lePays;
            Annee uneAnnee;

            // on crée la collection lesLimitesDeMecenat de type List<AvoirPourLimiteDeMecenat> qui va contenir les
            // caractéristiques des limites de mecenat a enregistrés dans la base de donnes
            List<AvoirPourLimiteDeMecenat> lesLimitesDeMecenat;
            lesLimitesDeMecenat = new List<AvoirPourLimiteDeMecenat>();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "GetLesLimitesDeMecenat";

            SqlDataReader monLecteur = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // AvoirPourLimiteDeMecenat que l'on ajoute dans la collection leslimitesDeMecenat
            while (monLecteur.Read())
            {
                plafondMecenat = (decimal)monLecteur["plafondMecenat"];
                lePays = new Pays(((int)monLecteur["idPays"]), (monLecteur["libelle"].ToString()));
                uneAnnee = new Annee(((int)monLecteur["idAnnee"]));

                lesLimitesDeMecenat.Add(new AvoirPourLimiteDeMecenat(plafondMecenat, lePays, uneAnnee));
            }

            // on ferme le DataReader
            monLecteur.Close();

            // on ferme la connexion
            maCommand.Connection.Close();

            // on retourne la collection
            return lesLimitesDeMecenat;
        }

        public int ModifLimiteMecenat(AvoirPourLimiteDeMecenat uneLimiteMecenatModifie, AvoirPourLimiteDeMecenat uneLimiteMecenatAncien)
        {
            int nbEnregModif;

            // on crée l'objet qui va contenir le nom de la procédure stockée utilisée
            SqlCommand maCommand = Commande.GetObjCommande();

            //Création des paramètres
            maCommand.Parameters.Add("idAnneeChoisi", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("idPaysChoisi", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("sommeMaximum", System.Data.SqlDbType.Decimal);
            maCommand.Parameters.Add("idNewAnnee", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("idNewPays", System.Data.SqlDbType.Int);

            maCommand.Parameters["idAnneeChoisi"].Value = uneLimiteMecenatAncien.idAnnee;
            maCommand.Parameters["idPaysChoisi"].Value = uneLimiteMecenatAncien.idPays;
            maCommand.Parameters["sommeMaximum"].Value = uneLimiteMecenatModifie.PlafondMecenat;
            maCommand.Parameters["idNewAnnee"].Value = uneLimiteMecenatModifie.UneAnnee.NumAnnee;
            maCommand.Parameters["idNewPays"].Value = uneLimiteMecenatModifie.LePays.Id;

            //Stocker le nom de la procédure stockée dans la commande
            maCommand.CommandText = "ModifLimiteMecenat";

            // on exécute la requête
            nbEnregModif = maCommand.ExecuteNonQuery();

            //On ferme la connexion
            maCommand.Connection.Close();

            // on retourne le nombre d'enregistrements ajoutés
            return nbEnregModif;
        }

         public int SupprLimiteMecenat(AvoirPourLimiteDeMecenat uneLimiteMecenatModifie)
        {
            int nbEnregModif;

            // on crée l'objet qui va contenir le nom de la procédure stockée utilisée

            SqlCommand maCommand = Commande.GetObjCommande();

            //Création des paramètres
            maCommand.Parameters.Add("idAnneeChoisi", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("idPaysChoisi", System.Data.SqlDbType.Int);

            maCommand.Parameters["idAnneeChoisi"].Value = uneLimiteMecenatModifie.idAnnee;
            maCommand.Parameters["idPaysChoisi"].Value = uneLimiteMecenatModifie.idPays;

            //Stocker le nom de la procédure stockée dans la commande
            maCommand.CommandText = "SupprLimiteMecenat";

            // on exécute la requête
            nbEnregModif = maCommand.ExecuteNonQuery();

            //On ferme la connexion
            maCommand.Connection.Close();

            // on retourne le nombre d'enregistrements ajoutés
            return nbEnregModif;
        }
    }
}