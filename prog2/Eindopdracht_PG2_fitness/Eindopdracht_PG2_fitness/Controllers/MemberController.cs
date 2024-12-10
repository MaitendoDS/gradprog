using FitnessBL.Services;
using Microsoft.AspNetCore.Mvc;
using FitnessBL.Models;
using Eindopdracht_PG2_fitness.DTO;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eindopdracht_PG2_fitness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        MemberService _memberService;
        public MemberController(MemberService memberService)
        {
            _memberService = memberService;
        }

        [Route("GetMemberById/{id}")]
        [HttpGet]

        public Member GetMember(int id)
        {
            return _memberService.GetMember(id);
        }


        [Route("GetAll")]
        [HttpGet]

        public List<Member> GetAll()
        {
            return _memberService.GetAll();
        }


        [Route("Update/{id}")]
        [HttpPut]

        public Member Update(int id,[FromBody] MemberDTO memberDTO)
        {
            Member member = new Member(
                id,
                memberDTO.FirstName,
                memberDTO.LastName,
                memberDTO.Email,
                memberDTO.Adress,
                memberDTO.Birthday,
                memberDTO.Interests,
                memberDTO.MemberType
                );

            return _memberService.Update(member);
        }




        [Route("Add")]
        [HttpPost]

        public Member Add([FromBody]MemberDTO memberDTO)
        {
            Member member = new Member(
                0,
                memberDTO.FirstName,
                memberDTO.LastName,
                memberDTO.Email,
                memberDTO.Adress,
                memberDTO.Birthday,
                memberDTO.Interests,
                memberDTO.MemberType
                );

          return  _memberService.Add(member);
        }

        [Route("Delete/{id}")]
        [HttpDelete]

        public bool Delete(int id) { 
        
            return _memberService.Delete(id);

        }


        

    }
}
