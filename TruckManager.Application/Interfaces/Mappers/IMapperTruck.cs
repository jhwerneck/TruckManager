
using System.Collections.Generic;
using TruckManager.Application.Dtos;
using TruckManager.Domain.Entities;

namespace TruckManager.Application.Interfaces.Mappers
{
    public interface IMapperTruck
    {
        Truck MapperDtoToEntity(TruckDto truckDto);
        IEnumerable<TruckDto> MapperListTruckDto(IEnumerable<Truck> trucks);
        TruckDto MapperEntityToDto(Truck truck);
    }
}
