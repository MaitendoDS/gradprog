using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessBL.Models;

namespace FitnessBL.Interfaces
{
    public interface IMemberRepository
    {
        Member GetMember(int id);
        List<Member> GetAll();
        Member Update(Member member);
        bool Delete(int id);
        Member Add(Member member);

    }
}
