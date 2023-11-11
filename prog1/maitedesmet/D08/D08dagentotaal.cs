using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08dagentotaal
    {
        static void Main(string[] args)
        {
            int[] dagen = new int[12];

            dagen[0] = 31;
            dagen[1] = 28;
            dagen[2] = 31;
            dagen[3] = 30;
            dagen[4] = 31;
            dagen[5] = 30;
            dagen[6] = 31;
            dagen[7] = 31;
            dagen[8] = 30;
            dagen[9] = 31;
            dagen[10] = 30;
            dagen[11] = 31;

            int totaal = 0;

            for (int i = 0; i < 12; i++)
            {
             totaal = totaal + dagen[i];
            }

            Console.WriteLine("Totaal: " + totaal);
        }
    }
}
