using Ninject.Modules;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;
using SelfOrdering.Domain.Models;
using SelfOrdering.Domain.Services;
using SelfOrdering.Infra.Data.Repositories;

namespace SelfOrdering.IoC
{
    public class DomainBindings : NinjectModule
    {
        public override void Load()
        {
            //Repositories
            Bind<IRestaurantRepository>().To<RestaurantRepository>();
            Bind<IBaseRepository<Restaurant>>().To<RestaurantRepository>();


            //Sevices
            Bind<IRestaurantService>().To<RestaurantService>();
        }
    }
}
