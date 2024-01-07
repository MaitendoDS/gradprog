namespace D16
{
    internal class D16namenalfabetisch
    {
        static void Main(string[] args)
        {

                List<string> namen = new List<string>();

            while (true)
            {
                Console.Write("voer naam in: "); 
                string naam = Console.ReadLine();

                if (naam.Trim() == "")
                {
                    break;
                }
                namen.Add(naam);

            }
                namen.Sort();

            foreach (string naam in namen)
            {
                Console.WriteLine(naam);
            }

            //of:
            //for (int i = 0; i < namen.Count; i++)
            //{
            //    Console.WriteLine(namen[i]);
            //}

        }
    }
}