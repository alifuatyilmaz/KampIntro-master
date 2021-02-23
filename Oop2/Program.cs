using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            GercekMusteri musteri3 = new GercekMusteri();
            musteri3.Id = 2;
            musteri3.MusteriNo = "33333";
            musteri3.Adi = "Ali";
            musteri3.Soyadi = "Veli";
            musteri3.TcNo = "1111111111111";

            //Musteri musteri4 = new TuzelMusteri(); //Böyle tanımlamada sadece Musteri classının değişkenlerini kullanır.
            TuzelMusteri musteri4 = new TuzelMusteri();
            musteri4.Id = 4;
            musteri4.MusteriNo = "66666";
            musteri4.SirketAdi = "Yıldız";
            musteri4.VergiNo = "444444444444";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1); // musteri hangi classı alıyorsa MusteriManager classında o değerlere göre metodu çağırıyor.
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
