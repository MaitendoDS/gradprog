using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08inhoudwisselen
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 34, 56, 78, 90 };
            int[] b = { 31, 42, 53, 64, 75 };

            Console.Write("De inhoud van a voor de wissel : ");
            Console.WriteLine(String.Join(',', a));

            int[] c = a;
           
            a = b;
            b = c;

            Console.Write("De inhoud van a na de wissel : ");
            Console.WriteLine(String.Join(',', a));
        }
    }
}
