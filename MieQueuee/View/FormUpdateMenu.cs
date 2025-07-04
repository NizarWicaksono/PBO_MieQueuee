﻿using System;
using System.Windows.Forms;
using MieQueuee.Controller;
using MieQueuee.Model;

namespace MieQueuee.View
{
    public partial class FormUpdateMenu : Form
    {
        private int idMenu;

        public FormUpdateMenu(int id)
        {
            InitializeComponent();
            idMenu = id;
            LoadMenuData();
        }

        private void LoadMenuData()
        {
            IMenu<MenuItem> controller = new MenuItemController();
            var item = controller.GetMenuItemById(idMenu);

            if (item != null)
            {
                textBoxNama.Text = item.nama_menu;
                textBoxHarga.Text = item.harga.ToString();
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            IMenu<MenuItem> controller = new MenuItemController();
            var updatedItem = new MenuItem
            {
                id_menu = idMenu,
                nama_menu = textBoxNama.Text,
                harga = decimal.Parse(textBoxHarga.Text)
            };

            controller.UpdateMenuItem(updatedItem);
            MessageBox.Show("Menu berhasil diperbarui.");
            this.Close();
        }

        private void FormUpdateMenu_Load(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }
    }
}