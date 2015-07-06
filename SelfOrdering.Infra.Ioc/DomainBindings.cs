using Ninject.Modules;
using SelfOrdering.Domain;
using SelfOrdering.Domain.Contracts.Services;
using SelfOrdering.Domain.Customer;
using SelfOrdering.Domain.Restaurant;

namespace SelfOrdering.Infra.IoC
{
    public class DomainBindings : NinjectModule
    {
        public override void Load()
        {
            //Repositories


            //Sevices
            Bind(typeof(IDomainService<>)).To(typeof(DomainServiceBase<>));
            Bind<IRestaurantService>().To<RestaurantService>();
            Bind<ICustomerService>().To<CustomerService>();
        }
    }
}
