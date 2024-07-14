namespace D17
{
    internal class D17scheldwoorden
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> scheldwoorden = new Dictionary<string, string>
            {
                { "rotjoch", "joch die rot is"}
                , {"banaan", "een banaan"}
                , {"hond", "hond woef vuile hond"}
                ,{"oma", "oud"}
                ,{"moeder", "je moeder"}
            };
            do
            {

                Console.WriteLine("geef een scheldwoord");
                string input = Console.ReadLine();
                if (scheldwoorden.ContainsKey(input))
                {
                    Console.WriteLine(scheldwoorden[input]);
                }
                else
                {
                    Console.WriteLine("geen gekend scheldwoord");
                }
            } while (true);

        }
    }
}