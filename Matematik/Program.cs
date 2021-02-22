using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem toplama = new DortIslem();
            toplama.Topla(5,6);

            toplama.Topla(6,9);

            DortIslem cikarma = new DortIslem();
            cikarma.Cikar(8,6);
            cikarma.Cikar(4,12);
        }
    }
}
