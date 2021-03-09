using System;
using System.Collections.Generic;

namespace Kalkulator
{
    class Program
    {
        double hitung(double [] angka, int menu)
        {
            double sum = 0.0;
            switch (menu)
            {
                case 1:
                    foreach (int a in angka)
                    {
                        sum = sum + a;
                    }
                    break;
                case 2:
                    sum = angka[0];
                    for (int i = 1; i < angka.Length; i++)
                    {
                        sum -= angka[i];
                    }
                    break;
                case 3:
                    sum = angka[0];
                    for(int i = 1; i < angka.Length; i++)
                    {
                        sum *= angka[i];
                    }
                    break;
                case 4:
                    sum = angka[0];
                    for (int i = 1; i < angka.Length; i++)
                    {
                        sum /= angka[i];
                    }
                    break;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.Title = "Aplikasi Kalkulator Xuzer";
            Console.Clear();

            bool isCorrect = false;
            int menu = 1;
            string men = "1";
            do
            {
                Console.WriteLine("----Menu----");
                Console.WriteLine("1. Penambahan");
                Console.WriteLine("2. Pengurangan");
                Console.WriteLine("3. Perkalian");
                Console.WriteLine("4. Pembagian");
                Console.WriteLine("------------");

                Console.Write("Pilih menu: ");

                men = Console.ReadLine();
                isCorrect = true;
                try
                {
                    menu = int.Parse(men);
                } catch(Exception e)
                {
                    isCorrect = false;
                }
                if(menu > 4 || menu < 1)
                {
                    isCorrect = false;
                    Console.WriteLine("Menu Tidak Tersedia. Masukan Ulang menu");
                }
                
            }while (!isCorrect);

            List<double> angka = new List<double>();
            bool notEmpty = false;

            int indx = 0;
            Console.WriteLine("Kosongkan lalu enter bila ingin memproses angka");
            do
            {
                Console.Write("Masukan angka ke " + (indx + 1) + " : ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    notEmpty = false;
                }
                else
                {
                    int temp = int.Parse(input);
                    angka.Add(temp);
                    notEmpty = true;

                }
                indx++;
            } while (notEmpty);

            Console.WriteLine("Hasil: " + a.hitung(angka.ToArray(), menu));
        }
    }
}
