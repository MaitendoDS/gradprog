namespace FitnessDL.Models
{
    public class Time_Slot
    {
        public int TimeSlotId { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string PartOfDay { get; set; }
    }
}
