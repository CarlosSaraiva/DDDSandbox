using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using SpaUserControl.Domain.Contracts.Repositories;
using SpaUserControl.Infrastructure.Data;
using SpaUserControl.Infrastructure.Repositories;

namespace SpaUserControl.Startup
{
    class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<AppDataContext, AppDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
        }
    }
}
