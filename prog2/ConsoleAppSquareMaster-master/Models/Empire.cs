using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSquareMaster.Models
{
    public class Empire
    {

        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }

        public bool Con1 { get; set; } = false;
        public bool Con2 { get; set; } = false;
        public bool Con3 { get; set; } = false;
        public int Squares { get; set; }
        public double WorldCoverage { get; set; }

    }
}
