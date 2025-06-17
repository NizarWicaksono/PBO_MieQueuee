using DataBase;
using MieQueuee.Controller;
using MieQueuee.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MieQueuee.View
{
    public partial class FormAntrian : Form
    {
        private TransaksiController transaksiController;

        public FormAntrian()
        {
            InitializeComponent();
            transaksiController = new TransaksiController();
            LoadAntrian();
        }

        private void LoadAntrian()
        {
            dataGridViewAntrian.Rows.Clear();
            var antrianList = transaksiController.GetAntrianDenganStatus("Sedang dimasak");

            foreach (var antrian in antrianList)
            {
                dataGridViewAntrian.Rows.Add(
                    antrian.id_antrian,
                    antrian.nama_pelanggan,
                    antrian.nama_menu,
                    antrian.harga,
                    antrian.jumlah,
                    antrian.subtotal,
                    antrian.status
                );
            }
        }

        private void buttonSelesai_Click(object sender, EventArgs e)
        {
            if (dataGridViewAntrian.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data antrian terlebih dahulu.");
                return;
            }

            var row = dataGridViewAntrian.SelectedRows[0];
            int idAntrian = Convert.ToInt32(row.Cells[0].Value);

            try
            {
                transaksiController.UpdateStatusAntrian(idAntrian, "Selesai");
                MessageBox.Show("Status antrian diperbarui menjadi 'Selesai'");
                LoadAntrian();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memperbarui status: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void dataGridViewAntrian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
