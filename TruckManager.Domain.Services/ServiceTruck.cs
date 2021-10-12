using TruckManager.Domain.Core.Interfaces.Repositories;
using TruckManager.Domain.Core.Interfaces.Services;
using TruckManager.Domain.Entities;


namespace TruckManager.Domain.Services
{
    public class ServiceTruck : ServiceBase<Truck>, IServiceTruck
    {
        private readonly IRepositoryTruck repositoryTruck;

        public ServiceTruck(IRepositoryTruck repositoryTruck) : base(repositoryTruck)
        {
            this.repositoryTruck = repositoryTruck;
        }
    }
}
