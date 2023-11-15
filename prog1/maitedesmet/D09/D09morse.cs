using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D09
{
    internal class D09morse
    {
        static void Main(string[] args)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
          
            do
            {
                Console.Write("Morse code voor de volgende letter (. voor kort, - voor lang) ?: ");
                string input = Console.ReadLine();

                bool invoerOk = false;
                int index = Array.IndexOf(morse, input);
                string[] tekstTotNuToe = new string[letters.Length];

                
                for (int i = 0; i < letters.Length; i++)
                {
                    tekstTotNuToe[i] = letters[i].ToString();
                }

                foreach (string s in morse)
                {
                    if (s == input)
                    {
                        int i = 0;
                        Console.WriteLine($"tekst tot nu toe: {tekstTotNuToe[index]}");

                        string tekstNu = string.Join(tekstTotNuToe[i], tekstTotNuToe[index]);

                        Console.WriteLine(tekstNu);

                        i++;

                    }


                }


            } while (true);


            //domien:
            //string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            //char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //bool isMorse = false;
            //string tekst = "";
            //for (int i = 0; i < morse.Length; i++)
            //{
            //    Console.WriteLine("Morse code voor de volgende letter (. voor kort, - voor lang)?: ");
            //    string inputMorse = Console.ReadLine();

            //    if (isMorse = true && inputMorse == morse[i])
            //    {
            //        Console.WriteLine("Opgebouwde tekst tot nu toe: ");
            //        tekst += letters[i];
            //        Console.WriteLine(tekst);
            //    }
            //    else
            //    {

            //        Console.WriteLine("Ongeldige morse code! ");
            //    }

            //}
            //stukje van mij:

            //string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            //char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //do
            //{
            //    Console.Write("Morse code voor de volgende letter (. voor kort, - voor lang) ?: ");
            //    string input = Console.ReadLine();

            //    bool invoerOk = false;
            //    int index = Array.IndexOf(morse, input);

            //    foreach (string s in morse)
            //    {
            //        if (s == input)
            //        {
            //            Console.WriteLine($"tekst tot nu toe: {letters[index]}");
            //        }


            //    }


            //} while (true);

        }
    }
}
