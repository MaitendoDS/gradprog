using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class CyclingSession
    {
        public CyclingSession()
        {
        }

        public CyclingSession(DateTime date, int duration, int avgWatt, int maxWatt, int avgCadence, int maxCadence, string trainingType, string comment, Member memberId)
        {
            Date = date;
            Duration = duration;
            AvgWatt = avgWatt;
            MaxWatt = maxWatt;
            AvgCadence = avgCadence;
            MaxCadence = maxCadence;
            TrainingType = trainingType;
            Comment = comment;
            MemberId = memberId;
        }

        public CyclingSession(int cyclingSessionID, DateTime date, int duration, int avgWatt, int maxWatt, int avgCadence, int maxCadence, string trainingType, string comment, Member memberId)
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
            MemberId = memberId;
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
        public Member MemberId { get; set; }
    }
}
