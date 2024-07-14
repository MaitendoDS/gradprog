using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    internal class Artikel
    {
        public decimal BTW { get; set; } = 21;

        public decimal Prijs { get; set; }

        public decimal PrijsIncl()
        {
           decimal prijsIncl= (Prijs / 100 * BTW) + Prijs;
            return prijsIncl;
        }

    }
}
