using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    internal class D03getalraden
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int willekeurigGetal = rnd.Next(0,10);

            Console.WriteLine("De computer denkt aan een getal tussen 0 en 10.");
            Console.WriteLine("Welk getal denkt u dat het is?:");

            string ingevoerdeGetal = Console.ReadLine();
            int getal = int.Parse(ingevoerdeGetal);

            if (getal == willekeurigGetal) { 
                Console.WriteLine($"Proficiat u heeft goed geraden, het getal was {willekeurigGetal}.");
            } else { Console.WriteLine($"Helaas, het getal was {willekeurigGetal}."); }
            
        }
    }
}
