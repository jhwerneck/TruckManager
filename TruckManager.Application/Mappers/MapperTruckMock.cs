using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using TruckManager.Application.Dtos;
using TruckManager.Domain.Entities;

namespace TruckManager.Application.Mappers
{
    public class MapperTruckMock : Profile
    {
        IEnumerable<TruckDto> truckDto = new List<TruckDto>();

        public Truck MapperDtoToEntity(TruckDto truckDto)
        {
            var truck = new Truck()
            {
                Id = truckDto.Id,
                TruckModel = truckDto.TruckModel,
                YearManufactured = truckDto.YearManufactured,
                YearModel = truckDto.YearModel
            };
            return truck;
        }

        public TruckDto MapperEntityToDto(Truck truck)
        {
            var truckDto = new TruckDto()
            {
                Id = truck.Id,
                TruckModel = truck.TruckModel,
                YearManufactured = truck.YearManufactured,
                YearModel = truck.YearModel
            };

            return truckDto;
        }

        public IEnumerable<TruckDto> MapperListTruckDto(IEnumerable<Truck> trucks)
        {
            var dto = trucks.Select(c => new TruckDto { Id = c.Id, TruckModel = c.TruckModel, YearManufactured = c.YearManufactured, YearModel = c.YearModel });
            return dto;
        }
    }
}
