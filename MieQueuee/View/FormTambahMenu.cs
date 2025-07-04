﻿using MieQueuee.Controller;
using MieQueuee.Model;
using System;
using System.Windows.Forms;

namespace MieQueuee.View
{
    public partial class FormTambahMenu : Form
    {
        private IMenu<MenuItem> menuController = new MenuItemController();

        public FormTambahMenu()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string namaMenu = textBoxNamaMenu.Text;
            string hargaMenu = textBoxHarga.Text;

            if (string.IsNullOrWhiteSpace(namaMenu) || string.IsNullOrWhiteSpace(hargaMenu))
            {
                MessageBox.Show("Nama menu dan harga harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(hargaMenu, out int harga))
            {
                MessageBox.Show("Harga harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var MenuItem = new MenuItem
            {
                nama_menu = namaMenu,
                harga = harga
            };
            menuController.AddMenuItem(MenuItem);

            MessageBox.Show($"Menu '{namaMenu}' berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxNamaMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormTambahMenu_Load(object sender, EventArgs e)
        {

        }
    }
}