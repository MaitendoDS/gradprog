using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class D15immutablecirkel
    {
        static void Main(string[] args)
        {
            Immutablecirkel cirkel1 = new Immutablecirkel(5);
            //cirkel1.Straal = 6;
            //"dit is read only omdat de waarde al is ingesteld"
        }
    }
}
