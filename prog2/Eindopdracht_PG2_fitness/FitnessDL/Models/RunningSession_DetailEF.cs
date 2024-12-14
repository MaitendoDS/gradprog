using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class RunningSession_DetailEF
    {
        public RunningSession_DetailEF()
        {
        }

        public RunningSession_DetailEF(int runningSessionID, int seqNr, int intervalTime, float intervalSpeed)
        {
            RunningSessionID = runningSessionID;
            SeqNr = seqNr;
            IntervalTime = intervalTime;
            IntervalSpeed = intervalSpeed;
        }

        [Key]
        public int RunningSessionID { get; set; }
        public int SeqNr { get; set; }
        public int IntervalTime { get; set; }
        public float IntervalSpeed { get; set; }
        

    }
}
