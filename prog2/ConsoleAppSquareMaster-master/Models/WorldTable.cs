using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSquareMaster.Models
{
    public class WorldTable
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool ColumnAlgorithm { get; set; } = false;
        public bool SeedAlgorithm { get; set; } = false;
        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public double? Coverage { get; set; }
        public bool[,] Land { get; set; }
        public List<Empire> Empires { get; set; }
        public List<Run> Runs { get; set; } 
    }
}
