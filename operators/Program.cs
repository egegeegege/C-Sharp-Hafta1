using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Operatörler 
            - Atama Operatörleri 
              = (eşittir) => sağdaki değeri sola atar.
              += => arttırma operatörü
              -= => azaltma operatörü
            - Comprasion Operators (Karşılaştırma operatörleri)
            ** karşılaştırma işlemleri sonucu bize true ya da false bir değer döner.
            * == => eşit mi ? eşitse true eşit değilse false döner.
            * != => eşit değil mi ? eşit değilse true eşitse false döner.
            * > => büyüktür 
            * < => küçüktür. 
            * <= => küçük eşittir. 
            * >= => büyük eşittir. 
            - Logical Operators (Mantıksal operatörler) Bağlaç
            * && => and (ve)
            * || => or (veya)              

             */

            string ad = "tahsin";
            string name;
            name = ad;
            Console.WriteLine(name);
            int sayi1 = 10;
            Console.WriteLine(sayi1+=2);  // sayi += 2 => sayi = sayi + 2;
            int sayi2 = 10;
            Console.WriteLine(sayi2 -= 2);  // sayi -= 2 => sayi = sayi - 2;

            int sayi3 = 4;
            int sayi4 = 5;
            bool sonuc = sayi3 == sayi4;
            bool sonuc2 = sayi3 != sayi4;   
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);

            string isim = "ali";
            string nick = "ali";
            bool sonucum = isim == nick;  
            
            Console.WriteLine(sonucum);

            bool s = 16 / 2 == 4 + 4;
            Console.WriteLine(s);

            int number1 = 10;
            int number2 = 15;
            Console.WriteLine(number1 < number2); // True
            Console.WriteLine(number1 > number2); // False
            Console.WriteLine(number1 >= number2); // False
            Console.WriteLine(number1 <= number2); // True

            int n1 = 10;
            // AND &&
            //bool mantiksal = n1 > 5 && n1 < 12;  // True and True => True
            //bool mantiksal = n1 > 5 && n1 < 9;  // True and False => False
            //bool mantiksal = n1 < 5 && n1 < 12;  // False and True => False
            //bool mantiksal = n1 < 5 && n1 < 9;  // False and False => False
            // OR ||
            //bool mantiksal = n1 < 5 || n1 < 12; // False or True => True 
            //bool mantiksal = n1 > 5 || n1 > 12; // True or False => True 
            //bool mantiksal = n1 > 5 || n1 < 12; // True or True => True 
            // bool mantiksal = n1 < 5 || n1 > 12; // False or False => False             
            Console.ReadLine();

        }
    }
}
