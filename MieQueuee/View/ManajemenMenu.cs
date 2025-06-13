
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MieQueuee.Controller;
using MieQueuee.Model;

namespace MieQueuee.View
{
    public partial class ManajemenMenu : Form
    {
        public ManajemenMenu()
        {
            InitializeComponent();
        }

        private void ManajemenMenu_Load(object sender, EventArgs e)
        {
            TampilkanMenu();
        }

        private void TampilkanMenu()
        {
            MenuRepositoris.MenuItemController controller = new MenuRepositoris.MenuItemController();
            var dataMenu = controller.GetAllMenuItems();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("id_menu", "ID");
            dataGridView1.Columns.Add("nama_menu", "Nama Menu");
            dataGridView1.Columns.Add("Harga", "Harga");

            DataGridViewButtonColumn updateButton = new DataGridViewButtonColumn();
            updateButton.Name = "Update";
            updateButton.Text = "Update";
            updateButton.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Hapus";
            deleteButton.Text = "Hapus";
            deleteButton.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(updateButton);
            dataGridView1.Columns.Add(deleteButton);

            foreach (var item in dataMenu)
            {
                dataGridView1.Rows.Add(item.id_menu, item.nama_menu, item.harga);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_menu"].Value);

                if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
                {
                    var updateForm = new FormUpdateMenu(id);
                    updateForm.FormClosed += (s, args) => TampilkanMenu();
                    updateForm.ShowDialog();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Hapus")
                {
                    var confirm = MessageBox.Show("Yakin ingin menghapus menu ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        var controller = new MenuRepositoris.MenuItemController();
                        controller.DeleteMenuItem(id);
                        TampilkanMenu();
                    }
                }
            }
        }


        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahMenu form = new FormTambahMenu();
            form.ShowDialog();
            TampilkanMenu();
        }



        private void labelJudul_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TampilanMenu tampilanMenu = new TampilanMenu();
            this.Hide();
            tampilanMenu.ShowDialog();
        }
    }
}