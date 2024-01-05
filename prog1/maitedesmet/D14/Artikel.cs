using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    internal class Artikel
    {
        public double BTW { get; set; } = 21;

        public double Prijs { get; set; }

        public double PrijsIncl()
        {
           double prijsIncl= (Prijs / 100 * BTW) + Prijs;
            return prijsIncl;
        }
    }
}
