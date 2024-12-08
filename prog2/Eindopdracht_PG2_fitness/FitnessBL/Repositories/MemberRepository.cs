using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using FitnessDL;
using FitnessDL.Models;

namespace FitnessBL.Repositories
{
    public class MemberRepository
    {
        private readonly FitnessContext _context;

        public MemberRepository(FitnessContext context)
        {
            _context = context;
        }

        // Create
        public async Task AddMember(Member member)
        {
            _context.Members.Add(member);
            await _context.SaveChangesAsync();
        }

        // Read
        public async Task<Member> GetMember(int id)
        {
            return await _context.Members.FindAsync(id);
        }

        // Update
        public async Task UpdateMember(Member member)
        {
            _context.Members.Update(member);
            await _context.SaveChangesAsync();
        }

        // Delete
        public async Task DeleteMember(int id)
        {
            var member = await _context.Members.FindAsync(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                await _context.SaveChangesAsync();
            }
        }
    }
}
