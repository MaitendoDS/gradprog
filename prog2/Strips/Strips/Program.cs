using StripsDL;

namespace Strips
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StripsContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Console.WriteLine("Database is opnieuw aangemaakt");
            }
        }
    }
}
