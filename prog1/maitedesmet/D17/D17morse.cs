using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace D17
{
    internal class D17morse
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> letterNaarMorse = new Dictionary<string, string>
            {
                {"A",".-" },
                {"B", "-..." },
                {"C","-.-." },
                {"D","-.." },
                {"E","." },
                {"F","..-." }
            };

            do
            {
                Console.Write("Geef een woord: ");
                string input = Console.ReadLine().ToUpper();

                for (int i = 0;i>input.Length;i++)
                {
                    //aaaaaaaa idk
                }

                Console.WriteLine(letterNaarMorse[input]);
            }
            while (true);
            


        }
    }
}
