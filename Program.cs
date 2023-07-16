using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS5082
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Jumlah tiket: ");
            int jumlahOrang;
            while (!int.TryParse(Console.ReadLine(), out jumlahOrang) || jumlahOrang <= 0)
            {
                Console.WriteLine("Jumlah tiket harus berupa bilangan bulat positif. Silakan coba lagi.");
                Console.Write("Jumlah tiket: ");
            }

            List<Pengguna> penggunaList = new List<Pengguna>();
            for (int i = 0; i < jumlahOrang; i++)
            {
                Pengguna pengguna = new Pengguna();
                Console.WriteLine($"Data untuk Orang ke-{i + 1}:");
                Console.Write("Nama: ");
                pengguna.Nama = Console.ReadLine();
                Console.Write("NIK: ");
                pengguna.NIK = Console.ReadLine();
                Console.Write("Nomor Telepon: ");
                pengguna.NomorTelepon = Console.ReadLine();
                Console.Write("Nomor Kartu Vaksin: ");
                pengguna.NomorKartuVaksin = Console.ReadLine();
                Console.Write("Alamat: ");
                pengguna.Alamat = Console.ReadLine();

                // Cek jika ada data yang kosong
                if (string.IsNullOrWhiteSpace(pengguna.Nama) || string.IsNullOrWhiteSpace(pengguna.NIK) || string.IsNullOrWhiteSpace(pengguna.NomorTelepon)
                    || string.IsNullOrWhiteSpace(pengguna.NomorKartuVaksin) || string.IsNullOrWhiteSpace(pengguna.Alamat))
                {
                    Console.WriteLine("Data yang dimasukkan tidak lengkap. Pemesanan tiket tidak dapat diproses untuk orang ini.");
                    continue; // Lewatkan pengguna ini dan lanjut ke pengguna berikutnya
                }

                penggunaList.Add(pengguna);
            }

            Pemesanan pemesanan = new Pemesanan();
            Console.Write("Pilih tipe tiket (1 = Biasa, 2 = VIP): ");
            string tipeTiketInput = Console.ReadLine();
            string tipeTiket = "Biasa";
            if (tipeTiketInput == "2")
            {
                tipeTiket = "VIP";
            }

            pemesanan.ProsesPemesanan(penggunaList, tipeTiket);
        }
    }
}
