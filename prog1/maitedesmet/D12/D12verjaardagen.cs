using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12verjaardagen
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");
            const int aantalVerjaardagen = 10;

            int[] aantalPerMaand = new int[12];
            for (int i = 0; i < aantalVerjaardagen; i++)
            {
                Console.WriteLine("Geef een geboortedatum");
                string ingegevenDatum = Console.ReadLine();

                DateTime datum;
                bool gelukt = DateTime.TryParseExact(ingegevenDatum, "dd/MM/yyyy", nlBe, System.Globalization.DateTimeStyles.None, out datum);

                int maandnummer = datum.Month;
                int index = maandnummer - 1;
                aantalPerMaand[index] = aantalPerMaand[index] + 1;

            }
            for (int index = 0; index < aantalPerMaand.Length; index++)
            {
                int maandnummer = index + 1;
                int aantal = aantalPerMaand[index];
                if (aantal > 0)
                {
                    Console.WriteLine($"In maand {maandnummer}, {aantal} verjaardag(en)");
                }
            }
        }
    }
}