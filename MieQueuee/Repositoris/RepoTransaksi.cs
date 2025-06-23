using DataBase;
using MieQueuee.Model;
using Npgsql;
using System;
using System.Collections.Generic;

namespace MieQueuee.Controller
{
    public class TransaksiController : Connection
    {
        public int SimpanTransaksi(Transaksi transaksi, List<Detail_Transaksi> daftarAntrian)
        {
            int idTransaksi;

            using (var conn = GetConnection())
            {
                conn.Open();
                var tran = conn.BeginTransaction();

                try
                {

                    var cmdTrans = new NpgsqlCommand(@"
                    INSERT INTO transaksi (total, tanggal_transaksi, nama_pelanggan) 
                    VALUES (@total, CURRENT_DATE, @nama_pelanggan)
                    RETURNING id_transaksi", conn, tran);

                    cmdTrans.Parameters.AddWithValue("@total", transaksi.total);
                    cmdTrans.Parameters.AddWithValue("@nama_pelanggan", transaksi.nama_pelanggan);
                    idTransaksi = Convert.ToInt32(cmdTrans.ExecuteScalar());

                    // Simpan detail transaksi untuk setiap item di daftarAntrian
                    foreach (var item in daftarAntrian)
                    {
                        // Ambil id_menu berdasarkan nama_menu
                        var cmdIdMenu = new NpgsqlCommand("SELECT id_menu FROM menus WHERE nama_menu = @nama_menu", conn, tran);
                        cmdIdMenu.Parameters.AddWithValue("@nama_menu", item.nama_menu);
                        int idMenu = Convert.ToInt32(cmdIdMenu.ExecuteScalar());

                        var cmdAntrian = new NpgsqlCommand(@"
                    INSERT INTO detail_transaksi (id_transaksi, nama_pelanggan, id_menu, harga, jumlah, subtotal, status)
                    VALUES (@id_transaksi, @nama_pelanggan, @id_menu, @harga, @jumlah, @subtotal, 'Sedang dimasak')", conn, tran);

                        cmdAntrian.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                        cmdAntrian.Parameters.AddWithValue("@nama_pelanggan", item.nama_pelanggan);
                        cmdAntrian.Parameters.AddWithValue("@id_menu", idMenu);
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

            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM transaksi ORDER BY id_transaksi DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaksi
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id_transaksi")),
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


        public List<Detail_Transaksi> GetDetailTransaksiById(int idTransaksi)
        {
            var list = new List<Detail_Transaksi>();

            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"
                    SELECT m.nama_menu, dt.harga, dt.jumlah, dt.subtotal FROM detail_transaksi dt
                    JOIN menus m ON dt.id_menu = m.id_menu
                    WHERE id_transaksi = @id
                    ", conn);
                cmd.Parameters.AddWithValue("@id", idTransaksi);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Detail_Transaksi
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