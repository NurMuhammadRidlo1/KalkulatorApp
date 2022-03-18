// See https://aka.ms/new-console-template for more information
using System;
namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("Pilih Menu Kalkulator: \n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");

            Console.Write("Masukan Menu Pilihan : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

        }
    }
}
