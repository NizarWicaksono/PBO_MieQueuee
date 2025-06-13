using MieQueuee.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MieQueuee.View
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TampilanMenu tampilanmenu = new TampilanMenu();
            this.Hide();
            tampilanmenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTransaksi transaksi = new FormTransaksi();
            this.Hide();
            transaksi.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAntrian antrian = new FormAntrian();
            this.Hide();
            antrian.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRiwayatTransaksi riwayat = new FormRiwayatTransaksi();
            this.Hide();
            riwayat.ShowDialog();
        }
    }
}
