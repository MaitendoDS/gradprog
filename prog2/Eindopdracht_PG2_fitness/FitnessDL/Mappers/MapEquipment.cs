using FitnessBL.Models;
using FitnessDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Mappers
{
    public static class MapEquipment
    {
        public static Equipment MapToBL(EquipmentEF dl)
        {
			try
			{
				return new Equipment(
					dl.EquipmentID,
					dl.DeviceType,
					dl.InRepair
					
					);
			}
			catch (Exception x)
			{

				throw new Exception("MapEquipment-MapToBL",x);
			}

        }

        public static EquipmentEF MapToDL(Equipment bl)
        {
            try
            {
                return new EquipmentEF(
                    bl.EquipmentID,
                    bl.DeviceType,
                    bl.InRepair

                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapEquipment-MapToDL", x);
            }

        }


    }
}
