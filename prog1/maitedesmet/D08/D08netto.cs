using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08netto
    {
        static void Main(string[] args)
        {
            double[] kortingen = { 10, 50, 19.4 };
            double brutoBedrag = 1000;

            double nettoBedrag = brutoBedrag;

                int i = 0;
            foreach (double korting in kortingen)
            {
                nettoBedrag = nettoBedrag - kortingen[i];
                i++;
            }
            

            Console.Write("Netto bedrag: " + nettoBedrag);
        }
    }
}
