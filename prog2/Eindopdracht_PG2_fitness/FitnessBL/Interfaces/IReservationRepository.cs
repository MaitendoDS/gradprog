using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Interfaces
{
    public interface IReservationRepository
    {


        public Reservation Add(Reservation reservation);
        public Reservation Update(Reservation reservation);
        public bool Delete(int id);

    }
}
