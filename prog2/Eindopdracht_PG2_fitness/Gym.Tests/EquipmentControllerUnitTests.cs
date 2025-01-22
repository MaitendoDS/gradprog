using Eindopdracht_PG2_fitness.Controllers;
using Eindopdracht_PG2_fitness.DTO;
using FitnessBL.Interfaces;
using FitnessBL.Models;
using FitnessBL.Services;
using Moq;
using Xunit;

namespace Gym.Tests
{
    public class EquipmentControllerUnitTests
    {
        private readonly Mock<IEquipmentRepository> _mockEquipmentRepository;
        private readonly EquipmentService _equipmentService;
        private readonly EquipmentController _controller;

        public EquipmentControllerUnitTests()
        {
            _mockEquipmentRepository = new Mock<IEquipmentRepository>(MockBehavior.Strict);

            _equipmentService = new EquipmentService(_mockEquipmentRepository.Object);

            _controller = new EquipmentController(_equipmentService);
        }

        [Fact]
        public void Add_ShouldReturnAddedEquipment()
        {
            var equipmentDto = new EquipmentDTO
            {
                DeviceType = "Treadmill",
                InRepair = false
            };

            var expectedEquipment = new Equipment
            {
                EquipmentID = 1,
                DeviceType = "Treadmill",
                InRepair = false
            };

            _mockEquipmentRepository
                .Setup(repo => repo.Add(It.IsAny<Equipment>()))
                .Returns(expectedEquipment);

            var result = _controller.Add(equipmentDto);

            Assert.NotNull(result);
            Assert.Equal(expectedEquipment.EquipmentID, result.EquipmentID);
            Assert.Equal(expectedEquipment.DeviceType, result.DeviceType);
            Assert.Equal(expectedEquipment.InRepair, result.InRepair);

            _mockEquipmentRepository.Verify(repo => repo.Add(It.IsAny<Equipment>()), Times.Once);
        }
    }
}
