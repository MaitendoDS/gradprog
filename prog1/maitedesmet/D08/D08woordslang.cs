using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08woordslang
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                string[] woorden = new string[5];
                bool isWoordslang = true;

                for (int i = 0; i < woorden.Length; i++)
                {
                    Console.Write("Geef een woord: ");
                    woorden[i] = Console.ReadLine();

                    if (i > 0 && woorden[i][0] != woorden[i - 1][woorden[i - 1].Length - 1])
                    {
                        isWoordslang = false;
                        break;
                    }
                }

                if (isWoordslang)
                {
                    Console.Write("De woordslang is: ");
                    for (int i = 0; i < woorden.Length; i++)
                    {
                        Console.Write(woorden[i]);
                        if (i < woorden.Length - 1)
                        {
                            Console.Write("-");
                        }
                    }
                }
                else
                {
                    Console.Write("Het is geen woordslang: ");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.Write(woorden[i]);
                        if (i < 1)
                        {
                            Console.Write("-");
                        }
                    }
                }

                Console.ReadLine();
            }

        }
    }
}
