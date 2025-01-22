using Eindopdracht_PG2_fitness.Controllers;
using FitnessBL.Interfaces;
using FitnessBL.Models;
using FitnessBL.Services;
using Moq;
using Xunit;

namespace Gym.Tests
{
    public class RunningSessionControllerUnitTests
    {
        private readonly Mock<IRunningSessionRepository> _mockRunningSessionRepository;
        private readonly RunningSessionService _runningSessionService;
        private readonly RunningSessionController _controller;

        public RunningSessionControllerUnitTests()
        {
            _mockRunningSessionRepository = new Mock<IRunningSessionRepository>(MockBehavior.Strict);

            _runningSessionService = new RunningSessionService(_mockRunningSessionRepository.Object);

            _controller = new RunningSessionController(_runningSessionService);
        }

        [Fact]
        public void Get_ShouldReturnRunningSession()
        {
            int sessionId = 1;
            var expectedRunningSession = new RunningSession_Main(
                sessionId,
                new DateTime(2025, 1, 22),
                123,
                new TimeSpan(1, 30, 0),
                10.5f,
                new RunningSession_Detail()
            );

            _mockRunningSessionRepository
                .Setup(repo => repo.Get(sessionId))
                .Returns(expectedRunningSession);

            var result = _controller.Get(sessionId);

            Assert.NotNull(result);
            Assert.Equal(expectedRunningSession.RunningSessionID, result.RunningSessionID);
            Assert.Equal(expectedRunningSession.Date, result.Date);
            Assert.Equal(expectedRunningSession.MemberID, result.MemberID);
            Assert.Equal(expectedRunningSession.Duration, result.Duration);
            Assert.Equal(expectedRunningSession.AvgSpeed, result.AvgSpeed);
            Assert.Equal(expectedRunningSession.RunningSession_Details, result.RunningSession_Details);

            _mockRunningSessionRepository.Verify(repo => repo.Get(sessionId), Times.Once);
        }
    }
}
