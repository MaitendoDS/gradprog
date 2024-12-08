using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class RunningSession_Main
    {
        public RunningSession_Main()
        {
        }

        [Key]
        public int RunningSessionID{ get; set; }
        public DateTime Date { get; set; }
        public Members MemberID { get; set; }
        public int Duration { get; set; }
        public float AvgSpeed { get; set; }
    }
}
