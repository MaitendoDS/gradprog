using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class D15artikel
    {
        static void Main(string[] args)
        {
            Artikelmetprijs artikel = new Artikelmetprijs(69);
            Console.WriteLine(artikel.BTW);

            artikel.BTW = 8;
            Console.WriteLine(artikel.BTW);

            artikel.Prijs = 69.420m;
            Console.WriteLine(artikel.Prijs);

            Console.WriteLine(artikel.PrijsIncl());
        }



    }
}
