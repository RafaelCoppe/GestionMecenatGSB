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
