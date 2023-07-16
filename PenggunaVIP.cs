using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS5082
{
    // Inheritance
    public class PenggunaVIP : Pengguna
    {
        public override void PesanTiket()
        {
            Console.WriteLine("Silakan masukkan informasi pemesanan tiket VIP:");
            Console.Write("Tujuan: ");
            string tujuan = Console.ReadLine();
            Console.Write("Tanggal: ");
            string tanggal = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Detail Pemesanan VIP:");
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"NIK: {NIK}");
            Console.WriteLine($"Nomor Telepon: {NomorTelepon}");
            Console.WriteLine($"Nomor Kartu Vaksin: {NomorKartuVaksin}");
            Console.WriteLine($"Alamat: {Alamat}");
            Console.WriteLine($"Tujuan: {tujuan}");
            Console.WriteLine($"Tanggal(dd/mm/yyyy): {tanggal}");

            Console.WriteLine("Pemesanan tiket VIP berhasil diproses.");
            Console.WriteLine("----------------------------------");
        }
    }
}
