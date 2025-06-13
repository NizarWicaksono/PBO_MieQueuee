namespace MieQueuee.Model
{
    public class Antrian
    {
        public int id_antrian { get; set; }
        public int user_id { get; set; }
        public string nama_pelanggan { get; set; }
        public string nama_menu { get; set; }
        public int harga { get; set; }
        public int jumlah { get; set; }
        public int subtotal { get; set; }
        public string status { get; set; } 
    }
}
