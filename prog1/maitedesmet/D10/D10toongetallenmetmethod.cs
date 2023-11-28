using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D10
{
    internal class D10toongetallenmetmethod
    {
        static void Main(string[] args)
        {
            int[] getallen = { 4, 7, 9, 34, 2, 56, 34, 78 };
            ToonGetallen(getallen);

        }
        static void ToonGetallen(int[] input)
        {
            Console.WriteLine(String.Join(',', input));
        }
    }
}