using FitnessBL.Models;

namespace Eindopdracht_PG2_fitness.DTO
{
    public class SessionsDTO
    {

        public List<RunningSession_Main> RunningSession_Main { get; set; }
        public List<CyclingSession> CyclingSession { get; set; }

    }
}
