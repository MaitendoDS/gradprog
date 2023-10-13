using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class D02gelijk
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een geheel getal:");
            string ingevoerdGetal1 = Console.ReadLine();

            int getal1 = int.Parse(ingevoerdGetal1);


            Console.WriteLine("Geef nog een geheel getal:");
            string ingevoerdGetal2 = Console.ReadLine();

            int getal2 = int.Parse(ingevoerdGetal2);

            if (getal1 == getal2)
            {
                Console.WriteLine("Ze zijn gelijk.");

            }
            else
            {

                Console.WriteLine("Ze zijn verschillend.");
            }
        }
    }
}
   

