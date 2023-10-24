using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D07
{
    internal class D07cirkel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is de straal?:");
            string ingevoerdeStraal = Console.ReadLine();

            Double straal = double.Parse(ingevoerdeStraal);


            double omtrek = (Math.PI * Math.PI) * straal;

            double oppervlakte = Math.PI * (straal * straal);

            Console.WriteLine($"De omtrek is {omtrek, 0:f3} en de oppervlakte is {oppervlakte, 0:f3}.");
        }
    }
}
