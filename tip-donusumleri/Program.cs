using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inplicit Conversion ( Bilinçsiz Dönüşüm )
            Console.WriteLine("*******Inplicit Conversion*******");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);
            
            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Kübra";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);
            Console.ReadLine();
            // Explicit Conversion ( Bilinçli Dönüşüm )

            Console.WriteLine("*******Explicit Conversion*******");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float w=10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            Console.ReadLine();

            // ToString Methodu
            Console.WriteLine("*******ToString Methodu*******");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);
            Console.ReadLine();
        }
    }
}
