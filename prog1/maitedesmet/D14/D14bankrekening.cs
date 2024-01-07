using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    class D14bankrekening
    {
        
            static void Main()
            {
                Bankrekening b1 = new Bankrekening();
                Bankrekening b2 = new Bankrekening();

                decimal bedrag = 100m;

                b1.SchrijfOver(b1,b2,bedrag);

            Console.WriteLine(b1.Saldo() == -100m); // zou true moeten geven
                Console.WriteLine(b2.Saldo() == 100m);  // zou true moeten geven
            }
        }
}
