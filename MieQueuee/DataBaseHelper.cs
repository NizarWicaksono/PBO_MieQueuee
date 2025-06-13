using Npgsql;
using System.Configuration;
using System.Data.SqlClient;

namespace DataBase
{
    public class DatabaseHelper
    {
        public static NpgsqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            var connection = new NpgsqlConnection(connString);
            connection.Open();
            return connection;
        }
    }
}