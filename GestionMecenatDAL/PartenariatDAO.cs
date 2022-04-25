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
            decimal budgetPrevisionnel;
            decimal coutPartenariat;
            //int idAction;
            //int idAssociation;
            ActionMenee uneActionMenee;
            Association uneAssociationLiee;

            // on crée la collection lesärtenariats de type List<Partenariat> qui va contenir les
            // caractéristiques des partenariats enregistrés dans la base de donnes
            List<Partenariat> lesPartenariats = new List<Partenariat>();

            // on exécute la requête et on récupère dans un DataReader les enregistrements
            maCommand.CommandText = "GetLesPartenariats";
            SqlDataReader monLecteur = maCommand.ExecuteReader();

            // pour chaque enregistrement du DataReader on crée un objet instance de
            // Partenariat que l'on ajoute dans la collection lesPartenariats

            while (monLecteur.Read())
            {
                IDPartenariat = (int)monLecteur["id"];
                budgetPrevisionnel = decimal.Parse(monLecteur["budgetPrevisionnel"].ToString());
                coutPartenariat = decimal.Parse(monLecteur["coutPartenariat"].ToString());
                uneActionMenee = new ActionMenee((int)monLecteur["id_actionMenee"], monLecteur["nomAction"].ToString());
                uneAssociationLiee = new Association((int)monLecteur["id_association"], monLecteur["nomAsso"].ToString(), monLecteur["nomResponsable"].ToString(), new Mission((int)monLecteur["id_mission"]), new Pays((int)monLecteur["idPays"], monLecteur["nomPays"].ToString()));

                lesPartenariats.Add(new Partenariat(IDPartenariat, budgetPrevisionnel, coutPartenariat, uneActionMenee, uneAssociationLiee));
            }
          
            // on ferme le DataReader

            monLecteur.Close();

            // on ferme la connexion

            maCommand.Connection.Close();

            // on retourne la collection
            return lesPartenariats;
        }

        public int AjoutPartenariat(Partenariat unPartenariat) //Méthode qui ajoute un partenariat dans la table
        {
            int nbEnregAjout;

            // on crée l'objet qui va contenir le nom de la procédure stockée utilisée
            SqlCommand maCommand = Commande.GetObjCommande();

            //Création des paramètres
            maCommand.Parameters.Add("budgetPrevisionnel", System.Data.SqlDbType.Decimal);
            maCommand.Parameters.Add("coutPartenariat", System.Data.SqlDbType.Decimal);
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

        public int ModifPartenariat(Partenariat lePartenariatModifie)
        {
            int nbEnregModif;

            // on crée l'objet qui va contenir le nom de la procédure stockée utilisée

            SqlCommand maCommand = Commande.GetObjCommande();

            //Création des paramètres
            maCommand.Parameters.Add("idPartenariatChoisi", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("budgetPrevu", System.Data.SqlDbType.Decimal);
            maCommand.Parameters.Add("coutReel", System.Data.SqlDbType.Decimal);
            maCommand.Parameters.Add("idActionMenee", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("idAssoLiee", System.Data.SqlDbType.Int);

            maCommand.Parameters["idPartenariatChoisi"].Value = lePartenariatModifie.Id;
            maCommand.Parameters["budgetPrevu"].Value = lePartenariatModifie.BudgetPrevisionnel;
            maCommand.Parameters["coutReel"].Value = lePartenariatModifie.CoutPartenariat;
            maCommand.Parameters["idActionMenee"].Value = lePartenariatModifie.ActionMennee.Id;
            maCommand.Parameters["idAssoLiee"].Value = lePartenariatModifie.AssociationLiee.Id;

            //Stocker le nom de la procédure stockée dans la commande
            maCommand.CommandText = "ModifPartenariat";

            // on exécute la requête
            nbEnregModif = maCommand.ExecuteNonQuery();

            //On ferme la connexion
            maCommand.Connection.Close();

            // on retourne le nombre d'enregistrements ajoutés
            return nbEnregModif;
        }

    }
}
