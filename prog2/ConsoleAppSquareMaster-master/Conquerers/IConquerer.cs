using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSquareMaster.Conquerers
{
    public interface IConquerer
    {
        int[,] Conquer(bool[,] world, int empireID, int turns);
    }
}
