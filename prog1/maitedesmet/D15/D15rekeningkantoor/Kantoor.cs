using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15.D15rekeningkantoor
{
    internal class Kantoor
    {
        public Persoon Kantoorhouder { get; set; }
        public Adres Adres { get; set; }

        public Kantoor(Persoon kantoorhouder, Adres adres)
        {
            Kantoorhouder = kantoorhouder;
            Adres = adres;
        }

    }
}
