using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class D01totalebedrag
    {
        static void Main(string[] args)
        {
            int biljettenVan10Euro = 7;
            int biljettenVan5Euro = 6;
            int muntstukkenVan2Euro = 5;
            int muntstukkenVan1Euro = 4;
            int muntstukkenVan50Cent = 3;

            double totaalbedrag = biljettenVan10Euro * 10 +
                biljettenVan5Euro * 5 +
                muntstukkenVan2Euro * 2 +
                muntstukkenVan1Euro +
                muntstukkenVan50Cent * 0.5;
            Console.WriteLine(totaalbedrag);
        }
    }
}
