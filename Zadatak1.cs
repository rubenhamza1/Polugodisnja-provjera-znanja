using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitZnanja
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Unesi 3 dvoznamenkasta broja: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if(a > b & a > c)
                Console.WriteLine("Najveci broj: " + a);
            if(b > a & b > c)
                Console.WriteLine("Najveci broj: " + b);
            if(c > a & c > b)
                Console.WriteLine("Najveci broj: " + c);

            Console.ReadKey();
        }
    }
}
