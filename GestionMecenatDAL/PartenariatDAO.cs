using GestionMecenatBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatDAL
{
    public class PartenariatDAO
    {
        private static PartenariatDAO uneInstance;

        public static PartenariatDAO GetInstance() //Création d'une instance de la DAO
        {
            if (uneInstance == null)
            {
                uneInstance = new PartenariatDAO();
            }
            return uneInstance;
        }

        private PartenariatDAO()
        {
        }

        public List<Partenariat> GetPartenariats()
        {
            SqlCommand maCommand = Commande.GetObjCommande();
            int IDPartenariat;
            float budgetPrevisionnel;
            float coutPartenariat;
            //int idAction;
            //int idAssociation;
            ActionMenee uneActionMenee;
            Association uneAssociationLiee;

            // on crée la collection lesClients de type List<Client> qui va contenir les
            // caractéristiques des clients enregistrés dans la base de donnes
            List<Partenariat> lesPartenariatsID = new List<Partenariat>();
            List<Partenariat> lesPartenariats = new List<Partenariat>();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "GetLesPartenariats";
            SqlDataReader monLecteur = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Client que l'on ajoute dans la collection lesClients

            while (monLecteur.Read())
            {
                IDPartenariat = (int)monLecteur["id"];
                budgetPrevisionnel = float.Parse(monLecteur["budgetPrevisionnel"].ToString());
                coutPartenariat = float.Parse(monLecteur["coutPartenariat"].ToString());
                uneActionMenee = new ActionMenee((int)monLecteur["id_actionMenee"]);
                uneAssociationLiee = new Association((int)monLecteur["id_association"]);

                lesPartenariatsID.Add(new Partenariat(IDPartenariat, budgetPrevisionnel, coutPartenariat, uneActionMenee, uneAssociationLiee));
            }
            
            // on ferme le DataReader

            monLecteur.Close();

            // on ferme la connexion

            maCommand.Connection.Close();

            //On remplace les ID d'action et d'association par leurs noms
            /*foreach (Partenariat lePartenariat in lesPartenariats)
            {
                uneActionMenee = ActionMeneeDAO.GetInstance().GetUneActionMenee(lePartenariat.ActionMennee.Id);
                uneActionMenee = new ActionMenee(uneActionMenee.Id, uneActionMenee.Libelle);
                uneAssociationLiee = AssociationDAO.GetInstance().GetUneAssociation(lePartenariat.AssociationLiee.Id);
                uneAssociationLiee = new Association(uneAssociationLiee.Id, uneAssociationLiee.NomAssociation, uneAssociationLiee.NomResponsbale, uneAssociationLiee.LaMission, uneAssociationLiee.LePays);
            
                lesPartenariats.Add(new Partenariat(lePartenariat.Id, lePartenariat.BudgetPrevisionnel, lePartenariat.CoutPartenariat, uneActionMenee, uneAssociationLiee));
            }*/

            // on retourne la collection
            return lesPartenariats;
        }

        public int AjoutPartenariat(Partenariat unPartenariat) //Méthode qui ajoute un partenariat dans la table
        {
            int nbEnregAjout;

            // on crée l'objet qui va contenir le nom de la procédure stockée utilisée
            SqlCommand maCommand = Commande.GetObjCommande();

            //Création des paramètres
            maCommand.Parameters.Add("budgetPrevisionnel", System.Data.SqlDbType.Float);
            maCommand.Parameters.Add("coutPartenariat", System.Data.SqlDbType.Float);
            maCommand.Parameters.Add("idAction", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("idAsso", System.Data.SqlDbType.Int);

            maCommand.Parameters["budgetPrevisionnel"].Value = unPartenariat.BudgetPrevisionnel;
            maCommand.Parameters["coutPartenariat"].Value = unPartenariat.CoutPartenariat;
            maCommand.Parameters["idAction"].Value = unPartenariat.ActionMennee.Id;
            maCommand.Parameters["idAsso"].Value = unPartenariat.AssociationLiee.Id;

            //Stocker le nom de la procédure stockée dans la commande
            maCommand.CommandText = "AjoutPartenariat";

            // on exécute la requête
            nbEnregAjout = maCommand.ExecuteNonQuery();

            //On ferme la connexion
            maCommand.Connection.Close();

            // on retourne le nombre d'enregistrements ajoutés
            return nbEnregAjout;
        }

    }
}
