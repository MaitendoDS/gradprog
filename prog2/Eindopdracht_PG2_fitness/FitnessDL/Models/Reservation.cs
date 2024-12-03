namespace FitnessDL.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int EquipmentId { get; set; }
        public int TimeSlotId { get; set; }
        public DateOnly Date { get; set; }
        public int MemberId { get; set; }


    }
}
