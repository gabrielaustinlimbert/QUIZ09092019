using System;

namespace QUIZ09092019
{
    class tkj3
    {
        public void luaspersegi()
        {
            int sisi;
            Console.WriteLine("Menghitung Luas Persegi");
            Console.WriteLine("-----------------------");

            Console.Write("Masukan nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine()); 

            int luas = sisi * sisi;

            Console.WriteLine("Luas Persegi adalah : "+luas);
            Console.WriteLine("     ");
        }
            public void luassegitiga()
            {
                int alas, tinggi;

                Console.WriteLine("Menghitung Luas Segitiga");
                Console.WriteLine("------------------------");

                Console.Write("Masukan Nilai Alas : ");
                alas = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukan Nilai Tinggi : ");
                tinggi = Convert.ToInt32(Console.ReadLine());

                int luas1;

                luas1 = alas * tinggi / 2;

                Console.WriteLine("Luas Segitiga Adalah : "+luas1);
                Console.WriteLine("     ");
            }


            public void luaslingkaran()
            {
                int r;

                Console.WriteLine("Menghitung Luas Lingkaran");
                Console.WriteLine("-------------------------");

                Console.Write("Masukan Nilai Jari-jari : ");
                r = Convert.ToInt32(Console.ReadLine());

                int luas2;

                luas2 = r * r * 22/7;

                Console.WriteLine("Luas Lingkaran adalah : "+luas2);
                Console.WriteLine("     ");
            }
        }
    }

