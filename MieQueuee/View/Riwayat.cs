using MieQueuee.Controller;
using MieQueuee.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MieQueuee.View
{
    public partial class FormRiwayatTransaksi : Form
    {
        private TransaksiController transaksiController;

        public FormRiwayatTransaksi()
        {
            InitializeComponent();
            transaksiController = new TransaksiController();
            LoadRiwayatTransaksi();
        }

        private void LoadRiwayatTransaksi()
        {
            if (dataGridViewTransaksi.Columns.Count == 0)
            {
                dataGridViewTransaksi.Columns.Add("id_transaksi", "ID Transaksi");
                dataGridViewTransaksi.Columns.Add("tanggal", "Tanggal");
                dataGridViewTransaksi.Columns.Add("total", "Total");
                dataGridViewTransaksi.Columns.Add("nama_pelanggan", "Nama Pelanggan");
            }

            var transaksiList = transaksiController.GetAllTransaksi();
            dataGridViewTransaksi.Rows.Clear();

            foreach (var transaksi in transaksiList)
            {
                dataGridViewTransaksi.Rows.Add(
                    transaksi.Id,
                    transaksi.tanggal_transaksi.ToShortDateString(),
                    transaksi.total,
                    transaksi.nama_pelanggan
                );
            }
        }

        private void dataGridViewTransaksi_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTransaksi.SelectedRows.Count > 0)
            {
                int idTransaksi = Convert.ToInt32(dataGridViewTransaksi.SelectedRows[0].Cells[0].Value);
                LoadDetailAntrian(idTransaksi);
            }
        }

        private void LoadDetailAntrian(int idTransaksi)
        {
            dataGridViewDetail.Rows.Clear();

            var detailList = transaksiController.GetDetailTransaksiById(idTransaksi);


            if (dataGridViewDetail.Columns.Count == 0)
            {
                dataGridViewDetail.Columns.Add("nama_menu", "Nama Menu");
                dataGridViewDetail.Columns.Add("harga", "Harga");
                dataGridViewDetail.Columns.Add("jumlah", "Jumlah");
                dataGridViewDetail.Columns.Add("subtotal", "Subtotal");
            }

            foreach (var item in detailList)
            {
                dataGridViewDetail.Rows.Add(
                    item.nama_menu,
                    item.harga,
                    item.jumlah,
                    item.subtotal
                );
            }
        }


        private void buttonKembali_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void dataGridViewTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}