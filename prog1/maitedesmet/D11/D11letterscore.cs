namespace D11
{
    internal class D11letterscore
    {
        static void Main()
        {
            Console.Write("Geef de score in % : ");
            string scoreAlsTekst = Console.ReadLine();
            int score = int.Parse(scoreAlsTekst);

            string letter = GetLetterCodeForPercentage(score);

            Console.WriteLine($"In Amerika is dat een \"{letter}\"");
        }
        static string GetLetterCodeForPercentage(int score)
        {
            string letter;
            if (score > 82) { letter = "A"; }
            else if (score > 67) { letter = "B"; }
            else if (score > 52) { letter = "C"; }
            else if (score > 37) { letter = "D"; }
            else if (score > 22) { letter = "E"; }
            else { letter = "F"; }

            return letter;
        }
    }
}