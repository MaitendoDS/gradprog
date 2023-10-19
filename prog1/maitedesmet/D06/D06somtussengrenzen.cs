using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D06
{
    internal class D06somtussengrenzen
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de ondergrens: ");
            int ondergrens = int.Parse(Console.ReadLine());

            Console.Write("Geef de bovengrens: ");
            int bovengrens = int.Parse(Console.ReadLine());

           
            int som = 0;

            for (int i = ondergrens + 1; i < bovengrens; i++) {
                som = som+ i;
            }
                Console.WriteLine(som);

        }
    }
}
