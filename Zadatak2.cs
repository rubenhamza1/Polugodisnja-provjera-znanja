using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit2Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);
            Console.WriteLine("Stablo 1 je " + stablo1 + "\n");
            Console.WriteLine("Stablo 2 je " + stablo2 + "\n");
            Console.ReadKey();
        }
    }
    class Stablo
    {
        bool otpadajuListovi;
        String vrstaStabla;
        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }
        public void setotpadajuListovi(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }
        public void setvrstaStabla(String vrstaStabla)
        {
            this.vrstaStabla = vrstaStabla;
        }
        public bool getotpadajuListovi()
        {
            return this.otpadajuListovi;
        }
        public String getvrstaStabla()
        {
            return this.vrstaStabla;
        }

        public override string ToString()
        {
            if (otpadajuListovi == false)
                vrstaStabla = "Crnogorično";
            else if (otpadajuListovi == true)
                vrstaStabla = "Bijelogorično";
            return vrstaStabla;
        }
    }
}
