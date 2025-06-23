using DataBase;
using MieQueuee.Model;
using Npgsql;
using System;
using System.Data.SqlClient;

namespace MieQueuee.Controller
{
    public class LoginController : Connection
    {
        public Users Login(string username, string password)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_user, username FROM users WHERE username = @u AND password = @p", conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Users
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id_user")),
                            Username = reader.GetString(reader.GetOrdinal("username"))
                        };
                    }
                }
            }

            return null;
        }

    }
}