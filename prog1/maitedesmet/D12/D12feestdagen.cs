using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12feestdagen
    {
        static void Main(string[] args)
        {

            const int jaartal = 2023;

            DateTime[] feestDatums =
            {
                new DateTime(jaartal,1,1),
                new DateTime(jaartal,4,22),
                new DateTime(jaartal,5,1),
                new DateTime(jaartal,5,30),
                new DateTime(jaartal,6,10),
                new DateTime(jaartal,7,21),
                new DateTime(jaartal,8,15),
                new DateTime(jaartal,11,1),
                new DateTime(jaartal,11,11),
                new DateTime (jaartal,12,25),
            };
            string[] feestNamen =
                {
                "Nieuwjaar",
                "Paasmaandag",
                "Dag van de Arbeid",
                "O.H.Hemelvaart",
                "Pinkstermaandag",
                "Nationale feestdag",
                "O.L.V.hemelvaart",
                "Allerheiligen",
                "Wapenstilstand",
                "Kerstmis"
                 };

            Console.Write($"geef de datum in {jaartal}: ");
            string datumAlsTekst = Console.ReadLine();

            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");
            DateTime datum;
            bool gelukt = DateTime.TryParseExact(datumAlsTekst, "dd/MM", nlBe, System.Globalization.DateTimeStyles.None, out datum);

            if (gelukt)
            {
                if (datum.Year != jaartal)
                {
                    datum = new DateTime(jaartal, datum.Month, datum.Day);
                }
                bool gevonden = false;
                for (int i = 0; i < feestDatums.Length; i++)
                {
                    DateTime feestDatum = feestDatums[i];
                    if (datum == feestDatum)
                    {
                        Console.WriteLine($"dat is \"{feestNamen[i]}\" in {jaartal}");
                        gevonden = true;
                        break;
                    }
                }
                if (!gevonden)
                {
                    Console.WriteLine($"dat is geen feestdag in {jaartal}");
                }
                else
                {
                    Console.WriteLine($"ongeldige datum voor {jaartal}");
                }
            }
        }
    }
}
