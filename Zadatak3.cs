using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit3Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaX x = new KlasaX();
            for(int i = 0; i < 100; i++)
            {
                x.Arr[i] = i + 1;
            }
            Console.WriteLine(x.Arr[50]);
            Console.ReadKey();
            
        }
    }
    class KlasaX
    {
        int[] arr = new int[100];

        public int[] Arr { get => arr; set => arr = value; }
    }
}
