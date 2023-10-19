using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace D01
{
    internal class D01centimetersnaarmeters
    {
        static void Main(string[] args)
        {
            int lengteInCm = 456;
            Console.WriteLine(lengteInCm);
            Console.WriteLine("cm = ");

            int volledigAantalMeters = lengteInCm / 100;
            int aantalResterendeCm = lengteInCm - volledigAantalMeters * 100;

            Console.WriteLine(volledigAantalMeters);
            Console.WriteLine("m en ");
            Console.WriteLine(aantalResterendeCm);
            Console.WriteLine("cm");

        }
    }
}
