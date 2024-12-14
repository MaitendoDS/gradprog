using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Interfaces
{
    public interface IRunningSessionRepository
    {
        public RunningSession_Main Get(int id);

    }
}
