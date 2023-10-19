using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace D03
{
    internal class D03cirkel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is de straal?:");
           string ingevoerdeStraal = Console.ReadLine();

            Double straal = double.Parse(ingevoerdeStraal);


            double omtrek = (Math.PI * Math.PI) * straal;

            double oppervlakte = Math.PI * (straal * straal);

            Console.WriteLine($"De omtrek is {omtrek} en de oppervlakte is {oppervlakte}.");


        }
    }
}
