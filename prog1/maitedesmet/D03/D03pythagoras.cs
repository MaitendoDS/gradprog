using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace D03
{
    internal class D03pythagoras
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is de basis van de driehoek?:");
            string ingevoerdeBasis = Console.ReadLine();
            Console.WriteLine("Wat is de hoogte van de driehoek?:");
            string ingevoerdeHoogte = Console.ReadLine();

            double basis = double.Parse(ingevoerdeBasis);
            double hoogte = double.Parse(ingevoerdeHoogte);

            double schuineZijdeKwadraat = Math.Pow(basis, 2) + Math.Pow(hoogte, 2);
            double schuineZijde = Math.Sqrt(schuineZijdeKwadraat);

            Console.WriteLine($"De lengte van de schuine zijde is {schuineZijde}");
       

        }
    }
}
