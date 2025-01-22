namespace FitnessBL.DTO
{
    public class ReservationsPerDayDTO
    {
        public int MemberID { get; set; }
        public DateTime Date { get; set; }

        public int TimeSlotID1 { get; set; }
        public int TimeSlotID2 { get; set; }
        public int TimeSlotID3 { get; set; }
        public int TimeSlotID4 { get; set; }

        public int EquipmentID1 { get; set; }
        public int EquipmentID2 { get; set; }
        public int EquipmentID3 { get; set; }
        public int EquipmentID4 { get; set; }


    }
}
