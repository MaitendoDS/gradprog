using FitnessDL.Models;
using FitnessDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessBL.Repositories
{

        public class ReservationRepository
        {
            private readonly FitnessContext _context;

            public ReservationRepository(FitnessContext context)
            {
                _context = context;
            }

            public async Task AddReservation(Reservation reservation)
            {
                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();
            }

            public async Task<Reservation> GetReservation(int id)
            {
                return await _context.Reservations
                    .Include(r => r.Equipment) 
                    .Include(r => r.TimeSlot)
                    .Include(r => r.Member)   
                    .FirstOrDefaultAsync(r => r.ReservationID == id);
            }

       
            public async Task<List<Reservation>> GetReservationsByMember(int memberId)
            {
                return await _context.Reservations
                    .Where(r => r.MemberID == memberId)
                    .Include(r => r.Equipment)
                    .Include(r => r.TimeSlot)
                    .ToListAsync();
            }

           
            public async Task UpdateReservation(Reservation reservation)
            {
                _context.Reservations.Update(reservation);
                await _context.SaveChangesAsync();
            }

            public async Task DeleteReservation(int id)
            {
                var reservation = await _context.Reservations.FindAsync(id);
                if (reservation != null)
                {
                    _context.Reservations.Remove(reservation);
                    await _context.SaveChangesAsync();
                }
            }
        }

    }

