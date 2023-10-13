using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class D04bmi
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Lengte in cm?");
            string ingevoerdeLengteInCm = Console.ReadLine();
            double lengteInCm = double.Parse(ingevoerdeLengteInCm);
            double lengteInM = lengteInCm / 100;

            Console.WriteLine("Gewicht in kg?");
            string ingevoerdeGewicht = Console.ReadLine();
            double gewicht = double.Parse(ingevoerdeGewicht);

            double bmi = gewicht / Math.Pow(lengteInM,2);


            string omschrijving = "(Normaal gewicht)";

            if (bmi < 18.5) { omschrijving = "(Ondergewicht)"; }
            else if (bmi >= 18.5) { omschrijving = "(Normaal gewicht)"; }
            else if (bmi >= 25) { omschrijving = "(Overgewicht)"; }
            else if (bmi >= 30) { omschrijving = "(Zwaarlijvigheid)"; }
            else if (bmi >= 40) { omschrijving = "(Ernstige zwaarlijvigheid)"; }

            Console.WriteLine(bmi + " " + omschrijving);
        }
    }
}
