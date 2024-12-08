namespace FitnessDL.Models
{
    public class Time_Slot
    {
        public Time_Slot()
        {
        }

        public int TimeSlotID { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string PartOfDay { get; set; }
    }
}
