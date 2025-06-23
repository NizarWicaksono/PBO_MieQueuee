using System;
using System.Collections.Generic;
namespace MieQueuee.Model
{
    public class Detail_Transaksi
    {
        public int Id { get; set; }
        public int transactionId { get; set; }
        public int menuItemId { get; set; }
        public int jumlah { get; set; }
        public decimal subtotal { get; set; }
        public int harga { get; set; }
        public string status { get; set; }
        public string nama_pelanggan { get; set; }
        public string nama_menu { get; set; }
    }
}