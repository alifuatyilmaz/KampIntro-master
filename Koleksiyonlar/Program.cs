using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil","Veli" }; //Sınırı belli dizilerde sonradan fazla eleman ekleyemezsin.
            Console.WriteLine(isimler2[0]);                                                     //List ise sonradan eleman eklemesine izin verir.
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            isimler2.Add("Ali"); //Listeye Add fonksiyonu ile eleman ekleyebiliriz.
            Console.WriteLine(isimler2[5]);
            isimler2.Add("Ahmet");
            Console.WriteLine(isimler2[6]);
        }
    }
}
