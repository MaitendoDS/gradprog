using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09toongetallenmetjoin
    {
        static void Main(string[] args)
        {
            int[] getallen = { 4, 7, 9, 34, 2, 56, 34, 78 };

            Console.WriteLine(String.Join(',', getallen));
        }
    }
}
