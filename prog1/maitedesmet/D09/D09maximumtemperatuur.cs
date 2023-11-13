using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09maximumtemperatuur
    {
        static void Main(string[] args)
        {
            const double sensorProbleem = -9999.0;
            const double onmogelijkHogeMinWaarde = 1000;
            const double onmogelijkLageMaxWaarde = -1000;

            double[] meetwaarden = { 13.4, 12.1, 10.8, 10.8, 10.3, 8.9, 7.9, 7.8, 7.4, 7.2, 6.4, 9.7, 13.7, 17.2, 19.6, -9999.0, -9999.0, 22.4, 22.7, 22.8, 22.3, 18.4 };

            bool zinvolleWaardeGevonden = false;
            double min = onmogelijkHogeMinWaarde;
            double max = onmogelijkLageMaxWaarde;

            foreach (double meetwaarde in meetwaarden)
            {
                if (meetwaarde != sensorProbleem)
                {
                    zinvolleWaardeGevonden = true;
                    min = Math.Min(min, meetwaarde);
                    max = Math.Max(max, meetwaarde);
                }
            }

            if (zinvolleWaardeGevonden)
            {
                Console.WriteLine($"minimum is {min} en maximum is {max}");
            }
            else
            {
                Console.WriteLine("Geen zinvolle meetwaarden gevonden");
            }
        }
    }
}
