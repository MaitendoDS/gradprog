using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    class Rechthoek
    {
        public double Breedte { get; set; }
        public double Hoogte { get; set; }

        public double Oppervlakte()
        {
           double oppervlakte = Breedte * Hoogte;
            return oppervlakte;
        }

    }
}
