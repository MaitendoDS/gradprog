using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05vierkant
    {
        static void Main(string[] args)
        {
            Console.Write("Zijde?: ");
            int zijde = int.Parse(Console.ReadLine());


            int hoogteTeller = 0;


            do
            {
                int breedteTeller = 0;
                do
                {
                    Console.Write("*");
                    breedteTeller++;


                } while (breedteTeller < zijde);

                Console.WriteLine();
                hoogteTeller++;

            } while (hoogteTeller < zijde);

        }
    }
}
