using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D08
{
    internal class D08toongetallen
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3 };

          

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[a.Length - 1])
                {

                    Console.Write(a[i] + ", ");
                }
                else { Console.WriteLine(a[i]); } 
                }
            }

        }
    }

