using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSquareMaster.Models
{
    public class ConquererInfo
    {
        [BsonId]
        public int Id { get; set; }
        public double AvgCoverage { get; set; }

    }
}
