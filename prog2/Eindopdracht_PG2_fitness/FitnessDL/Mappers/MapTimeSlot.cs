using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessBL.Models;
using FitnessDL.Models;


namespace FitnessDL.Mappers
{
    public static class MapTimeSlot
    {
        public static Time_Slot MapToBL(Time_SlotEF dl)
        {
			try
			{
				return new Time_Slot(
					dl.TimeSlotID,
					dl.StartTime,
					dl.EndTime,
					dl.PartOfDay					
					);

			}
			catch (Exception x)
			{

				throw new Exception("TimeSlot-MapToBL",x);
			}
        }

		public static Time_SlotEF MapToDL(Time_Slot bl) {


            try
            {
                return new Time_SlotEF(
                    bl.TimeSlotID,
                    bl.StartTime,
                    bl.EndTime,
                    bl.PartOfDay
                    );

            }
            catch (Exception x)
            {

                throw new Exception("TimeSlot-MapToDL", x);
            }

        }
    }
}
