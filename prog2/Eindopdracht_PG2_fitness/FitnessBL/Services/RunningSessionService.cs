using FitnessBL.Interfaces;
using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Services
{
    public class RunningSessionService
    {
        private IRunningSessionRepository _runningSessionRepository;

        public RunningSessionService(IRunningSessionRepository runningSessionRepository)
        {
            _runningSessionRepository = runningSessionRepository;
        }

        public RunningSession_Main Get(int id)
        {
            try
            {
                return _runningSessionRepository.Get(id);
            }
            catch (Exception x)
            {

                throw new Exception("RunningSessionService-Get", x);
            }
        }
    }
}
