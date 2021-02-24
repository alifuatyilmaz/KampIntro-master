using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); //  IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  normalde böyle tanımlanmıştı.
                                                                           //  Ama interface'lerde implement oldukları classın referans numarasını tutabilir.
            IKrediManager tasitKrediManager = new TasitKrediManager();     //  TasitKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();     //  KonutKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager banaOzelKrediManager = new BanaOzelKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(), new FileLoggerService() }; // Burada loglama seçeneklerini bir listeye ekliyoruz. Bu çeşitleri BasvuruYap methoduna kredi tipi ile gönderiyoruz.
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, banaOzelKrediManager }; // Kredi tiplerini bir listede tanımlıyoruz. Aslında burada kullanıcı bunları seçecek.

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers); // Burada BasvuruManager.cs'deki BasvuruYap metoduna ilk olarak bir kredi değişkeni göndermeliyiz. Sonra loglama çeşitlerini gönderiyoruz.

            

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
