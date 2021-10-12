
using TruckManager.Domain.Core.Interfaces.Repositories;
using TruckManager.Domain.Entities;

namespace TruckManager.Infrastructure.Data.Repositories
{
    public class RepositoryTruck : RepositoryBase<Truck>, IRepositoryTruck
    {
        private readonly SqlContext sqlcontext;

        public RepositoryTruck(SqlContext sqlcontext) : base(sqlcontext)
        {
            this.sqlcontext = sqlcontext;
        }
    }
}
