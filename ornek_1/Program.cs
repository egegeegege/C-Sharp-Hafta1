using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan adını isteyeceğim kullanıcı adını girdikten sonra
            // [ad] hoşgeldiniz uyarısı verilecek.
            Console.WriteLine("Lütfen adınızı giriniz");
            string ad = Console.ReadLine();

            Console.WriteLine("{0} hoşgeldiniz", ad);

            Console.ReadLine();
        }
    }
}
