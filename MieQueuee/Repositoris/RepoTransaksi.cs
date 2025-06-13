using DataBase;
using MieQueuee.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MieQueuee.Controller
{
    public class TransaksiController
    {
        // Mengambil semua antrian berdasarkan status
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
                            user_id = reader.GetInt32(reader.GetOrdinal("user_id")),
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

        public void UpdateStatusAntrian(int idAntrian, string statusBaru)
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

        public int SimpanTransaksi(Transaksi transaksi, List<Antrian> daftarAntrian)
        {
            int idTransaksi;

            using (var conn = DatabaseHelper.GetConnection())
            {
                var tran = conn.BeginTransaction();

                try
                {
           
                    var cmdTrans = new NpgsqlCommand(@"
                    INSERT INTO transaksi (total, tanggal_transaksi, id_user, nama_pelanggan) 
                    VALUES (@total, CURRENT_DATE, @user_id, @nama_pelanggan)
                    RETURNING id_transaksi", conn, tran);

                    cmdTrans.Parameters.AddWithValue("@total", transaksi.total);
                    cmdTrans.Parameters.AddWithValue("@user_id", transaksi.user_id);
                    cmdTrans.Parameters.AddWithValue("@nama_pelanggan", transaksi.nama_pelanggan);
                    idTransaksi = Convert.ToInt32(cmdTrans.ExecuteScalar());

                    foreach (var item in daftarAntrian)
                    {
               
                        var cmdDetail = new NpgsqlCommand(@"
                    INSERT INTO detail_transaksi (id_transaksi, nama_menu, harga, jumlah, subtotal)
                    VALUES (@id_transaksi, @nama_menu, @harga, @jumlah, @subtotal)", conn, tran);

                        cmdDetail.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                        cmdDetail.Parameters.AddWithValue("@nama_menu", item.nama_menu);
                        cmdDetail.Parameters.AddWithValue("@harga", item.harga);
                        cmdDetail.Parameters.AddWithValue("@jumlah", item.jumlah);
                        cmdDetail.Parameters.AddWithValue("@subtotal", item.subtotal);
                        cmdDetail.ExecuteNonQuery();

           
                        var cmdAntrian = new NpgsqlCommand(@"
                    INSERT INTO antrian (id_transaksi, user_id, nama_pelanggan, nama_menu, harga, jumlah, subtotal, status)
                    VALUES (@id_transaksi, @user_id, @nama_pelanggan, @nama_menu, @harga, @jumlah, @subtotal, 'Sedang dimasak')", conn, tran);

                        cmdAntrian.Parameters.AddWithValue("@id_transaksi", idTransaksi);
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

        public List<Transaksi> GetAllTransaksi()
        {
            var list = new List<Transaksi>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM transaksi ORDER BY id_transaksi DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaksi
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id_transaksi")),
                            user_id = reader.IsDBNull(reader.GetOrdinal("id_user"))
                                ? 0
                                : reader.GetInt32(reader.GetOrdinal("id_user")),
                            tanggal_transaksi = reader.IsDBNull(reader.GetOrdinal("tanggal_transaksi"))
                                ? DateTime.MinValue
                                : reader.GetDateTime(reader.GetOrdinal("tanggal_transaksi")),
                            total = reader.IsDBNull(reader.GetOrdinal("total"))
                                ? 0
                                : Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("total"))),
                            nama_pelanggan = reader.IsDBNull(reader.GetOrdinal("nama_pelanggan"))
                                ? ""
                                : reader.GetString(reader.GetOrdinal("nama_pelanggan"))
                        });
                    }
                }
            }

            return list;
        }


        public List<Antrian> GetDetailTransaksiById(int idTransaksi)
        {
            var list = new List<Antrian>();

            using (var conn = DatabaseHelper.GetConnection())
            {

                var cmd = new NpgsqlCommand("SELECT nama_menu, harga, jumlah, subtotal FROM detail_transaksi WHERE id_transaksi = @id", conn);
                cmd.Parameters.AddWithValue("@id", idTransaksi);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Antrian
                        {
                            nama_menu = reader.GetString(reader.GetOrdinal("nama_menu")),
                            harga = reader.GetInt32(reader.GetOrdinal("harga")),
                            jumlah = reader.GetInt32(reader.GetOrdinal("jumlah")),
                            subtotal = reader.GetInt32(reader.GetOrdinal("subtotal"))
                        });
                    }
                }
            }

            return list;
        }


    }
}
