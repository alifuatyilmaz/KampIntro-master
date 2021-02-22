using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T kullanıcı o an hangi tipte veri isterse o tipi baz alır.
    {
        T[] items;  //string[] items ' dizi oluşturmak yerine T tipinde items dizisi oluşturuyoruz.
        //constructor
        public MyList() // ctor yazıp tab tab yap.Bu constructor.
        {
            items = new T[0]; //T tipinde oluşturduğumuz items dizisini oluşturuyoruz. items 0 elemanlı bir dizi olmuş oluyor.(T[] items = new T[0])
        }
        public void Add(T item) // Burada T string tipini alır
        {
            T[] tempArray = items;
            items = new T[items.Length+1]; // 1 elemanlı yeni bir dizi oluşturuyoruz(new).Örneğin ilk oluşturduğumuz dizinin referans nosu 101 olsun.Burada oluşturduğumuz dizinin referans nosu 102 olur.
            //101 -> [] items dizisi 101 referanslı
            //102 -> [1] items dizisi artık 102'yi referans alır.
            for (int i = 0; i < tempArray.Length; i++) //Burada 101 referanslı dizideki elemanlarımızı 102 referanslı dizimize atıyoruz. Elemanlar silinmemiş oluyor.
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // items dizisinin son elemanını ekliyoruz.

        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }


    }
}
