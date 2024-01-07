using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class D15cirkeloverlapt
    {
        static void Main(string[] args)
        {
            Cirkelpunt c1 = new Cirkelpunt(10, 20, 5);
            Cirkelpunt c2 = new Cirkelpunt(8, 12, 10);
            Cirkelpunt c3 = new Cirkelpunt(100, 200, 3);

            Console.WriteLine(c1.Overlapt(c1, c2));  // moet true opleveren
            //Console.WriteLine(Cirkelpunt.Overlapt(c2, c3));  // moet false opleveren



            // als ik die static niet in mn method had gezet moet ik c1.overlapt typen smh
        }
    }
}
