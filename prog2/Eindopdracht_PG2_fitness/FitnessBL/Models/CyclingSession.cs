using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class CyclingSession
    {
        public CyclingSession()
        {
        }

        public int CyclingSessionID { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int AvgWatt { get; set; }
        public int MaxWatt { get; set; }
        public int AvgCadence { get; set; }
        public int MaxCadence { get; set; }
        public string TrainingType { get; set; }
        public string Comment { get; set; }
        public Members MemberId { get; set; }
    }
}
