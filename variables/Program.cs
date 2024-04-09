using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables (Değişkenler)
            // C# data protected bir dildir. Yani veri korumalı bir dildir.
            // Bir veriyi bir değişkenin içine attığımızda o değişkenin tipini mutlaka belirtmek zorundayız.
            string adSoyad = "Tahsin Canpolat";
            string ad = "Ali";
            string bosluk = " ";
            string soyad = "Demir";
            Console.WriteLine(adSoyad);
            Console.WriteLine(ad + bosluk + soyad);
            Console.WriteLine("{0} {1}", ad, soyad); // string göstermek için 0 dan başlayarak index numarası verilir ve virgülden sonra eklenecek değişken yapıları sırası ile yazılır.
            Console.WriteLine($"Adınız soyadınız: {adSoyad}");
            Console.WriteLine("Adınız soyadınız: {0}",adSoyad);
            string yas = "30";
            Console.WriteLine(yas);
            //string 1ad = "Ahmet";
            string ad1 = "Ahmet";
            string s3lam;
            //string *ad;
            //string #ad;
            //string $ad;
            //string _ad; // alt tire karakteri olur fakat bu karakterinde özel bir anlamı var.
            string sehir = "istanbul";
            //string sehir = "ankara"; // zaten tanımlandığı için hata verir.
            sehir = "ankara"; // değişkene en son hangi değer atanırsa değişkenin son değeri o olur.
            sehir = "kars";
            Console.WriteLine(sehir);

            string model = "BMW";
            string Model = "Mercedes";
            string MODEL = "VW";
            Console.WriteLine(model);

            /* Değişken tanımlama kuralları
             * Değişken isimleri kesinlikle türkçe karakter içermez. (ş,İ,ı,ö,ç,ü,ğ) hatalı durum string yaş
             * Değişken isimleri sayı ile başlayamaz! Fakat sonunda yada arasında sayı olabilir.
             * Değişkenler özel karakterler ile başlayamaz.
             * Değişken isimleri tek bir tane olmalıdır ve o amaca hizmet etmelidir.
             * Değişkenlerde case sensitive (Büyük küçük harf duyarlılığı) vardır.
             * Değişken isimlerinde c# a özgü ifadeler kullanılamaz.
             */

            Console.ReadLine();

        }
    }
}
