using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS5082
{
    // Encapsulation
    public class Pengguna
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public string NomorTelepon { get; set; }
        public string NomorKartuVaksin { get; set; }
        public string Alamat { get; set; }

        public virtual void PesanTiket()
        {
            Console.WriteLine("Silakan masukkan informasi pemesanan tiket:");
            Console.Write("Tujuan: ");
            string tujuan = Console.ReadLine();
            Console.Write("Tanggal: ");
            string tanggal = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Detail Pemesanan:");
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"NIK: {NIK}");
            Console.WriteLine($"Nomor Telepon: {NomorTelepon}");
            Console.WriteLine($"Nomor Kartu Vaksin: {NomorKartuVaksin}");
            Console.WriteLine($"Alamat: {Alamat}");
            Console.WriteLine($"Tujuan: {tujuan}");
            Console.WriteLine($"Tangga(dd/mm/yyyy): {tanggal}");

            Console.WriteLine("Pemesanan tiket berhasil diproses.");
            Console.WriteLine("----------------------------------");
        }
    }
}
