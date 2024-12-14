
using System.ComponentModel.DataAnnotations;

namespace FitnessBL.Models
{
    public class RunningSession_Main
    {
        public RunningSession_Main()
        {
        }

        public RunningSession_Main(int runningSessionID, DateTime date, int memberID, TimeSpan duration, float avgSpeed,RunningSession_Detail runningSession_Details)
        {
            RunningSessionID = runningSessionID;
            Date = date;
            MemberID = memberID;
            Duration = duration;
            AvgSpeed = avgSpeed;
            RunningSession_Details = runningSession_Details;
        }

        public int RunningSessionID{ get; set; }
        public DateTime Date { get; set; }
        public int MemberID { get; set; }
        public TimeSpan Duration { get; set; }
        public float AvgSpeed { get; set; }

        public RunningSession_Detail RunningSession_Details { get; set; }
    }
}
