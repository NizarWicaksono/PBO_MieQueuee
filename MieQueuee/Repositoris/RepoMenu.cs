using DataBase;
using MieQueuee.Model;
using Npgsql;
using System.Collections.Generic;

namespace MieQueuee.MenuRepositoris
{
    public class MenuItemController
    {
        public List<MenuItem> GetAllMenuItems()
        {
            var list = new List<MenuItem>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM menus ORDER BY id_menu ASC";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MenuItem
                        {
                            id_menu = reader.GetInt32(0),
                            nama_menu = reader.GetString(1),
                            harga = reader.GetInt32(2)
                        });
                    }
                }
            }

            return list;
        }
        public MenuItem GetMenuItemById(int id)
        {
            MenuItem item = null;
            using (var conn = DataBase.DatabaseHelper.GetConnection())
            {
                string query = "SELECT id_menu, nama_menu, harga FROM menus WHERE id_menu = @id";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            item = new MenuItem
                            {
                                id_menu = reader.GetInt32(0),
                                nama_menu = reader.GetString(1),
                                harga = reader.GetInt32(2)
                            };
                        }
                    }
                }
            }
            return item;
        }
        public void UpdateMenuItem(MenuItem item)
        {
            using (var conn = DataBase.DatabaseHelper.GetConnection())
            {
                string query = "UPDATE menus SET nama_menu = @nama_menu, harga = @harga WHERE id_menu = @id_menu";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_menu", item.id_menu);
                    cmd.Parameters.AddWithValue("@nama_menu", item.nama_menu);
                    cmd.Parameters.AddWithValue("@harga", item.harga);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void DeleteMenuItem(int id)
        {
            using (var conn = DataBase.DatabaseHelper.GetConnection())
            {
                string query = "DELETE FROM menus WHERE id_menu = @id_menu";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_menu", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Tambah(MenuItem item)
        {
            using (var conn = DataBase.DatabaseHelper.GetConnection())
            {
                string query = "INSERT INTO menus (nama_menu, harga) VALUES (@nama_menu, @harga)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_menu", item.nama_menu);
                    cmd.Parameters.AddWithValue("@harga", item.harga);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
