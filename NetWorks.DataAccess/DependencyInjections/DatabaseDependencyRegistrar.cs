using Autofac;
using Microsoft.Extensions.Configuration;
using NetWorks.Core.Infrastructure;
using NetWorks.Core.Infrastructure.DependencyManagement;
using NetWorks.DataAccess.Repositories;

namespace NetWorks.DataAccess.DependencyInjections
{
    public class DatabaseDependencyRegistrar : IDependencyRegistrar
    {
        public int Order => 0;

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, IConfiguration configuration)
        {
            builder.RegisterGeneric(typeof(BaseRepo<>)).As(typeof(IRepo<>)).InstancePerLifetimeScope();
        }
    }
}