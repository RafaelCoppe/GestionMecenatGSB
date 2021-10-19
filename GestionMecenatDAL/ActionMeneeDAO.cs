using GestionMecenatBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatDAL
{
    public class ActionMeneeDAO
    {
        public static ActionMeneeDAO uneInstance;
        public static ActionMeneeDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ActionMeneeDAO();
            }
            return uneInstance;
        }

        private ActionMeneeDAO()
        {
        }

        public List<ActionMenee> GetLesActionsMenees()
        {
            SqlCommand maCommand = Commande.GetObjCommande();
            int leID;
            string leLibelle;
            // on crée la collection lesClients de type List<Client> qui va contenir les
            // caractéristiques des clients enregistrés dans la base de donnes
            List<ActionMenee> lesActionsMenees = new List<ActionMenee>();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "GetLesActionsMenees";
            SqlDataReader monLecteur = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Client que l'on ajoute dans la collection lesClients

            while (monLecteur.Read())
            {
                leID = (int)monLecteur["id"];
                leLibelle = monLecteur["libelle"].ToString();

                lesActionsMenees.Add(new ActionMenee(leID, leLibelle));
            }

            // on ferme le DataReader

            monLecteur.Close();

            // on ferme la connexion

            maCommand.Connection.Close();

            // on retourne la collection
            return lesActionsMenees;
        }

        public ActionMenee GetUneActionMenee(int idPartenariat)
        {
            SqlCommand maCommandeAction = Commande.GetObjCommande();
            int leID;
            string leLibelle;

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommandeAction.CommandText = "GetUneActionMenee";

            maCommandeAction.Parameters.Add("idPartenariat", System.Data.SqlDbType.Int);
            maCommandeAction.Parameters["idPartenariat"].Value = idPartenariat;

            SqlDataReader monLecteur = maCommandeAction.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Client que l'on ajoute dans la collection lesClients

            monLecteur.Read();
            
            leID = (int)monLecteur["id"];
            leLibelle = monLecteur["libelle"].ToString();

            ActionMenee uneActionMenee = new ActionMenee(leID, leLibelle);

            // on ferme le DataReader

            monLecteur.Close();

            // on ferme la connexion

            maCommandeAction.Connection.Close();

            // on retourne la collection
            return uneActionMenee;
        }

        public int AjoutActionMenee(ActionMenee uneActionMenee)
        {
            int nbEnregAjout;

            // on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée

            SqlCommand maCommand = Commande.GetObjCommande();

            //Création des paramètres
            maCommand.Parameters.Add("libelle");

            maCommand.Parameters["libelle"].Value = uneActionMenee.Libelle;

            //Stocker la requête dans la commande
            maCommand.CommandText = "AjoutActionMenee";

            // on exécute la requête
            nbEnregAjout = maCommand.ExecuteNonQuery();

            //On ferme la connexion
            maCommand.Connection.Close();

            // on retourne le nombre d'enregistrements ajoutés
            return nbEnregAjout;
        }
    }
}
