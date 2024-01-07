using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15
{
    class Persoon
    {

        public string Naam { get; set; }

        public DateTime Geboortedatum { get; set; }

        public int Leeftijd()
        {
            int leeftijd = 0;
            DateTime dt = Geboortedatum.Date.AddYears(1);
            while (dt <= DateTime.Today)
            {
                leeftijd++;
                dt = dt.AddYears(1);
            }
            return leeftijd;
        }

        public string Woonplaats { get; set; }


    }
}
