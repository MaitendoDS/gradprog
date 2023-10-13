using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class D02leeftijdvolgendjaar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je naam:");
            string ingevoerdeNaam = Console.ReadLine();

            Console.WriteLine("Geef je leeftijd:");
            string ingevoerdeLeeftijd = Console.ReadLine();
            int leeftijd = int.Parse(ingevoerdeLeeftijd);

           int leeftijdVolgendJaar = leeftijd + 1;

            Console.WriteLine("Goeiedag " + ingevoerdeNaam + ", volgend jaar ben je al " + leeftijdVolgendJaar + " jaar oud!");
        }
    }
}
