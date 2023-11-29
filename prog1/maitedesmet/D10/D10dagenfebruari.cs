using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10dagenfebruari
    {
        static void Main()
        {
            do
            {
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());



                Console.WriteLine($"In februari van {jaar} zijn er {DagenFebruari(jaar)} dagen.");
                Console.WriteLine();
            } while (true);


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
