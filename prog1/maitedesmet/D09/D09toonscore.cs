using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09toonscore
    {
        static void Main(string[] args)
        {

            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };

            Console.Write("welk vak?: ");
            string input = Console.ReadLine();

            int score = 0;
            bool gevonden = false;

            for (int i = 0; i < vakken.Length; i++)
            {
                string vak = vakken[i];
                if (input.ToLower() == vak.ToLower())
                {
                    score = scores[i];
                    gevonden = true;
                    break;

                }
            }
            if (gevonden)
            {
                Console.WriteLine($"de score voor {input} is {score}/100");
            } else
            {
                Console.WriteLine("geen score bekend");
            }


        }
    }
}
