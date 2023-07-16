using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS5082
{
    public class Pemesanan
    {
        public void ProsesPemesanan(List<Pengguna> penggunaList, string tipeTiket)
        {
            foreach (var pengguna in penggunaList)
            {
                Console.WriteLine($"Silakan masukkan informasi pemesanan tiket {tipeTiket} untuk {pengguna.Nama}:");
                Console.Write("Tujuan: ");
                string tujuan = Console.ReadLine();
                Console.Write("Tanggal(dd/mm/yyyy): ");
                string tanggal = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Detail Pemesanan:");
                Console.WriteLine($"Nama: {pengguna.Nama}");
                Console.WriteLine($"NIK: {pengguna.NIK}");
                Console.WriteLine($"Nomor Telepon: {pengguna.NomorTelepon}");
                Console.WriteLine($"Nomor Kartu Vaksin: {pengguna.NomorKartuVaksin}");
                Console.WriteLine($"Alamat: {pengguna.Alamat}");
                Console.WriteLine($"Tipe Tiket: {tipeTiket}");
                Console.WriteLine($"Tujuan: {tujuan}");
                Console.WriteLine($"Tanggal(dd/mm/yyyy): {tanggal}");

                Console.WriteLine($"Pemesanan tiket {tipeTiket} untuk {pengguna.Nama} berhasil diproses.");
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
