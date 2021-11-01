using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Girin: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Hoşgeldiniz " + name + " " + surname);
            Console.ReadLine();
        }
    }
}
