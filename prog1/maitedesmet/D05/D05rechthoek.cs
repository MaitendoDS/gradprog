using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    internal class D05rechthoek
    {
        static void Main(string[] args)
        {


            Console.Write("Hoogte?: ");
            int hoogte = int.Parse(Console.ReadLine());

            Console.Write("Breedte?: ");
            int breedte = int.Parse(Console.ReadLine());

            int hoogteTeller = 0;
            do
            {
                int breedteTeller = 0;
                do
                {
                    Console.Write("*");
                    breedteTeller = breedteTeller + 1;
                } while (breedteTeller < breedte);
                Console.WriteLine();
                hoogteTeller = hoogteTeller + 1;
            } while (hoogteTeller < hoogte);




        }
    }
}
