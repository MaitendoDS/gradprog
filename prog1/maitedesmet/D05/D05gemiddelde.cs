using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05gemiddelde
    {
        static void Main(string[] args)
        {
            int som = 0;
            int getal = 0;
            int aantal = 0;
            int gemiddelde = 0;
            do
            {
                Console.Write("Geef een getal (-1 om te stoppen) :");
                string invoer = Console.ReadLine();
                getal = int.Parse(invoer);
                if (getal != -1)
                {
                    som += getal;
                    aantal++;
                }
            } while (getal != -1);

            gemiddelde = som / aantal;

            Console.WriteLine($"Het gemiddelde is {gemiddelde}");
        }
    }
}
