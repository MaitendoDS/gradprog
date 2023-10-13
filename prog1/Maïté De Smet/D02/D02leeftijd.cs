using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class D02leeftijd
    {
        static void Main(string[] args)

        { Console.WriteLine("Geef je naam:");
            string ingevoerdeNaam = Console.ReadLine();

            Console.WriteLine("Geef je leeftijd:");
            string ingevoerdeLeeftijd = Console.ReadLine();

            Console.WriteLine("Goeiedag " + ingevoerdeNaam + ", je bent dus " + ingevoerdeLeeftijd + " jaar oud!");

        }
    }
}
