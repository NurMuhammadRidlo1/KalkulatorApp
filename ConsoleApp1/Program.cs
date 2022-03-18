// See https://aka.ms/new-console-template for more information
using System;
namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            int hasil = 0;

            Console.WriteLine("Pilih Menu Kalkulator: \n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");

            Console.Write("Masukan Menu Pilihan : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukan angka Pertama : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan angka Kedua   : ");
            int b = Convert.ToInt32(Console.ReadLine());

            if( pilihan == 1 )
            {
                hasil = Penambahan(a, b);
            } else if( pilihan == 2)
            {
                hasil = Pengurangan(a, b);
            } else if( pilihan == 3)
            {
                hasil = Perkalian(a, b);
            } else if(pilihan == 4)
            {
                hasil = Pembagian(a, b);
            } else
            {
                Console.WriteLine("Pilihan yang anda masukan tidak tersedia!");
            }

            Console.Write("\nHasil dari perhitungan adalah : ");
            Console.Write(hasil + "\n");

        }
        static int Penambahan (int a, int b)
        {
            int hasil = a + b;
            return hasil;
        }

        static int Pengurangan (int a, int b)
        {
            int hasil = a - b;
            return hasil;
        }
     
        static int Perkalian (int a, int b)
        {
            int hasil = a * b;
            return hasil;
        }
        static int Pembagian(int a, int b)
        {
            int hasil = a / b;
            return hasil;
        }
    }
}
