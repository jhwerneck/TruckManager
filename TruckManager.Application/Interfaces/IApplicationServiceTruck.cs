using System;
using System.Collections.Generic;
using TruckManager.Application.Dtos;

namespace TruckManager.Application.Interfaces
{
    public interface IApplicationServiceTruck
    {
        void Add(TruckDto truckDto);
        void Update(TruckDto truckDto);
        void Remove(TruckDto truckDto);
        IEnumerable<TruckDto> GetAll();
        TruckDto GetById(Guid id);
    }
}
