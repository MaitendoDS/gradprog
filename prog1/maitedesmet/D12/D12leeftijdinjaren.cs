using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12leeftijdinjaren
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");

            Console.Write("Geef uw geboortedatum (dd/mm/jjjj) : ");
            string input = Console.ReadLine();

            DateTime geboorteDatum;
            bool gelukt = DateTime.TryParseExact(input, "dd/MM/yyyy", nlBe, System.Globalization.DateTimeStyles.None, out geboorteDatum);

            DateTime vandaag = DateTime.Today; // geen tijdstip nodig noch wenselijk

            int leeftijd = vandaag.Year - geboorteDatum.Year;

            // corrigeer indien de gebruiker dit jaar nog niet verjaard is
            DateTime verjaardagDitJaar = new DateTime(vandaag.Year, geboorteDatum.Month, geboorteDatum.Day);
            if (verjaardagDitJaar > vandaag)
            {
                leeftijd--;
            }

            string vandaagAlsString = vandaag.ToString("dd/MM/yyy");
            Console.WriteLine($"Vandaag is het {vandaagAlsString}, dus u bent {leeftijd} jaar oud");
        }
    }
}
