using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12seizoen
    {
        static void Main(string[] args)
        {
            int jaar = DateTime.Now.Year;

            DateTime startLente = new DateTime(jaar, 03, 01);
            DateTime startZomer = new DateTime(jaar, 06, 01);
            DateTime startHerfst = new DateTime(jaar, 09, 01);
            DateTime startWinter = new DateTime(jaar, 12, 01);

            Console.Write("Geef een datum: ");
            string ingevoerdeDatum = Console.ReadLine();

            System.Globalization.CultureInfo nlBe = new System.Globalization.CultureInfo("nl-BE");

            DateTime datum;
            bool gelukt = DateTime.TryParseExact(ingevoerdeDatum, "dd/MM", nlBe, System.Globalization.DateTimeStyles.None, out datum);

            if (datum < startLente || datum >= startWinter )
            {
                Console.WriteLine("winter");
            }
            else if (datum < startZomer)
            {
                Console.WriteLine("lente");
            }
            else if (datum < startHerfst)
            {
                Console.WriteLine("zomer");
            }
            else if (datum < startWinter)
            {
                Console.WriteLine("herfst");
            }
        }
    }
}
