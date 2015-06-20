using Ninject.Modules;
using SelfOrdering.Domain;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;
using SelfOrdering.Domain.Customer;
using SelfOrdering.Domain.Order;
using SelfOrdering.Domain.Restaurant;
using SelfOrdering.Infra.Data.Repositories;

namespace SelfOrdering.Infra.IoC
{
    public class DomainBindings : NinjectModule
    {
        public override void Load()
        {
            //Repositories
            Bind<IBaseRepository<Restaurant>>().To<RestaurantRepository>();
            Bind<IBaseRepository<Order>>().To<OrderRepository>();
            Bind<IBaseRepository<Customer>>().To<CustomerRepository>();


            //Sevices
            Bind(typeof(IDomainService<>)).To(typeof(DomainServiceBase<>));
            Bind<IRestaurantService>().To<RestaurantService>();
        }
    }
}
