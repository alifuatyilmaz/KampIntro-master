using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) // Program.cs'den basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers); ile kredi türünü alıyor.
        {   //Burada List<ILoggerService> loggerServices ile hangi loglamayı yapacağını seçtiriyoruz.

            //Başvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); // Bu 2 satır sadece KonutKrediManager için çalışır.Bu yüzden interface ile referansı yukarda BaşvuruYap'a
            //konutKrediManager.Hesapla();                                   //  parametre olarak gönder.(IKrediManager krediManager)
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices) // Burada log çeşitlerini dolaşıyor.
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // Bir liste ile kredi tiplerini Program.cs'de tutuyoruz ve buraya gönderiyoruz. List<IKrediManager> tipinde krediler değişkeni tanımlıyoruz.
        {
            foreach (var kredi in krediler) // Listedeki her bir krediyi dolaşıyor ve her kredi için ayrı ayrı hesaplama yapıyor. IKrediManager.cs 'deki Hesapla() metodunu kullanıyor.
            {
                kredi.Hesapla();
            }
        }
    }
}
