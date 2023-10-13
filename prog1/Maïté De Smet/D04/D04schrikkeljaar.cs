using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class D04schrikkeljaar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een jaartal");
            int ingevoerdeJaartal = int.Parse(Console.ReadLine());


            if (ingevoerdeJaartal % 4 ==0 && ingevoerdeJaartal % 100 >0 || ingevoerdeJaartal % 400 == 0)
            { Console.WriteLine("Het is een schrikkeljaar"); }
            else { Console.WriteLine("Het is geen schrikkeljaar."); }
        }
    }
}
