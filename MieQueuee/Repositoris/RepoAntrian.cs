using DataBase;
using MieQueuee.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MieQueuee.Controller
{
    public class AntrianController : Connection
    {
        public List<Detail_Transaksi> GetAntrianDenganStatus(string status)
        {
            var daftar = new List<Detail_Transaksi>();

            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"SELECT dt.id_detail, dt.nama_pelanggan, m.nama_menu, dt.harga, dt.jumlah, dt.subtotal, dt.status FROM detail_transaksi dt
                JOIN menus m ON dt.id_menu = m.id_menu
                WHERE status = @status", conn);
                cmd.Parameters.AddWithValue("@status", status);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        daftar.Add(new Detail_Transaksi
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id_detail")),
                            nama_pelanggan = reader.GetString(reader.GetOrdinal("nama_pelanggan")),
                            nama_menu = reader.GetString(reader.GetOrdinal("nama_menu")),
                            harga = reader.GetInt32(reader.GetOrdinal("harga")),
                            jumlah = reader.GetInt32(reader.GetOrdinal("jumlah")),
                            subtotal = reader.GetInt32(reader.GetOrdinal("subtotal")),
                            status = reader.GetString(reader.GetOrdinal("status"))
                        });
                    }
                }
            }

            return daftar;
        }

        public void UpdateStatusAntrianGoToFinish(int idAntrian, string statusBaru)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand("UPDATE detail_transaksi SET status = @status WHERE id_detail = @id", conn);
                cmd.Parameters.AddWithValue("@status", statusBaru);
                cmd.Parameters.AddWithValue("@id", idAntrian);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Antrian tidak ditemukan atau gagal diupdate.");
                }
            }
        }
    }
}