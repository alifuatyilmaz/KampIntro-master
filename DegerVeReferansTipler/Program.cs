using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,bool,float,double = değer tipler
            //array,class,interface = referans tipler
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayi 1 30 değerini alır
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; // sayilar1 dizisi sayilar2 dizisinin referans gösterdiği değeri alır.
            sayilar2[0] = 999;
            //sayilar1[0] 999



        }
    }
}
