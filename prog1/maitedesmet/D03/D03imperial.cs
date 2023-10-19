using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    internal class D03imperial
    {
        static void Main(string[] args)
        {
            const double feetNaarCm = 30.48;
            const double inchesNaarCm = 2.54;

            Console.WriteLine("Geef het aantal feet:");
            string aantalFeetAlsTekst = Console.ReadLine();
            double aantalFeet = double.Parse(aantalFeetAlsTekst);


            Console.WriteLine("Geef het aantal inches:");
            string aantalInchesAlsTekst = Console.ReadLine();
            double aantalInches = double.Parse(aantalInchesAlsTekst);

            double aantalFeetInCm = aantalFeet * feetNaarCm;
            double aantalInchesInCm = aantalInches * inchesNaarCm;

            double totaalInCm = aantalFeetInCm + aantalInchesInCm;

            Console.WriteLine($"Dat is {totaalInCm}cm.");

        }
    }
}
