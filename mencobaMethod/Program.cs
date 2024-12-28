using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mencobaMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menuUtama();
            Console.ReadLine();
        }
        static void enter()
        {
            Console.WriteLine("tekan enter untuk melanjutkan");
            Console.ReadLine();
        }
        static void menuUtama()
        {
            Console.WriteLine("\t\t PROGRAM KALKULATOR \n");
            Console.WriteLine($"Menu : \n1. Tambah\n2. Kurang\n3. Kali\n4. bagi\n5. Keluar\n".ToUpper());
            do
            {
                Console.Write("masukkan menu yang ingin dipilih >> ");
                int menuPilih = Convert.ToInt32(Console.ReadLine());
                if (menuPilih == 1)
                {
                    tambah();
                    break;
                }
                else if (menuPilih == 2)
                {
                    kurang();
                    break;

                }
                else if (menuPilih == 3)
                {
                    kali();
                    break;

                }
                else if (menuPilih == 4)
                {
                    bagi();
                    break;

                }
                else if (menuPilih == 5)
                {
                    Console.WriteLine("terimakasih telah menggunakan program ini");
                    enter();
                    break;

                }

                else
                {
                    Console.WriteLine("inputan anda tidak valid");
                    enter();
                    continue;
                }
            } while (true);
        }
        static void tambah()
        {
            Console.Write("masukkan angka pertama >> ");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukkan angka kedua >> ");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"hasil dari {angka1} + {angka2} = {angka1 + angka2}");
            enter();
            menuUtama();
        }
        static void kurang()
        {
            Console.Write("masukkan angka pertama >> ");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukkan angka kedua >> ");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"hasil dari {angka1} - {angka2} = {angka1 - angka2}");
            enter();
            menuUtama();
        }

        static void kali()
        {
            Console.Write("masukkan angka pertama >> ");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("masukkan angka kedua >> ");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"hasil dari {angka1} x {angka2} = {angka1 * angka2}");
            enter();
            menuUtama();
        }
        static void bagi()
        {
            Console.Write("masukkan angka pertama >> ");
            Double angka1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan angka kedua >> ");
            Double angka2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"hasil dari {angka1} : {angka2} = {angka1 / angka2}");
            enter();
            menuUtama();
        }
    }
}
