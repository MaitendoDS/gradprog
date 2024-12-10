using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class Time_SlotEF
    {
        public Time_SlotEF()
        {
        }

        public Time_SlotEF(int timeSlotID, TimeSpan startTime, TimeSpan endTime, string partOfDay)
        {
            TimeSlotID = timeSlotID;
            StartTime = startTime;
            EndTime = endTime;
            PartOfDay = partOfDay;
        }

        [Key]
        public int TimeSlotID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string PartOfDay { get; set; }

        public ICollection<ReservationEF> Reservations { get; set; }
    }
}
