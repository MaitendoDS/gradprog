using MongoDB.Driver;
using ConsoleAppSquareMaster.Models;
using ConsoleAppSquareMaster.Conquerers;
using System;
using System.Text;

namespace ConsoleAppSquareMaster
{
    internal class Program
    {
        public static double Coverage1 { get; set; }
        public static double Coverage2 { get; set; }
        public static double Coverage3 { get; set; }

        static async Task Main(string[] args) ////
        {
            // Verbind met MongoDB
            var client = new MongoClient("mongodb://localhost:27017/");
            var database = client.GetDatabase("Worlds");
            var worldCollection = database.GetCollection<WorldTable>("World");
            var conquerCollection = database.GetCollection<ConquererInfo>("ConquererInfo");
            await worldCollection.DeleteManyAsync(FilterDefinition<WorldTable>.Empty); ////
            await conquerCollection.DeleteManyAsync(FilterDefinition<ConquererInfo>.Empty);////


            List<Task> tasks = new List<Task>(); /////


            for (int i = 0; i < 10; i++)
            {
                int itr = i;
                tasks.Add(Task.Run(async () => ////
                {
                    World world = new World();
                    Random random = new Random();

                    WorldTable worldTable = new WorldTable();

                    int rMaxX = random.Next(50, 176);
                    int rMaxY = random.Next(50, 101);
                    double rCoverage = random.NextDouble();

                    worldTable.Id = itr + 1;
                    worldTable.Name = "Wereld " + (itr + 1);
                    worldTable.MaxX = rMaxX;
                    worldTable.MaxY = rMaxY;
                    worldTable.Coverage = rCoverage;

                    if (random.Next(2) == 0)
                    {
                        worldTable.Land = world.BuildWorld1(rMaxX, rMaxY);
                        worldTable.ColumnAlgorithm = true;
                    }
                    else
                    {
                        worldTable.Land = world.BuildWorld2(rMaxX, rMaxY, rCoverage);
                        worldTable.SeedAlgorithm = true;
                    }

                    //PrintEmptyWorld(worldTable.Land);

                    worldTable.Empires = await CreateEmpiresAsync(random);     ////
                    worldTable.Runs = await NewRun(worldTable.Empires, worldTable.Land, itr + 1);

                    Console.WriteLine("Finished world " + (itr + 1));
                    await worldCollection.InsertOneAsync(worldTable);/////

                }));
            }
            await Task.WhenAll(tasks); ////
            ConquererInfo conquererInfo1 = new ConquererInfo();
            ConquererInfo conquererInfo2 = new ConquererInfo();
            ConquererInfo conquererInfo3 = new ConquererInfo();

            conquererInfo1.Id = 1;
            conquererInfo2.Id = 2;
            conquererInfo3.Id = 3;

            conquererInfo1.AvgCoverage = Math.Round(Coverage1 / 30, 2);
            conquererInfo2.AvgCoverage = Math.Round(Coverage2 / 30, 2);
            conquererInfo3.AvgCoverage = Math.Round(Coverage3 / 30, 2);

            List<ConquererInfo> conquererInfos = new List<ConquererInfo>();
            conquererInfos.Add(conquererInfo1);
            conquererInfos.Add(conquererInfo2);
            conquererInfos.Add(conquererInfo3);

            await conquerCollection.InsertManyAsync(conquererInfos); ////
        }
        public static ConquererInfo CountAverageCoverage(List<double> coverages, int id)
        {
            ConquererInfo conquererInfo = new ConquererInfo();
            conquererInfo.Id = id;
            conquererInfo.AvgCoverage = coverages.Sum() / 30;
            Console.WriteLine(conquererInfo.AvgCoverage);
            return conquererInfo;         
        }

        public static (int, double) CountEmpireSquares(int[,] world, bool[,] land, int empireId)
        {

            double worldCount = 0;

            for (int y = 0; y < land.GetLength(0); y++)
            {
                for (int x = 0; x < land.GetLength(1); x++)
                {
                    if (land[y, x])
                    {
                        worldCount++;
                    }
                }
            }

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
            return (count, worldCount);
        }

