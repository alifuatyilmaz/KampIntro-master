using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //Individual
    class GercekMusteri: Musteri //Musteri classından miras alma
    { 
        public string TcNo { get; set; } // Bir veri üzerinde matematiksel işlem yapmıyorsak string olarak tanımlanabilir.
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
