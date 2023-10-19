using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class D04toelage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is het jaarinkomen?");
            double jaarInkomen = double.Parse(Console.ReadLine());


            Console.WriteLine("Aantal kinderen?");
            int aantalKinderen = int.Parse(Console.ReadLine());

            double toelage = jaarInkomen * 1.03;

            if (jaarInkomen > 20000 || aantalKinderen <= 3)
            { 
              toelage = 0;
            }

            Console.WriteLine($"De toelage is {toelage}");


        }
    }
}
