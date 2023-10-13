using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02
{
    internal class D02quotient
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is het deeltal?");
            string ingevoerdeDeeltal = Console.ReadLine();
            double deeltal = double.Parse(ingevoerdeDeeltal);

            Console.WriteLine("Wat is de deler?");
            string ingevoerdeDeler = Console.ReadLine();
            double deler = double.Parse(ingevoerdeDeler);

            if (deler != 0)
            {
                double quotient = deeltal / deler;
                Console.WriteLine("Het quotient is " + quotient);
            }
            else
            {
                Console.WriteLine("Je kan niet door 0 delen");
            }
        }
    }
}
