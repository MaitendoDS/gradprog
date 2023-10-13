using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class D02gemiddelde
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een kommagetal:");
           string ingevoerdeGetal1 = Console.ReadLine();

            Console.WriteLine("Geef nog een kommagetal:");
            string ingevoerdeGetal2 = Console.ReadLine();

            Console.WriteLine("Geef nog een kommagetal:");
            string ingevoerdeGetal3 = Console.ReadLine();

            double getal1 = Double.Parse(ingevoerdeGetal1);
            double getal2 = Double.Parse(ingevoerdeGetal2);
            double getal3 = Double.Parse(ingevoerdeGetal3);

            double gemiddelde = (getal1 + getal2 + getal3) / 3;

            Console.WriteLine("Het gemiddelde is " + gemiddelde);
        }
    }
}
