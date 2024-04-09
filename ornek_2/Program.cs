using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi);

            Console.ReadLine();
        }
    }
}
