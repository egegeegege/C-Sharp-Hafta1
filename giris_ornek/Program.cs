using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giris_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tekli yorum satırı => Kodu gizlemek yada koda açıklamalar yazmak için kullanılır.
            /* 
             Çoklu yorum satırı 

            Kısayol Ctrl + K + C  ||  Yorumu açma Ctrl + K + Ö
             */

            // Ekrana Yazı Yazdırma
            Console.WriteLine("Adınız nedir ?"); // Satıra yazdır.
            Console.Write("C#");
            Console.Write("Dersleri");
            // Ekranda yazıyı tutma 
            Console.ReadLine(); // Satırı oku
            Console.ReadKey();


        }
    }
}
