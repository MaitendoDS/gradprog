using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12leeftijdindagen
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");

            Console.Write("Geef uw geboortedatum (dd/mm/jjjj) : ");
            string input = Console.ReadLine();

            DateTime geboorteDatum;
            bool gelukt = DateTime.TryParseExact(input, "dd/MM/yyyy", nlBe, System.Globalization.DateTimeStyles.None, out geboorteDatum);

            DateTime vandaag = DateTime.Today; // geen tijdstip nodig noch wenselijk

            TimeSpan levenstijd = vandaag - geboorteDatum;
            Console.WriteLine($"U bent {levenstijd.TotalDays} dagen oud");
        }
    }
}
