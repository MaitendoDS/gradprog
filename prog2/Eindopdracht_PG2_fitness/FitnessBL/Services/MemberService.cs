using FitnessBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessBL.Models;
using FitnessBL.DTO;
using System.Globalization;

namespace FitnessBL.Services
{
    public class MemberService
    {
        private IMemberRepository memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository;
        }

        public List<TrainingsImpactMonthlyDTO> GetTrainingsImpact(int id, int year)
        {
            Member member = GetMember(id);
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

        public List<SummaryTrainingsTypeDTO> GetSummaryTrainingType(int id, int year)
        {

            Member member = GetMember(id);

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

        public List<SummaryDTO> GetSummary(int id, int year)
        {
            Member member = GetMember(id);

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


        public SessionsDTO GetAllSessions(int id, int month, int year)
        {
            SessionsDTO sessionsDTO = new SessionsDTO();
            Member member = GetMember(id);

            sessionsDTO.CyclingSession = (List<CyclingSession>)member.CyclingSessions.Where(s => s.Date.Month == month && s.Date.Year == year).OrderBy(s => s.Date).ToList();
            sessionsDTO.RunningSession_Main = (List<RunningSession_Main>)member.RunningSessions.Where(s => s.Date.Month == month && s.Date.Year == year).OrderBy(s => s.Date).ToList();
            return sessionsDTO;
        }

        public SessionDetailsDTO GetSessionDetails(int id)
        {
            SessionDetailsDTO sessionDetailsDTO = new SessionDetailsDTO();
            Member member = GetMember(id);
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
