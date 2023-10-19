using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class D04score
    {
        static void Main(string[] args)
        {
            Console.Write("Wat is de score?");
            int score = int.Parse(Console.ReadLine());

            if (score > 82) { Console.WriteLine("Score A"); }
            else if (score > 67) { Console.WriteLine("Score B"); }
            else if (score > 52) { Console.WriteLine("Score C"); }
            else if (score > 37) { Console.WriteLine("Score D"); }
            else if (score > 22) { Console.WriteLine("Score E"); }
            else { Console.WriteLine("Score F"); }
        }
    }
}
