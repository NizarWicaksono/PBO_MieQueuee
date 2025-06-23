using Npgsql;
using System.Configuration;
using System.Data.SqlClient;

namespace DataBase
{
    public abstract class Connection
    {
        protected string connString = "Host=localhost;Username=postgres;Password=Sateayamb5;Database=MieQueue;";

        protected NpgsqlConnection GetConnection()

        {
            return new NpgsqlConnection(connString);
        }
    }
}