using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMecenatDAL
{
    static public class Commande
    {
        static private SqlCommand objCommand;

        static Commande()
        {
            SqlConnection objConnex = new SqlConnection();
            objCommand = new SqlCommand("", objConnex);
            objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["Mécénat"].ConnectionString;
        }

        public static SqlCommand GetObjCommande()
        {
            if (objCommand.Connection.State == System.Data.ConnectionState.Closed)
            {
                objCommand.Connection.Open();
            }
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.Parameters.Clear();
            return objCommand;
        }
        public static void CloseConnexion()
        {
            if (objCommand.Connection != null && objCommand.Connection.State != System.Data.ConnectionState.Closed)
            {
                objCommand.Connection.Close();
            }
        }

    }
}
