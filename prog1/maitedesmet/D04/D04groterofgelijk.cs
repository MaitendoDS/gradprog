using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class D04groterofgelijk
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal:");
            string ingevoerdeGetal1 = Console.ReadLine();
            double getal1 = double.Parse(ingevoerdeGetal1);

            Console.WriteLine("Geef nog een getal:");
            string ingevoerdeGetal2 = Console.ReadLine();
            double getal2 = double.Parse(ingevoerdeGetal2);


            if (getal1 > getal2) { Console.Write("Het eerste getal is groter."); }
            else if (getal1 < getal2) { Console.Write("Het tweede getal is groter."); }

            else { Console.WriteLine("Ze zijn gelijk."); }





        }
    }
}
