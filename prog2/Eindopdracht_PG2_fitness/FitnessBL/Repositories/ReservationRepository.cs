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

            // Add a new reservation
            public async Task AddReservation(Reservation reservation)
            {
                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();
            }

            // Get a reservation by ID, including related entities
            public async Task<Reservation> GetReservation(int id)
            {
                return await _context.Reservations
                    .Include(r => r.Equipment) // Include Equipment details
                    .Include(r => r.TimeSlot) // Include TimeSlot details
                    .Include(r => r.Member)   // Include Member details
                    .FirstOrDefaultAsync(r => r.ReservationID == id);
            }

            // Get all reservations for a specific member
            public async Task<List<Reservation>> GetReservationsByMember(int memberId)
            {
                return await _context.Reservations
                    .Where(r => r.MemberID == memberId)
                    .Include(r => r.Equipment)
                    .Include(r => r.TimeSlot)
                    .ToListAsync();
            }

            // Update an existing reservation
            public async Task UpdateReservation(Reservation reservation)
            {
                _context.Reservations.Update(reservation);
                await _context.SaveChangesAsync();
            }

            // Delete a reservation by ID
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

