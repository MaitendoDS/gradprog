using Eindopdracht_PG2_fitness.Controllers;
using Eindopdracht_PG2_fitness.DTO;
using FitnessBL.Interfaces;
using FitnessBL.Models;
using FitnessBL.Services;
using Moq;
using Xunit;

namespace Gym.Tests
{
    public class ProgrammaControllerUnitTests
    {
        private readonly Mock<IProgrammaRepository> _mockProgrammaRepository;
        private readonly ProgrammaService _programmaService;
        private readonly ProgrammaController _controller;

        public ProgrammaControllerUnitTests()
        {
            
            _mockProgrammaRepository = new Mock<IProgrammaRepository>(MockBehavior.Strict);

       
            _programmaService = new ProgrammaService(_mockProgrammaRepository.Object);

            _controller = new ProgrammaController(_programmaService);
        }

        [Fact]
        public void Add_ShouldReturnAddedProgramma()
        {
          
            var programmaDto = new ProgrammaDTO
            {
                Name = "Fitness Program",
                Target = "Weight Loss",
                StartDate = new DateTime(2025, 2, 1),
                MaxMembers = 20
            };

            var expectedProgramma = new Programma(
                "P001",
                "Fitness Program",
                "Weight Loss",
                new DateTime(2025, 2, 1),
                20
            );

            _mockProgrammaRepository
                .Setup(repo => repo.Add(It.IsAny<Programma>()))
                .Returns(expectedProgramma);

            var result = _controller.Add(programmaDto);

            Assert.NotNull(result);
            Assert.Equal(expectedProgramma.ProgramCode, result.ProgramCode);
            Assert.Equal(expectedProgramma.Name, result.Name);
            Assert.Equal(expectedProgramma.Target, result.Target);
            Assert.Equal(expectedProgramma.StartDate, result.StartDate);
            Assert.Equal(expectedProgramma.MaxMembers, result.MaxMembers);

      
            _mockProgrammaRepository.Verify(repo => repo.Add(It.IsAny<Programma>()), Times.Once);
        }

        [Fact]
        public void Update_ShouldReturnUpdatedProgramma()
        {
           
            var programmaDto = new ProgrammaDTO
            {
                Name = "Updated Fitness Program",
                Target = "Muscle Gain",
                StartDate = new DateTime(2025, 3, 1),
                MaxMembers = 25
            };

            var expectedProgramma = new Programma(
                "P001",
                "Updated Fitness Program",
                "Muscle Gain",
                new DateTime(2025, 3, 1),
                25
            );

            _mockProgrammaRepository
                .Setup(repo => repo.Update(It.IsAny<Programma>()))
                .Returns(expectedProgramma);

            var result = _controller.Update("P001", programmaDto);

            Assert.NotNull(result);
            Assert.Equal(expectedProgramma.ProgramCode, result.ProgramCode);
            Assert.Equal(expectedProgramma.Name, result.Name);
            Assert.Equal(expectedProgramma.Target, result.Target);
            Assert.Equal(expectedProgramma.StartDate, result.StartDate);
            Assert.Equal(expectedProgramma.MaxMembers, result.MaxMembers);

            _mockProgrammaRepository.Verify(repo => repo.Update(It.IsAny<Programma>()), Times.Once);
        }
    }
}
