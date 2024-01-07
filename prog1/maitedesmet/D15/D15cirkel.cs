using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class D15cirkel
    {
        static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel();
            cirkel.Straal = 3.45;

            Console.WriteLine(cirkel.Straal + cirkel.Oppervlakte() + cirkel.Omtrek());
        }
    }
}
