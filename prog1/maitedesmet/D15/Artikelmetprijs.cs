using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    internal class Artikelmetprijs
    {
        public decimal BTW { get; set; } = 21;

        public decimal Prijs { get; set; }

        public Artikelmetprijs(decimal prijs, decimal btw)
        {
            BTW = btw;
            Prijs = prijs;
        }

        public Artikelmetprijs(decimal prijs)
        {
           
            Prijs = prijs;
        }


        public decimal PrijsIncl()
        {
            decimal prijsIncl = (Prijs / 100 * BTW) + Prijs;
            return prijsIncl;
        }
    }
}
