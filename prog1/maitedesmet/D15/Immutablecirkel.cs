using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    class Immutablecirkel
    {
        public Immutablecirkel(double straal)
        {
            this.Straal = straal;
        }

        public double Straal { get; }

        public double Oppervlakte()
        {
            double oppervlakte = Straal * Straal * Math.PI;
            return oppervlakte;
        }

        public double Omtrek()
        {
            double omtrek = Straal * 2 * Math.PI;
            return omtrek;
        }
    }
}
