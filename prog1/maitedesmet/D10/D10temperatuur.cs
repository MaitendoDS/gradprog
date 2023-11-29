using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10temperatuur
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Geef de temperatuur in graden Fahrenheit:");
            string temperatuurFahrenheit = Console.ReadLine();

            double Fahrenheit = Double.Parse(temperatuurFahrenheit);

            double Celsius = ConvertFahrenheitToCelsius(Fahrenheit);

            Console.WriteLine(temperatuurFahrenheit + " graden Fahrenheit is " + Celsius + " graden Celsius.");


        }
        static double ConvertFahrenheitToCelsius (double Fahrenheit)
        {

            double Celsius = 5.0 / 9 * (Fahrenheit - 32);

            return Celsius;

        }
    }
}
