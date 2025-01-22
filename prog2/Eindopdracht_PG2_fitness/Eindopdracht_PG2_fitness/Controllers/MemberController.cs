using FitnessBL.Services;
using Microsoft.AspNetCore.Mvc;
using FitnessBL.Models;
using Eindopdracht_PG2_fitness.DTO;
using System.Globalization;


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

        [Route("{id}")]
        [HttpGet]

        public Member GetMember(int id)
        {
            return _memberService.GetMember(id);
        }

        [HttpGet]
        public List<Member> GetAll()
        {
            return _memberService.GetAll();
        }


        [Route("SessionsByMonthAndYear/{id}")]
        [HttpGet]

        public IActionResult GetAllSessions(int id, int month, int year)
        {

            try
            {
            return Ok(_memberService.GetAllSessions(id, month, year));

            }
            catch (Exception x)
            {

                return BadRequest(new { message = x.Message });
            }
        }

        [Route("SessionDetails/{id}")]
        [HttpGet]

        public IActionResult GetSessionDetails(int id)
        {
            try
            {
                return Ok(_memberService.GetSessionDetails(id));
            }
            catch (Exception x)
            {
                return BadRequest(new { message = x.Message });
            }

        }

        [Route("Summary{id}")]
        [HttpGet]


        public IActionResult GetSummary(int id, int year)
        {
            try
            {
                return Ok(_memberService.GetSummary(id, year));
            }
            catch (Exception x)
            {
                return BadRequest(new { message = x.Message });
            }

        }

        [Route("SummaryTrainingType/{id}")]
        [HttpGet]

        public IActionResult GetSummaryTrainingType(int id, int year)
        {
            try
            {
                return Ok(_memberService.GetSummaryTrainingType(id, year));
            }
            catch (Exception x)
            {
                return BadRequest(new { message = x.Message });
            }
        }


        [Route("TrainingsImpact/{id}")]
        [HttpGet]

        public IActionResult GetTrainingsImpact(int id, int year)
        {
            try
            {
                return Ok(_memberService.GetTrainingsImpact(id, year));
            }
            catch (Exception x)
            {
                return BadRequest(new { message = x.Message });
            }
        }



        [Route("{id}")]
        [HttpPut]

        public Member Update(int id, [FromBody] MemberDTO memberDTO)
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

        [HttpPost]

        public Member Add([FromBody] MemberDTO memberDTO)
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

            return _memberService.Add(member);
        }

        [Route("{id}")]
        [HttpDelete]

        public bool Delete(int id)
        {

            return _memberService.Delete(id);

        }




    }
}
