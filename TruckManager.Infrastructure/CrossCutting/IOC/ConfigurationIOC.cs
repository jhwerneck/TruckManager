using Autofac;
using TruckManager.Application;
using TruckManager.Application.Interfaces;
using TruckManager.Application.Interfaces.Mappers;
using TruckManager.Application.Mappers;
using TruckManager.Domain.Core.Interfaces.Repositories;
using TruckManager.Domain.Core.Interfaces.Services;
using TruckManager.Domain.Services;
using TruckManager.Infrastructure.Data.Repositories;

namespace TruckManager.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ApplicationServiceTruck>().As<IApplicationServiceTruck>();
            builder.RegisterType<ServiceTruck>().As<IServiceTruck>();
            builder.RegisterType<RepositoryTruck>().As<IRepositoryTruck>();
            builder.RegisterType<MapperTruck>().As<IMapperTruck>();
            #endregion
        }
    }
}
