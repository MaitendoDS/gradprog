using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class D02totalebedrag
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoeveel muntstukken van 2 euro heb je?");
           string muntstukkenVan2Euro = Console.ReadLine();
            int muntenVan2 = int.Parse(muntstukkenVan2Euro);

            Console.WriteLine("Hoeveel muntstukken van 1 euro heb je?");
            string muntstukkenVan1Euro = Console.ReadLine();
            int muntenVan1 = int.Parse(muntstukkenVan1Euro);

            int totaleBedrag = muntenVan2 * 2 + muntenVan1;

            Console.WriteLine("Het totale bedrag is " + totaleBedrag + " Euro.");



        }
    }
}
