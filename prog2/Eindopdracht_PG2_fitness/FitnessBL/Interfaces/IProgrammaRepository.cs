using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Interfaces
{
    public interface IProgrammaRepository
    {
        public Programma Add(Programma programma);
        public Programma Update(Programma programma);
        bool Delete(int id);


    }
}
