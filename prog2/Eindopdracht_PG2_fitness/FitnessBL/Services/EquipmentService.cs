using FitnessBL.Interfaces;
using FitnessBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Services
{
    public class EquipmentService
    {
        IEquipmentRepository _equipmentRepository;

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {

            _equipmentRepository = equipmentRepository;
        }

        public Equipment Add(Equipment equipment)
        {

            try
            {
                return _equipmentRepository.Add(equipment);

            }
            catch (Exception x)
            {

                throw new Exception("EquipmentService-Add", x);
            }


        }

        public Equipment Repairing(int id)
        {

            try
            {
                return _equipmentRepository.Repairing(id);

            }
            catch (Exception x)
            {

                throw new Exception("EquipmentService-Repairing", x);
            }


        }


    }
}
