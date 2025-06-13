using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieQueuee.Model
{
    public class Transaksi
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public DateTime tanggal_transaksi { get; set; }
        public decimal total { get; set; }
        public string nama_pelanggan { get; set; }  

    }
}
