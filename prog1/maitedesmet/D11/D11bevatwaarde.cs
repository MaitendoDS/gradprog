using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11
{
    internal class D11bevatwaarde
    {
        //static void Main(string[] args)
        //{
        //    bool juisteWaarde = false;


        //    string[] getallen = new string[4];

        //    Console.Write("Geef getal #1: ");
        //    getallen[0] = Console.ReadLine();

        //    Console.Write("Geef getal #2: ");
        //    getallen[1] = Console.ReadLine();

        //    Console.Write("Geef getal #3: ");
        //    getallen[2] = Console.ReadLine();

        //    Console.Write("Geef getal #4: ");
        //    getallen[3] = Console.ReadLine();

        //    Console.Write("Geef getal #5: ");
        //    getallen[4] = Console.ReadLine();

        //    BevatWaarde(getallen, getal1);

        //}
        //static bool BevatWaarde(int[] getallen, int zoekgetal)
        //{
        //    if (
        //}
        static void Main(string[] args)
        {
            int[] getallen = new int[4];
            int getal = 0;

            for (int i = 0; i < 6; i++)
            {
                bool invoerOK = false;

                while (!invoerOK)
                {
                    Console.Write($"Geef getal #{i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out getal) && getal != 0 && !BevatWaarde(getallen, getal))
                    {
                        getallen[i] = getal;
                        invoerOK = true;
                    }
                    else
                    {
                        Console.WriteLine("Ongeldige invoer. Probeer het opnieuw.");
                    }
                }
            }

            Console.WriteLine($"De array bevat: {string.Join(",", getallen)}");
        }
        static bool BevatWaarde(int[] getallen, int zoekgetal)
        {
            foreach (int getal in getallen)
            {
                if (zoekgetal == getal)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

}