        public static async Task<List<Run>> NewRun(List<Empire> normalEmpires, bool[,] land, int id) ////
        {
            IConquerer conquerer1 = new Conquerer1();
            IConquerer conquerer2 = new Conquerer2();
            IConquerer conquerer3 = new Conquerer3();

            List<Run> runs = new List<Run>();
            List<EmpireInfo> empires = new List<EmpireInfo>();

            for (int i = 0; i < normalEmpires.Count; i++)
            {
                EmpireInfo empireInfo = new EmpireInfo();
                empireInfo.Id = normalEmpires[i].Id;
                empireInfo.Name = normalEmpires[i].Name;
                empireInfo.Con1 = normalEmpires[i].Con1;
                empireInfo.Con2 = normalEmpires[i].Con2;
                empireInfo.Con3 = normalEmpires[i].Con3;

                empires.Add(empireInfo);
            }

            for (int m = 0; m < 3; m++)
            {
                Console.WriteLine("running world " + id + " game " + (m + 1));
                Run run = new Run();
                run.RunNumber = m + 1;
                run.Empires = empires;
                int[,] ww = null;

                for (int i = 0; i < run.Empires.Count; i++)
                {
                    if (run.Empires[i].Con1 == true)
                    {
                        ww = conquerer1.Conquer(land, run.Empires[i].Id, 4000);
                    }
                    else if (run.Empires[i].Con2 == true)
                    {
                        ww = conquerer2.Conquer(land, run.Empires[i].Id, 4000);
                    }
                    else
                    {
                        ww = conquerer3.Conquer(land, run.Empires[i].Id, 4000);
                    }
                }
                run.FinalWorldState = ww;
                BitmapWriter bmw = new BitmapWriter();
                bmw.DrawWorld(ww, id, m + 1);

                //PrintConqueredWorld(run.FinalWorldState);
                runs.Add(run);

                for (int i = 0; i < run.Empires.Count; i++)
                {
                    var result = CountEmpireSquares(ww, land, run.Empires[i].Id);
                    run.Empires[i].Squares = result.Item1;
                    run.Empires[i].WorldCoverage = Math.Round((result.Item1 / result.Item2) * 100, 2);

                    if (run.Empires[i].Con1)
                    {
                        Coverage1 += run.Empires[i].WorldCoverage;
                    }
                    else if (run.Empires[i].Con2)
                    {
                        Coverage2 += run.Empires[i].WorldCoverage;
                    }
                    else
                    {
                        Coverage3 += run.Empires[i].WorldCoverage;
                    }
                }
            }
            return runs;
        }

        public static async Task<List<Empire>> CreateEmpiresAsync(Random random) ////
        {
            List<Empire> empires = new List<Empire>();

            for (int m = 0; m < 4; m++) // 4 rijken per wereld
            {

                Empire empire = new Empire();
                empire.Id = m + 1;
                empire.Name = $"Empire{m + 1}";

                int rando = random.Next(1, 4);

                if (rando == 1)
                {
                    empire.Con1 = true;
                }
                else if (rando == 2)
                {
                    empire.Con2 = true;
                }
                else
                {
                    empire.Con3 = true;
                }
                empires.Add(empire);
            }

            return empires;

        }

        public static void PrintEmptyWorld(bool[,] land)
        {

            // lege wereld
            for (int j = 0; j < land.GetLength(1); j++)
            {
                for (int k = 0; k < land.GetLength(0); k++)
                {
                    char ch;
                    if (land[k, j]) ch = '*'; else ch = ' ';
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }

        public static void PrintConqueredWorld(int[,] ww)
        {
            //werelden op console
            for (int j = 0; j < ww.GetLength(1); j++)
            {
                for (int k = 0; k < ww.GetLength(0); k++)
                {
                    string ch;
                    switch (ww[k, j])
                    {
                        case -1: ch = " "; break;
                        case 0: ch = "."; break;
                        default: ch = ww[k, j].ToString(); break;
                    }
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }
    }

}






