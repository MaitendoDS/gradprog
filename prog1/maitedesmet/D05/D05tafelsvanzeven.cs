using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05tafelsvanzeven
    {
        static void Main(string[] args)
        {
            int getal = 0;
            int maaltafel = 7; 
            

            do { getal = getal + 1;

                int uitkomst = getal * maaltafel;
                Console.WriteLine(getal + "x" + maaltafel + "=" +uitkomst); }

            while (getal <= 9);

           
            
    }
        }
}
