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


        [Route("GetAllSessionsByMonthAndYear/{id}")]
        [HttpGet]

        public SessionsDTO GetAllSessions(int id, int month, int year)
        {

            SessionsDTO sessionsDTO = new SessionsDTO();
            Member member = _memberService.GetMember(id);

            sessionsDTO.CyclingSession = (List<CyclingSession>)member.CyclingSessions.Where(s => s.Date.Month == month && s.Date.Year == year).OrderBy(s => s.Date).ToList();
            sessionsDTO.RunningSession_Main = (List<RunningSession_Main>)member.RunningSessions.Where(s => s.Date.Month == month && s.Date.Year == year).OrderBy(s => s.Date).ToList();

            return sessionsDTO;
        }

        [Route("GetSessionDetails/{id}")]
        [HttpGet]

        public SessionDetailsDTO GetSessionDetails(int id)
        {
            SessionDetailsDTO sessionDetailsDTO = new SessionDetailsDTO();
            Member member = _memberService.GetMember(id);
            List<CyclingSession> cyclingSessions = (List<CyclingSession>)member.CyclingSessions;
            List<RunningSession_Main> runningSessions = (List<RunningSession_Main>)member.RunningSessions;

            long totalTicks = 0;


            sessionDetailsDTO.SessionsCount = member.RunningSessions.Count + member.CyclingSessions.Count;

            for (int i = 0; i < member.RunningSessions.Count; i++)
            {
                totalTicks += runningSessions[i].Duration.Ticks;
            }
            for (int i = 0; i < member.CyclingSessions.Count; i++)
            {
                totalTicks += cyclingSessions[i].Duration.Ticks;
            }

            sessionDetailsDTO.Tijdsduur = new TimeSpan(totalTicks);

            long avgTicks = totalTicks / sessionDetailsDTO.SessionsCount;

            sessionDetailsDTO.GemiddeldeTijdsduur = new TimeSpan(avgTicks);


            CyclingSession kortsteCyclingSession = new CyclingSession();
            CyclingSession langsteCyclingSession = new CyclingSession();

            RunningSession_Main kortsteRunningSession = new RunningSession_Main();
            RunningSession_Main langsteRunningSession = new RunningSession_Main();


            kortsteCyclingSession = member.CyclingSessions.OrderBy(s => s.Duration).FirstOrDefault();
            langsteCyclingSession = member.CyclingSessions.OrderByDescending(s => s.Duration).FirstOrDefault();

            kortsteRunningSession = member.RunningSessions.OrderBy(s => s.Duration).FirstOrDefault();
            langsteRunningSession = member.RunningSessions.OrderByDescending(s => s.Duration).FirstOrDefault();

            if (kortsteCyclingSession.Duration < kortsteRunningSession.Duration)
            {
                sessionDetailsDTO.KortsteSessie = kortsteCyclingSession;
            }
            else
            {
                sessionDetailsDTO.KortsteSessie = kortsteRunningSession;
            }

            if (langsteCyclingSession.Duration > langsteRunningSession.Duration)
            {
                sessionDetailsDTO.LangsteSessie = langsteCyclingSession;
            }
            else
            {
                sessionDetailsDTO.LangsteSessie = langsteRunningSession;
            }

            return sessionDetailsDTO;


        }


        [Route("GetSummary{id}")]
        [HttpGet]


        public List<SummaryDTO> GetSummary(int id, int year)
        {
            Member member = _memberService.GetMember(id);

            List<SummaryDTO> summaryList = new List<SummaryDTO>();

            for (int i = 1; i <= 12; i++)
            {
                SummaryDTO summaryDTO = new SummaryDTO();
                summaryDTO.SessionsCount = member.RunningSessions.Where(s => s.Date.Month == i && s.Date.Year == year).Count() + member.CyclingSessions.Where(s => s.Date.Month == i && s.Date.Year == year).Count();


                summaryDTO.Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                summaryList.Add(summaryDTO);
            }
            return summaryList;


        }

        [Route("GetSummaryTrainingType/{id}")]
        [HttpGet]

        public List<SummaryTrainingsTypeDTO> GetSummaryTrainingType(int id, int year)
        {

            Member member = _memberService.GetMember(id);

            List<SummaryTrainingsTypeDTO> summaryTrainingsTypeList = new List<SummaryTrainingsTypeDTO>();

            List<CyclingSession> cyclingSessions = (List<CyclingSession>)member.CyclingSessions;


            for (int i = 1; i <= 12; i++)
            {
                SummaryTrainingsTypeDTO summaryTrainingsTypeDTO = new SummaryTrainingsTypeDTO();
                summaryTrainingsTypeDTO.RunningSessionsCount = member.RunningSessions.Where(s => s.Date.Month == i && s.Date.Year == year).Count();
                summaryTrainingsTypeDTO.CyclingSessionsCount = member.CyclingSessions.Where(s => s.Date.Month == i && s.Date.Year == year).Count();

                int funCounter = 0;
                int enduranceCounter = 0;
                int intervalCounter = 0;
                int recoveryCounter = 0;

                for (int j = 0; j < cyclingSessions.Count; j++)
                {
                    if (cyclingSessions[j].Date.Month == i && cyclingSessions[j].Date.Year == year)
                    {

                        if (cyclingSessions[j].TrainingType.ToLower() == "fun")
                        {
                            funCounter++;

                        }
                        else if (cyclingSessions[j].TrainingType.ToLower() == "endurance")
                        {
                            enduranceCounter++;
                        }
                        else if (cyclingSessions[j].TrainingType.ToLower() == "interval")
                        {
                            intervalCounter++;
                        }
                        else if (cyclingSessions[j].TrainingType.ToLower() == "recovery")
                        {
                            recoveryCounter++;
                        }
                    }
                }
                summaryTrainingsTypeDTO.FunTypeCounter = funCounter;
                summaryTrainingsTypeDTO.EnduranceTypeCounter = enduranceCounter;
                summaryTrainingsTypeDTO.IntervalTypeCounter = intervalCounter;
                summaryTrainingsTypeDTO.RecoveryTypeCounter = recoveryCounter;

                summaryTrainingsTypeDTO.Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                summaryTrainingsTypeList.Add(summaryTrainingsTypeDTO);
            }
            return summaryTrainingsTypeList;

        }


        [Route("GetTrainingsImpact/{id}")]
        [HttpGet]

        public List<TrainingsImpactMonthlyDTO> GetTrainingsImpact(int id, int year)
        {
            Member member = _memberService.GetMember(id);
            List<CyclingSession> cyclingSessions = (List<CyclingSession>)member.CyclingSessions;
            List<TrainingsImpactMonthlyDTO> trainingsImpactMonthlyDTOList = new();


            for (int i = 1; i <= 12; i++)
            {
                TrainingsImpactMonthlyDTO trainingsImpactMonthly = new TrainingsImpactMonthlyDTO();
                List<TrainingsImpactDTO> trainingsImpactList = new List<TrainingsImpactDTO>();

                for (int j = 0; j < member.CyclingSessions.Count; j++)
                {
                    if (cyclingSessions[j].Date.Month == i)
                    {
                        TrainingsImpactDTO trainingsImpact = new();


                        trainingsImpact.CyclingSessionID = cyclingSessions[j].CyclingSessionID;
                        trainingsImpact.MaxCadence = cyclingSessions[j].MaxCadence;
                        trainingsImpact.AvgCadence = cyclingSessions[j].AvgCadence;
                        trainingsImpact.Comment = cyclingSessions[j].Comment;
                        trainingsImpact.MemberID = cyclingSessions[j].MemberID;
                        trainingsImpact.AvgWatt = cyclingSessions[j].AvgWatt;
                        trainingsImpact.Date = cyclingSessions[j].Date;
                        trainingsImpact.Duration = cyclingSessions[j].Duration;
                        trainingsImpact.MaxWatt = cyclingSessions[j].MaxWatt;
                        trainingsImpact.TrainingType = cyclingSessions[j].TrainingType;

                        TimeSpan timeSpan = new TimeSpan(1, 30, 0);


                        if (trainingsImpact.AvgWatt < 150 && trainingsImpact.Duration < timeSpan)
                        {
                            trainingsImpact.TrainingsImpact = "Laag";
                        }
                        else if (trainingsImpact.AvgWatt > 150 && trainingsImpact.AvgWatt < 200 && trainingsImpact.Duration > timeSpan)
                        {
                            trainingsImpact.TrainingsImpact = "Medium";
                        }
                        else
                        {
                            trainingsImpact.TrainingsImpact = "High";
                        }

                        trainingsImpactList.Add(trainingsImpact);
                    }
                }
                trainingsImpactMonthly.Month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                trainingsImpactMonthly.Sessions = trainingsImpactList;

                trainingsImpactMonthlyDTOList.Add(trainingsImpactMonthly);
            }
            return trainingsImpactMonthlyDTOList;
        }






        [Route("Update/{id}")]
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




        [Route("Add")]
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

        [Route("Delete/{id}")]
        [HttpDelete]

        public bool Delete(int id)
        {

            return _memberService.Delete(id);

        }




    }
}
