using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class Equipment
    {
        public Equipment()
        {
        }

        public Equipment(string deviceType)
        {
            DeviceType = deviceType;
        }

        public Equipment(int equipmentID, string deviceType)
        {
            EquipmentID = equipmentID;
            DeviceType = deviceType;
        }

        public int EquipmentID { get; set; }
        public string DeviceType { get; set; }
    }
}
