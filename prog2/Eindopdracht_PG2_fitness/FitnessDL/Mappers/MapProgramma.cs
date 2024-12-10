using FitnessBL.Models;
using FitnessDL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Mappers
{
    public static class MapProgramma
    {
        public static Programma MapToBL(ProgrammaEF dl)
        {
			try
			{
				return new Programma(
					dl.ProgramCode,
					dl.Name,
					dl.Target,
					dl.StartDate,
					dl.MaxMembers
					);
			}
			catch (Exception x)
			{

				throw new Exception("MapProgramma-MapToBL",x);
			}


        }

        public static ProgrammaEF MapToDL(Programma bl)
        {
            try
            {
                return new ProgrammaEF(
                    bl.ProgramCode,
                    bl.Name,
                    bl.Target,
                    bl.StartDate,
                    bl.MaxMembers
                    );
            }
            catch (Exception x)
            {

                throw new Exception("MapProgramma-MapToDL", x);
            }


        }



    }
}
