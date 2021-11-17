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
    public class AssociationDAO
    {
        private static AssociationDAO uneInstance;

        public static AssociationDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AssociationDAO();
            }
            return uneInstance;
        }

        private AssociationDAO()
        {

        }
        public List<Association> GetAssociations()
        {
            int id;

            string NomAssociation;
            string NomResponsable;

            int idMission;
            string libelleMission;


            int idPays;
            string libellePays;
            
            Association uneAssociation;
            Mission laMission;
            Pays lePays;

            List<Association> lesAssociations = new List<Association>();
            SqlCommand commande = Commande.GetObjCommande();

            commande.CommandText = "GetLesAssociations";
            SqlDataReader monLecteur;
            monLecteur = commande.ExecuteReader();

            while (monLecteur.Read())
            {
                id = (int)monLecteur["idAssociation"];
                //le nom peut être null donc on doit remplacer la valeur null par une chaine vide
                if (monLecteur["nomAssociation"] == DBNull.Value)
                {
                    NomAssociation = default(string);
                }
                else
                {
                    NomAssociation = monLecteur["NomAssociation"].ToString();
                }

                if (monLecteur["nomResponsable"] == DBNull.Value)
                {
                    NomResponsable = default(string);
                }
                else
                {
                    NomResponsable = monLecteur["nomResponsable"].ToString();
                }

                idMission = (int)monLecteur["idMission"];
                libelleMission = monLecteur["libelleMission"].ToString();
                laMission = new Mission(idMission, libelleMission);

                idPays = (int)monLecteur["idPays"];
                libellePays = monLecteur["libellePays"].ToString();
                lePays = new Pays(idPays, libellePays);

                uneAssociation = new Association(id, NomAssociation, NomResponsable, laMission, lePays);
                lesAssociations.Add(uneAssociation);
            }
            monLecteur.Close();
            commande.Connection.Close();
            return lesAssociations;
        }

        public int AjoutAssociation(Association uneAssociation)
        {
            SqlCommand commande = Commande.GetObjCommande();

            commande.CommandText = "AjoutAssociation";

            commande.Parameters.Add("parNomAssoc", System.Data.SqlDbType.VarChar);
            commande.Parameters["parNomAssoc"].Value = uneAssociation.NomAssociation;

            commande.Parameters.Add("parNomResp", System.Data.SqlDbType.VarChar);
            commande.Parameters["parNomResp"].Value = uneAssociation.NomResponsbale;

            commande.Parameters.Add("idMission", System.Data.SqlDbType.Int);
            commande.Parameters["idMission"].Value = uneAssociation.LaMission.Id;

            commande.Parameters.Add("idPays", System.Data.SqlDbType.Int);
            commande.Parameters["idPays"].Value = uneAssociation.LePays.Id;

            int nb = commande.ExecuteNonQuery();
            commande.Connection.Close();
            return nb;
        }

        public int ModifAssociation(Association uneAssociation)
        {
            SqlCommand commande = Commande.GetObjCommande();

            commande.CommandText = "modifAssociation";

            commande.Parameters.Add("parNomAssoc", System.Data.SqlDbType.VarChar);
            commande.Parameters["parNomAssoc"].Value = uneAssociation.NomAssociation;

            commande.Parameters.Add("parNomResp", System.Data.SqlDbType.VarChar);
            commande.Parameters["parNomResp"].Value = uneAssociation.NomResponsbale;

            commande.Parameters.Add("idMission", System.Data.SqlDbType.Int);
            commande.Parameters["idMission"].Value = uneAssociation.LaMission.Id;

            commande.Parameters.Add("idPays", System.Data.SqlDbType.Int);
            commande.Parameters["idPays"].Value = uneAssociation.LePays.Id;

            int nb = commande.ExecuteNonQuery();
            commande.Connection.Close();
            return nb;
        }

        //public Association RecupererAssociation(int id)
        //{
        //    string nomAssociation;
        //    string nomResponsable;
        //    Mission laMission;
        //    Pays lePays;

        //    SqlCommand commande = Commande.GetObjCommande();
        //    commande.Parameters.Clear();
        //    commande.CommandText = "SELECT id, nomAssoc, nom Resp, id_payss, id_mission FROM association WHERE id = @id"; 

        //    commande.Parameters.Add("Id", System.Data.SqlDbType.Int);
        //    commande.Parameters["Id"].Value = id;

        //}
    }
}
