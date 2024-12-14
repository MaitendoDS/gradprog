using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Interfaces
{
    public interface IEquipmentRepository
    {
        public Equipment Add(Equipment equipment);
        public Equipment Repairing(int id);



    }
}
