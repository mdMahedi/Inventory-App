using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InventoryApp.Connection
{
    public class ConnectionClass
    {
        public static SqlConnection InventoryDBConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InventoryDBConn"].ConnectionString;
            SqlConnection connection=new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}