using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieQueuee.Model
{
    public class Detail_Transaksi
    {
        public int Id { get; set; }
        public int TransactionId { get; set; }
        public int MenuItemId { get; set; }
        public int Jumlah { get; set; }
        public decimal Subtotal { get; set; }
    }
}
