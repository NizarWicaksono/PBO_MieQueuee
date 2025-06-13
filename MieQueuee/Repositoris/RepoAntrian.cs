using DataBase;
using MieQueuee.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MieQueuee.Controller
{
    public class TransaksiControllers
    {
        public List<Antrian> GetAntrianDenganStatus(string status)
        {
            var daftar = new List<Antrian>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new NpgsqlCommand("SELECT * FROM antrian WHERE status = @status", conn);
                cmd.Parameters.AddWithValue("@status", status);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        daftar.Add(new Antrian
                        {
                            id_antrian = reader.GetInt32(reader.GetOrdinal("id_antrian")),
                            user_id = reader.IsDBNull(reader.GetOrdinal("user_id")) ? 0 : reader.GetInt32(reader.GetOrdinal("user_id")), // Aman dari null
                            nama_pelanggan = reader.IsDBNull(reader.GetOrdinal("nama_pelanggan")) ? "" : reader.GetString(reader.GetOrdinal("nama_pelanggan")),
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

        public static void UpdateStatusAntrianGoToFinish(int idAntrian, string statusBaru)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                var cmd = new NpgsqlCommand("UPDATE antrian SET status = @status WHERE id_antrian = @id", conn);
                cmd.Parameters.AddWithValue("@status", statusBaru);
                cmd.Parameters.AddWithValue("@id", idAntrian);

                if (cmd.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Antrian tidak ditemukan atau gagal diupdate.");
                }
            }
        }

        public int SimpanTransaksiDanAntrian(Transaksi transaksi, List<Antrian> daftarAntrian)
        {
            int idTransaksi;

            using (var conn = DatabaseHelper.GetConnection())
            {
                var tran = conn.BeginTransaction();

                try
                {
                    var cmdTrans = new NpgsqlCommand("INSERT INTO transaksi (total) VALUES (@total) RETURNING id_transaksi", conn, tran);
                    cmdTrans.Parameters.AddWithValue("@total", transaksi.total);
                    idTransaksi = Convert.ToInt32(cmdTrans.ExecuteScalar());

                    foreach (var item in daftarAntrian)
                    {
                        var cmdAntrian = new NpgsqlCommand(@"
                            INSERT INTO antrian (user_id, nama_pelanggan, nama_menu, harga, jumlah, subtotal, status)
                            VALUES (@user_id, @nama_pelanggan, @nama_menu, @harga, @jumlah, @subtotal, 'Sedang dimasak')", conn, tran);

                        cmdAntrian.Parameters.AddWithValue("@user_id", item.user_id);
                        cmdAntrian.Parameters.AddWithValue("@nama_pelanggan", item.nama_pelanggan);
                        cmdAntrian.Parameters.AddWithValue("@nama_menu", item.nama_menu);
                        cmdAntrian.Parameters.AddWithValue("@harga", item.harga);
                        cmdAntrian.Parameters.AddWithValue("@jumlah", item.jumlah);
                        cmdAntrian.Parameters.AddWithValue("@subtotal", item.subtotal);

                        cmdAntrian.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }

            return idTransaksi;
        }
    }
}
