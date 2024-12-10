using FitnessBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessBL.Models;

namespace FitnessBL.Services
{
    public class MemberService
    {
        private IMemberRepository memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        public List<Member> GetAll()
        {
            try
            {
                return memberRepository.GetAll();
            }
            catch (Exception x)
            {

                throw new Exception("MemberService-GetAll",x);
            }           
        }

        public Member GetMember(int id)
        {
            try
            {
                return memberRepository.GetMember(id);
            }
            catch (Exception x)
            {

                throw new Exception("MemberService-GetMember", x);
            }
        }
        public bool Delete(int id)
        {
            try
            {
              memberRepository.Delete(id);

                return true;
            }
            catch (Exception x)
            {

                throw new Exception("MemberService-Delete", x);
            }
        }
        public Member Add(Member member)
        {
            try
            {
                if (member == null)
                {
                    throw new Exception("Member is null");
                }            

                return memberRepository.Add(member);


            }
            catch (Exception x)
            {

                throw new Exception("MemberService-Add", x);
            }
        }

        public Member Update(Member member)
        {
            try
            {
                if (member == null)
                {
                    throw new Exception("Member is null");
                }

                return memberRepository.Update(member);


            }
            catch (Exception x)
            {

                throw new Exception("MemberService-Update", x);
            }
        }



    }
}
