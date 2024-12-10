namespace FitnessDL.Models
{
    public class Time_Slot
    {
        public Time_Slot()
        {
        }

        public Time_Slot(int startTime, int endTime, string partOfDay)
        {
            StartTime = startTime;
            EndTime = endTime;
            PartOfDay = partOfDay;
        }

        public Time_Slot(int timeSlotID, int startTime, int endTime, string partOfDay)
        {
            TimeSlotID = timeSlotID;
            StartTime = startTime;
            EndTime = endTime;
            PartOfDay = partOfDay;
        }

        public int TimeSlotID { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string PartOfDay { get; set; }
    }
}
