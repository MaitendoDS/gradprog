using System.ComponentModel.DataAnnotations;

namespace FitnessBL.Models
{
    public class CyclingSession
    {
        public CyclingSession()
        {
        }

        public CyclingSession(int cyclingSessionID, DateTime date, TimeSpan duration, int avgWatt, int maxWatt, int avgCadence, int maxCadence, string trainingType, string comment, int memberID)
        {
            CyclingSessionID = cyclingSessionID;
            Date = date;
            Duration = duration;
            AvgWatt = avgWatt;
            MaxWatt = maxWatt;
            AvgCadence = avgCadence;
            MaxCadence = maxCadence;
            TrainingType = trainingType;
            Comment = comment;
            MemberID = memberID;
        }

        public int CyclingSessionID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public int AvgWatt { get; set; }
        public int MaxWatt { get; set; }
        public int AvgCadence { get; set; }
        public int MaxCadence { get; set; }
        public string TrainingType { get; set; }
        public string Comment { get; set; }
        public int MemberID { get; set; }
        
    }
}
