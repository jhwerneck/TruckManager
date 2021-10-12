using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using AutoMapper;
using Moq;
using NUnit.Framework;
using TruckManager.Application;
using TruckManager.Application.Dtos;
using TruckManager.Domain.Core.Interfaces.Services;
using TruckManager.Domain.Entities;
using TruckManager.Application.Interfaces.Mappers;
using System;

namespace TruckManager.Tests
{
    [TestFixture]
    public class ApplicationServiceTruckTests
    {
        private static Fixture _fixture;
        private Mock<IServiceTruck> _servicetruckMock;
        private Mock<IMapperTruck> _mapperMock;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
            _servicetruckMock = new Mock<IServiceTruck>();
            _mapperMock = new Mock<IMapperTruck>();
        }

        [Test]
        public void ApplicationServicetruck_GetAll_ShouldReturnFiveClients()
        {
            //Arrange
            var trucks = _fixture.Build<Truck>().CreateMany(5);

            _servicetruckMock.Setup(x => x.GetAll()).Returns(trucks);
            _mapperMock.Setup(x => x.MapperListTruckDto(trucks));

            var applicationServicetruck = new ApplicationServiceTruck(_servicetruckMock.Object, _mapperMock.Object);

            //Act
            var result = applicationServicetruck.GetAll();

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
            _servicetruckMock.VerifyAll();
            _mapperMock.VerifyAll();
        }

        [Test]
        public void ApplicationServicetruck_GetById_ShouldReturnClient()
        {
            //Arrange
            var id = Guid.NewGuid();

            var truck = _fixture.Build<Truck>()
                .With(c => c.Id, id)
                .With(c => c.TruckModel, "FM")
                .With(c => c.YearModel, 123)
                .Create();

            var truckDto = _fixture.Build<TruckDto>()
                .With(c => c.Id, id)
                .With(c => c.TruckModel, "FM")
                .With(c => c.YearModel, 123)
                .Create();

            _servicetruckMock.Setup(x => x.GetById(It.IsAny<Guid>())).Returns(truck);
            _mapperMock.Setup(x => x.MapperDtoToEntity(It.IsAny<TruckDto>())).Returns(truck);

            var applicationServicetruck =
                new ApplicationServiceTruck(_servicetruckMock.Object, _mapperMock.Object);

            //Act
            var result = applicationServicetruck.GetById(id);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(123, result.YearModel);
            Assert.AreEqual(id, result.Id);
            _servicetruckMock.VerifyAll();
            _mapperMock.VerifyAll();
        }
    }
}
