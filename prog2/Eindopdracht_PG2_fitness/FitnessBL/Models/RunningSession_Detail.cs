namespace FitnessDL.Models
{
    public class RunningSession_Detail
    {
        public RunningSession_Detail()
        {
        }

        public RunningSession_Detail(int seqNr, int intervalTime, float intervalSpeed)
        {
            SeqNr = seqNr;
            IntervalTime = intervalTime;
            IntervalSpeed = intervalSpeed;
        }

        public RunningSession_Detail(int runningSessionID, int seqNr, int intervalTime, float intervalSpeed)
        {
            RunningSessionID = runningSessionID;
            SeqNr = seqNr;
            IntervalTime = intervalTime;
            IntervalSpeed = intervalSpeed;
        }

        public int RunningSessionID { get; set; }
        public int SeqNr { get; set; }
        public int IntervalTime { get; set; }
        public float IntervalSpeed { get; set; }
    }
}
