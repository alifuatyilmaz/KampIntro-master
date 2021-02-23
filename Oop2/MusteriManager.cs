using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //İş sınıfları // business classes 
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            //if (musteri.)
            //{

            //}
            Console.WriteLine(musteri.Id + " " + musteri.MusteriNo);

        }
        public void Ekle(TuzelMusteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.MusteriNo + "  " + musteri.SirketAdi +" " + musteri.VergiNo);
        }
        public void Ekle(GercekMusteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.MusteriNo + "  " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.TcNo);
        }
    }
}
