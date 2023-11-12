using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09dagnummernaarmaand
    {
        static void Main(string[] args)
        {
            int[] aantalDagen = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] maandNamen = { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };

            Console.WriteLine("geef het dagnummer: ");
            int dagnummer = int.Parse(Console.ReadLine());

            string maand = "";
            int laatseDagNummmerDezeMaand = 0;

            for (int i = 0; i < aantalDagen.Length; i++)
            {
                laatseDagNummmerDezeMaand += aantalDagen[i];
                if (dagnummer <= laatseDagNummmerDezeMaand)
                {
                    maand = maandNamen[i];
                    break;
                }
            }

            Console.WriteLine($"de maand is {maand}");
        }
    }
}
