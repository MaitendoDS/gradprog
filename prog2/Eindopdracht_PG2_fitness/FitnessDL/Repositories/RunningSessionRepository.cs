using FitnessBL.Interfaces;
using FitnessBL.Models;
using FitnessDL.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Repositories
{
    public class RunningSessionRepository: IRunningSessionRepository
    {
        private FitnessContext _context;
        public RunningSessionRepository(FitnessContext context)
        {
            _context = context;
        }
      
        public RunningSession_Main Get(int id)
        {
            try
            {
                var runningSession = _context.Runningsession_Main
                    .Include(r => r.RunningSession_Details)
                    .FirstOrDefault(r => r.RunningSessionID == id);

                return runningSession != null ? MapRunningSessionMain.MapToBL(runningSession) : throw new Exception("RunningSession is null");
            }
            catch (Exception x)
            {
                throw new Exception("RunningSessionRepository-Get", x);
            }
        }
    }
}
