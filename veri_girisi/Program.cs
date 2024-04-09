using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace veri_girisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı giriniz");
            Console.ReadLine();
            Thread.Sleep(2000);
            Console.WriteLine("Soyadınızı giriniz");
            Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz");
            Console.ReadLine();
        }
    }
}
