using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager //IKrediManager'ın yanında bir ampul çıkıyor.Orda implement interface çıkıyor.Tıklayınca aşağıdakiler oluşuyor.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
