using MieQueuee.Controller;
using MieQueuee.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MieQueuee.View
{
    public partial class FormTransaksi : Form
    {
        private List<MenuItem> daftarMenu;
        private List<MenuItem> keranjang;
        private MenuItemController controller;

        public FormTransaksi()
        {
            InitializeComponent();
            controller = new MenuItemController();
            keranjang = new List<MenuItem>();
            LoadMenu();
        }

        private void LoadMenu()
        {
            daftarMenu = controller.GetAllMenuItems();
            comboBoxMenu.Items.Clear();
            foreach (var item in daftarMenu)
            {
                comboBoxMenu.Items.Add(item.nama_menu);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBoxJumlah.Text))
            {
                MessageBox.Show("Pilih menu dan isi jumlah.", "Peringatan");
                return;
            }

            if (!int.TryParse(textBoxJumlah.Text, out int jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus berupa angka positif.");
                return;
            }

            var selectedMenu = daftarMenu[comboBoxMenu.SelectedIndex];
            var hargaTotal = selectedMenu.harga * jumlah;

            dataGridViewKeranjang.Rows.Add(selectedMenu.nama_menu, selectedMenu.harga, jumlah, hargaTotal);
            labelTotal.Text = $"Total: Rp {HitungTotal()}";
        }

        private int HitungTotal()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridViewKeranjang.Rows)
            {
                total += Convert.ToInt32(row.Cells[3].Value);
            }
            return total;
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            if (dataGridViewKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang kosong.");
                return;
            }
            string namaPelanggan = txtNamaPelanggan.Text.Trim();
            if (string.IsNullOrWhiteSpace(namaPelanggan))
            {
                MessageBox.Show("Nama pelanggan tidak boleh kosong!");
                return;
            }

            int total = HitungTotal();

            var transaksi = new Transaksi
            {
                total = total,
                nama_pelanggan = namaPelanggan
            };
            var daftarAntrian = new List<Detail_Transaksi>();

            foreach (DataGridViewRow row in dataGridViewKeranjang.Rows)
            {
                if (row.IsNewRow) continue;

                string namaMenu = row.Cells[0].Value?.ToString() ?? "";
                if (!int.TryParse(row.Cells[1].Value?.ToString(), out int harga)) harga = 0;
                if (!int.TryParse(row.Cells[2].Value?.ToString(), out int jumlah)) jumlah = 0;
                if (!int.TryParse(row.Cells[3].Value?.ToString(), out int subtotal)) subtotal = 0;

                daftarAntrian.Add(new Detail_Transaksi
                {
                    nama_pelanggan = namaPelanggan,
                    nama_menu = namaMenu,
                    harga = harga,
                    jumlah = jumlah,
                    subtotal = subtotal
                });
            }

            try
            {
                var controller = new TransaksiController();
                int idTransaksi = controller.SimpanTransaksi(transaksi, daftarAntrian);

                MessageBox.Show($"Transaksi berhasil!\nID Transaksi: {idTransaksi}\nTotal: Rp {total}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridViewKeranjang.Rows.Clear();
                labelTotal.Text = "Total: Rp 0";
                txtNamaPelanggan.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan transaksi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}