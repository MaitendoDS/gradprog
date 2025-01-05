using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSquareMaster.Models
{
    public class Run
    {
        public int RunNumber { get; set; }
        public List<EmpireInfo> Empires { get; set; }
        public int[,] FinalWorldState { get; set; } // wereld na deze run
        
    }
}
