using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    internal class D03kleinermetmathmin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal:");
            string ingevoerdeGetal1 = Console.ReadLine();
            int getal1 = int.Parse(ingevoerdeGetal1);


            Console.WriteLine("Geef een ander getal:");
            string ingevoerdeGetal2 = Console.ReadLine();
            int getal2 = int.Parse(ingevoerdeGetal2);

            int kleinste = Math.Min(getal1, getal2);
            

            Console.WriteLine($"{kleinste} is kleiner.");
        }
    }
}
