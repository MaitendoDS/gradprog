using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessBL.Models;
using FitnessDL.Mappers;
using Microsoft.EntityFrameworkCore;
using FitnessDL.Models;
using FitnessBL.Interfaces;


namespace FitnessDL.Repositories
{
    public class MemberRepository: IMemberRepository
    {

        private FitnessContext _context;
        public MemberRepository(FitnessContext context)
        {
            _context = context;
        }
        private void SaveAndClear()
        {
            _context.SaveChanges();
            _context.ChangeTracker.Clear();
        }

        public Member GetMember(int id)
        {

            try
            {

                var member = _context.Members
                    .Include(m => m.CyclingSessions)
                    .Include(m => m.Programmas)
                    .Include(m => m.RunningSessions)
                    .Include(m => m.Reservations)
                    .FirstOrDefault(m => m.MemberID==id);


                return member != null ? MapMember.MapToBL(member) : throw new Exception("Member is null");
            }
            catch (Exception x)
            {

                throw new Exception("MemberRepository-GetMember", x);
            }
        }

        public List<Member> GetAll()
        {

            try
            {

                return _context.Members
                    .Include(m => m.CyclingSessions)
                    .Include(m => m.Programmas)
                    .Include(m => m.RunningSessions)
                    .Include(m => m.Reservations)
                    .Select(m => MapMember.MapToBL(m)).ToList();


                
            }
            catch (Exception x)
            {

                throw new Exception("MemberRepository-GetAll", x);
            }
        }
        public bool Delete(int id)
        {

            try
            {
                MemberEF member = new MemberEF(); // zodat ef naar memberID kan kijken en dan de member met dezlfde id vverwijderen
                member.MemberID = id;
                _context.Remove(member);

                _context.SaveChanges();

                return true;
                
            }
            catch (Exception x)
            {

                throw new Exception("MemberRepository-Delete", x);
            }
        }
        public Member Update(Member member)
        {

            try
            {
                MemberEF memberEF = _context.Members.Find(member.MemberID);

                if (memberEF != null)
                {
                    _context.Entry(memberEF).CurrentValues.SetValues(MapMember.MapToDL(member));
                    _context.SaveChanges();

                    return MapMember.MapToBL(memberEF);

                }
                else
                {
                    throw new Exception("Member niet gevonden");
                }

            }
            catch (Exception x)
            {

                throw new Exception("MemberRepository-Update", x);
            }
        }

        public Member Add(Member member)
        {

            try
            {
                var memberEF = MapMember.MapToDL(member);
                _context.Members.Add(memberEF);
                _context.SaveChanges();

                return MapMember.MapToBL(memberEF);
            }
            catch (Exception x)
            {

                throw new Exception("MemberRepository-Add", x);
            }
        }

    }
}
