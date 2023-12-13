using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12
{
    internal class D12getresultaat
    {
        static void Main(string[] args)
        {

            int[] scoresA = { 3, 7, 10 };
            int[] scoresB = { 4, 6, 9 };
            int[] leeg = { };

            Console.WriteLine(GetResultaat(scoresA, scoresB)); // toont negatief getal want speler 1 wint
            Console.WriteLine(GetResultaat(scoresB, scoresA)); // toont positief getal want speler 2 wint
            Console.WriteLine(GetResultaat(scoresA, scoresA)); // toont zero want gelijkspel
            Console.WriteLine(GetResultaat(leeg, leeg)); // toont zero want gelijkspel

        }
        static int GetResultaat(int[] scoresSpeler1, int[] scoresSpeler2)
        {
            int score = 0;
            int wincount1 = 0;
            int wincount2 = 0;
            for (int i = 0; i < scoresSpeler1.Length; i++)
            {
                if (scoresSpeler1[i] > scoresSpeler2[i])
                {
                    wincount1++;
                }
                else if (scoresSpeler1[i] < scoresSpeler2[i])
                {
                    wincount2++;
                }
               
            }

            if (wincount1 < wincount2)
            {
                score = 1;
            }
            else if (wincount2 < wincount1)
            {
                score = -1;
            }
            else
            {
                score = 0;
            }
            return score;
        }
    }
}
