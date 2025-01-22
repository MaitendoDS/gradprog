using FitnessBL.Models;

namespace FitnessBL.DTO
{
    public class SessionsDTO
    {

        public List<RunningSession_Main> RunningSession_Main { get; set; }
        public List<CyclingSession> CyclingSession { get; set; }

    }
}
