using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degisken_tipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Değişken tipleri
            // - Primitive variables (İlkel değişkenler)
            string ad; // metinsel değişken
            char tekil = 'A'; // Tek karakterlik değer alır. Tek tırnak ile tanımlanır.
            int sayi1 = 2147483647; // +,- değer alabilen tam sayıları tanımlar. 2 üzeri 32
            long sayi2 = 9223372036854775807; // +,- değer alabilen tam sayıları tanımlar. 2 üzeri 64
            short sayi3 = 32767; // +,- değer alabilen tam sayıları tanımlar. 2 üzeri 16
            double sayi4 = 10.25; // küsüratlı sayı değeri alır.
            float sayi5 = 3.14f;  // küsüratlı sayı değeri alır.
            decimal sayi6 = 10;  // ondalıklı sayı değeri alır.
            bool dogruYanlis = false; // true yada false değer alan değişken tipi
            var data = 10; // dinamik bir yapı oluşturur ve içine hangi tipi atarsam kendine o tipi belirler.
            const double PI = 3.14; // constant => sabit olarak bir değer tanımlanır ve tekrar atama yapılamaz.
            const int KdvOrani = 18;

            Console.WriteLine(PI);


            Console.ReadLine();

        }
    }
}
