using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService
    {
        void Log(); // Farklı farklı loglama işlemleri yapmak için tanımlıyoruz. Sms, veritabanına ve bir dosyaya loglamak için kullanacağız.
    }
}
