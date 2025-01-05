using MongoDB.Driver;
using ConsoleAppSquareMaster.Models;
using ConsoleAppSquareMaster.Conquerers;
using System.Threading.Tasks;
using System.Text;

namespace ConsoleAppSquareMaster
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
            var client = new MongoClient("mongodb://localhost:27017/");
            var database = client.GetDatabase("Worlds");
            var collection = database.GetCollection<WorldTable>("World");

            
            await collection.DeleteManyAsync(FilterDefinition<WorldTable>.Empty);

            Console.WriteLine("Hello, World!");
            World world = new World();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                IConquerer conquerer1 = new Conquerer1();
                IConquerer conquerer2 = new Conquerer2();
                IConquerer conquerer3 = new Conquerer3();

                WorldTable worldTable = new WorldTable();

                
                int rMaxX = random.Next(50, 176);
                int rMaxY = random.Next(50, 101);
                double rCoverage = random.NextDouble();

               
                bool[,] w;
                if (random.Next(2) == 0)
                {
                    w = world.BuildWorld1(rMaxX, rMaxY);
                    Console.WriteLine("Using BuildWorld1");

                    worldTable.ColumnAlgorithm = true; 
                }
                else
                {
                    w = world.BuildWorld2(rMaxX, rMaxY, rCoverage);
                    Console.WriteLine("Using BuildWorld2");

                    worldTable.SeedAlgorithm = true; 
                }

                
                Dictionary<int, IConquerer> empireAlgorithmMap = new Dictionary<int, IConquerer>();
                for (int m = 0; m < 4; m++)
                {
                    int rando = random.Next(1, 4);
                    if (rando == 1)
                    {
                        empireAlgorithmMap[m + 1] = conquerer1;
                    }
                    else if (rando == 2)
                    {
                        empireAlgorithmMap[m + 1] = conquerer2;
                    }
                    else
                    {
                        empireAlgorithmMap[m + 1] = conquerer3;
                    }
                }
                    List<Run> runs = new();

                for (int run = 0; run < 3; run++)
                {
                    Console.WriteLine($"Run {run + 1} for World {i + 1}");

                    List<Empire> empires = new();

                    int[,] ww = new int[rMaxX, rMaxY];

                    
                    var empireTasks = empireAlgorithmMap.Select(async entry =>
                    {
                        int empireId = entry.Key;
                        IConquerer conquerer = entry.Value;

                        Empire empire = new Empire();
                        empire.Name = "Empire" + empireId;
                        empire.Id = empireId;
                        
                        if (conquerer is Conquerer1) empire.Con1 = true;
                        if (conquerer is Conquerer2) empire.Con2 = true;
                        if (conquerer is Conquerer3) empire.Con3 = true;

                        ww = conquerer.Conquer(w, empire.Id, 4000);

                        int squares = CountEmpireSquares(ww, empire.Id);
                        empire.Squares = squares;
                        empire.WorldCoverage = Math.Round(((double)squares / (rMaxX * rMaxY) * 100), 2);

                        Console.WriteLine($"{empire.Name}: {empire.Squares} squares = {empire.WorldCoverage}% using algorithm {(empire.Con1 ? "1" : empire.Con2 ? "2" : "3")}");

                        return empire;
                    });

                    
                    var empireResults = await Task.WhenAll(empireTasks);
                    empires.AddRange(empireResults);

                    
                    worldTable.Id = i + 1;
                    worldTable.Land = w;
                    worldTable.Name = "Wereld " + (i + 1);
                    worldTable.MaxX = rMaxX;
                    worldTable.MaxY = rMaxY;
                    worldTable.Coverage = rCoverage;
                    worldTable.Empires = empires;
                    worldTable.Runs = runs;


                    await collection.InsertOneAsync(worldTable);

                    
                    BitmapWriter bmw = new BitmapWriter();
                    await Task.Run(() => bmw.DrawWorld(ww, worldTable.Id)); 

                    Console.WriteLine("Finished world " + (i + 1));

                    worldTable.Runs.Add(new Run
                    {
                        RunNumber = run + 1,
                        Empires = empires,
                        FinalWorldState = ww
                    });
                }


                int CountEmpireSquares(int[,] world, int empireId)
                {
                    int count = 0;
                    for (int y = 0; y < world.GetLength(0); y++)
                    {
                        for (int x = 0; x < world.GetLength(1); x++)
                        {
                            if (world[y, x] == empireId)
                            {
                                count++;
                            }
                        }
                    }
                    return count;
                }
            }
        }
    }
}
