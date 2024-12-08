using System.ComponentModel.DataAnnotations;

namespace FitnessDL.Models
{
    public class Equipment
    {
        public Equipment()
        {
        }

        public int EquipmentID { get; set; }
        public string DeviceType { get; set; }
    }
}
