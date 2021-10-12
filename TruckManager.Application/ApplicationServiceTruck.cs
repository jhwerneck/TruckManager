using System;
using System.Collections.Generic;
using TruckManager.Application.Dtos;
using TruckManager.Application.Interfaces;
using TruckManager.Application.Interfaces.Mappers;
using TruckManager.Domain.Core.Interfaces.Services;

namespace TruckManager.Application
{
    public class ApplicationServiceTruck : IApplicationServiceTruck
    {
        private readonly IServiceTruck serviceTruck;
        private readonly IMapperTruck mapperTruck;

        public ApplicationServiceTruck(IServiceTruck serviceTruck, IMapperTruck mapperTruck)
        {
            this.serviceTruck = serviceTruck;
            this.mapperTruck = mapperTruck;
        }
        public void Add(TruckDto truckDto)
        {
            var truck = mapperTruck.MapperDtoToEntity(truckDto);
            serviceTruck.Add(truck);
        }

        public IEnumerable<TruckDto> GetAll()
        {
            var trucks = serviceTruck.GetAll();
            return mapperTruck.MapperListTruckDto(trucks);
        }

        public TruckDto GetById(Guid id)
        {
            var truck = serviceTruck.GetById(id);
            return mapperTruck.MapperEntityToDto(truck);
        }

        public void Remove(TruckDto truckDto)
        {
            var truck = mapperTruck.MapperDtoToEntity(truckDto);
            serviceTruck.Remove(truck);
        }

        public void Update(TruckDto truckDto)
        {
            var truck = mapperTruck.MapperDtoToEntity(truckDto);
            serviceTruck.Update(truck);
        }
    }


}
