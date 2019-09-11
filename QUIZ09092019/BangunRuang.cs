using System;

namespace QUIZ09092019
{
    class TKJ
        {
     public void volumebalok()
        {
            int panjang, lebar, tinggi;
            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("-----------------------");

            Console.Write("Masukan nilai panjang : ");
            panjang = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Masukan nilai lebar : ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukan nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            int volume = panjang * lebar * tinggi;


            Console.WriteLine("Volume Balok adalah : "+volume);
            Console.WriteLine("   ");
        }
     public void volumekubus()
     {
          int sisi;

                  
            Console.WriteLine("Menghitung Volume Kubus");
            Console.WriteLine("-----------------------");

            Console.Write("Masukan nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            int volume = sisi * sisi * sisi;


            Console.WriteLine("Volume Kubus adalah : "+volume);

              }
    }
    }

