using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class RunningSession_MainEF
    {
        public RunningSession_MainEF()
        {
        }

        public RunningSession_MainEF(int runningSessionID, DateTime date, int memberId, TimeSpan duration, float avgSpeed, RunningSession_DetailEF runningSession_Details)
        {
            RunningSessionID = runningSessionID;
            Date = date;
            MemberID = memberId;
            Duration = duration;
            AvgSpeed = avgSpeed;
            RunningSession_Details = runningSession_Details;
        }

        [Key]
        public int RunningSessionID{ get; set; }
        public DateTime Date { get; set; }
        public int MemberID { get; set; }
        public TimeSpan Duration { get; set; }
        public float AvgSpeed { get; set; }

        public MemberEF Member { get; set; }

        public RunningSession_DetailEF RunningSession_Details { get; set; }
    }
}
