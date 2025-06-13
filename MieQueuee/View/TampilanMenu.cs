using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MieQueuee.Model;

namespace MieQueuee.View
{
    public partial class TampilanMenu : Form
    {
        private MieQueuee.MenuRepositoris.MenuItemController controller = new MieQueuee.MenuRepositoris.MenuItemController();
        public TampilanMenu()
        {
            InitializeComponent();
            LoadDataMenu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataMenu()
        {
            List<MenuItem> daftarMenu = controller.GetAllMenuItems();
            dataGridView1.DataSource = daftarMenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManajemenMenu manajemenMenu = new ManajemenMenu();
            this.Hide();
            manajemenMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
