using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        void Hesapla(); //Bu metodu farklı farklı durumlarda kullanacağız.Hem IhtiyacKrediManager hem EsnafKrediManager hem KonutKrediManager'da farklı değerlerde kullanacağız.
                        //Bu yüzden IKrediManager classını interface olarak kullanacağız. Eğer class olarak kalsaydı Hesapla()'nın bir değer alması ve if ile kontrolü yapılması gerekir.
        void BiseyYap();
    }
}
