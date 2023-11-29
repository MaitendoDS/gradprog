using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10dagen
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Maand?: ");
                int maand = int.Parse(Console.ReadLine());
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                string[] maanden = {"januari", "februari", "maart", "april", "mei", "juni", "juli",
                        "augustus", "september", "oktober", "november", "december"};
                Console.WriteLine($"In {maanden[maand - 1]} van {jaar} zijn er {AantalDagenPerMaand(maand,jaar)} dagen.");
                Console.WriteLine();
            } while (true);


        }
        static int AantalDagenPerMaand(int maand, int jaar)
        {
            int[] dagen = { 31, DagenFebruari(jaar), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return dagen[maand-1];
        }
        static int DagenFebruari(int jaar)
        {
            int aantalDagen = 28;

            if (IsSchrikkeljaar(jaar))
            {
                aantalDagen = 29;
            }
            return aantalDagen;

        }


        static bool IsSchrikkeljaar(int jaartal)
        {
            return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
        }
    }
}
    