using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class RunningSession_Main
    {
        public RunningSession_Main()
        {
        }

        public RunningSession_Main(DateTime date, Member memberID, int duration, float avgSpeed)
        {
            Date = date;
            MemberID = memberID;
            Duration = duration;
            AvgSpeed = avgSpeed;
        }

        public RunningSession_Main(int runningSessionID, DateTime date, Member memberID, int duration, float avgSpeed)
        {
            RunningSessionID = runningSessionID;
            Date = date;
            MemberID = memberID;
            Duration = duration;
            AvgSpeed = avgSpeed;
        }

        [Key]
        public int RunningSessionID{ get; set; }
        public DateTime Date { get; set; }
        public Member MemberID { get; set; }
        public int Duration { get; set; }
        public float AvgSpeed { get; set; }
    }
}
