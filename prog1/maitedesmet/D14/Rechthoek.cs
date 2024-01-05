using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14
{
    internal class Rechthoek
    {
        private double _hoogte;
        public double GetHoogte() 
        { 
            return _hoogte;
        }

        public void SetHoogte(double hoogte)
        {
            _hoogte = hoogte;
        }

        private double _breedte;
        public double GetBreedte()
        {
            return _breedte;
        }
        public void SetBreedte (double breedte)
        {
            _breedte = breedte;
        }

        private double _oppervlakte;
        public double Oppervlakte()
        {
            _oppervlakte = _hoogte * _breedte;
            return _oppervlakte;
        }
        

    }
}
