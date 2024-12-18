using FitnessBL.Interfaces;
using FitnessBL.Models;
using FitnessDL.Mappers;
using FitnessDL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessDL.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {

        FitnessContext _context = new FitnessContext();

        public EquipmentRepository(FitnessContext context)
        {
            _context = context;
        }



        public List<Equipment> GetAll() {

            try
            {
                return _context.Equipment.Where(e=> e.InRepair == false).Select(e => MapEquipment.MapToBL(e)).ToList();
            }
            catch (Exception x)
            {

                throw new Exception("EquipmentRepository-GetAll", x);
            }
        
        
        
        
        }


        public Equipment Add(Equipment equipment)
        {
            try
            {
                _context.Equipment.Add(MapEquipment.MapToDL(equipment));
                _context.SaveChanges();

                return equipment;
            }
            catch (Exception x)
            {

                throw new Exception("EquipmentRepository-Add", x);
            }
        }

        public Equipment Repairing(int id)
        {
            try
            {
                EquipmentEF equipmentEF = _context.Equipment.Find(id);

                if (equipmentEF != null)
                {
                    EquipmentEF equipmentUpdated = new EquipmentEF();
                    equipmentUpdated.EquipmentID = id;
                    equipmentUpdated.DeviceType = equipmentEF.DeviceType;
                    equipmentUpdated.InRepair = !equipmentEF.InRepair;




                    if (equipmentUpdated.InRepair == true)
                    {
                        List<ReservationEF> reservations = new();

                        reservations = _context.Reservations.Where(r => r.EquipmentID == equipmentUpdated.EquipmentID).ToList();

                        _context.Reservations.RemoveRange(reservations); // range is om meerdere te verwijderen

                    }


                    _context.Entry(equipmentEF).CurrentValues.SetValues(equipmentUpdated); // entry is heel het rijtje in db
                    _context.SaveChanges();

                    return MapEquipment.MapToBL(equipmentEF);

                }
                else
                {
                    throw new Exception("Equipment niet gevonden");
                }




            }
            catch (Exception x)
            {

                throw new Exception("EquipmentRepository-Update", x);
            }
        }







    }
}
