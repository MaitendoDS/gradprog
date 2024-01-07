using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D15.D15rekeningkantoor
{
    internal class Persoon
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public Adres Adres { get; set; }

        public Persoon(string voornaam, string familienaam, Adres adres)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Adres = adres;
        }
    }
}
