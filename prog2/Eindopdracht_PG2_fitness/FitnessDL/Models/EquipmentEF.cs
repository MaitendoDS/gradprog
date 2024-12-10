using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class EquipmentEF
    {
        public EquipmentEF()
        {
        }

        public EquipmentEF(int equipmentID, string deviceType, bool inRepair)
        {
            EquipmentID = equipmentID;
            DeviceType = deviceType;
            InRepair = inRepair;
        }

        [Key]
        public int EquipmentID { get; set; }
        public string DeviceType { get; set; }
        public bool InRepair { get; set; }

        public ICollection<ReservationEF> Reservations { get; set; }
    }
}
