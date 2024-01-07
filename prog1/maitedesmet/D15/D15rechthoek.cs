using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class D15rechthoek
    {

        static void Main()
        {
            Rechthoek rechthoek1 = new Rechthoek();
            rechthoek1.Hoogte = 4.1;
            rechthoek1.Breedte = 8;

            Rechthoek rechthoek2 = new Rechthoek();
            rechthoek2.Hoogte = 5;
            rechthoek2.Breedte = 10.2;

            PrintRechthoek(rechthoek1);
            PrintRechthoek(rechthoek2);
        }
        static void PrintRechthoek(Rechthoek r)
        {
            Console.WriteLine($"Rechthoek met hoogte {r.Hoogte}, breedte {r.Breedte} en oppervlakte {r.Oppervlakte()}.");
        }
    }
}
