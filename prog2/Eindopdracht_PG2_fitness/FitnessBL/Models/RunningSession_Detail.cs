namespace FitnessDL.Models
{
    public class RunningSession_Detail
    {
        public RunningSession_Detail()
        {
        }

        public int RunningSessionID { get; set; }
        public int SeqNr { get; set; }
        public int IntervalTime { get; set; }
        public float IntervalSpeed { get; set; }
    }
}
