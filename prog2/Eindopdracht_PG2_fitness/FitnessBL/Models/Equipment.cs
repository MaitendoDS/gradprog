using System.ComponentModel.DataAnnotations;

namespace FitnessBL.Models
{
    public class Equipment
    {
        public Equipment()
        {
        }

        public Equipment(int equipmentID, string deviceType, bool inRepair)
        {
            EquipmentID = equipmentID;
            DeviceType = deviceType;
            InRepair = inRepair;
        }

        public int EquipmentID { get; set; }
        public string DeviceType { get; set; }
        public bool InRepair { get; set; }
    }
}
