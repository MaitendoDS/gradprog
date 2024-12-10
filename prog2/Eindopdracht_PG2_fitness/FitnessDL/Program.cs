// See https://aka.ms/new-console-template for more information
using FitnessDL;

    using (var context = new FitnessContext())
    {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        Console.WriteLine("Database is opnieuw aangemaakt");
    }
