using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    internal class D14artikel
    {
        static void Main(string[] args)
        {
            Artikel artikel = new Artikel();
            Console.WriteLine(artikel.BTW);

            artikel.BTW = 8;
            Console.WriteLine(artikel.BTW);

            artikel.Prijs = 69.420;
            Console.WriteLine(artikel.Prijs);

            Console.WriteLine(artikel.PrijsIncl());
        }
    }
}
