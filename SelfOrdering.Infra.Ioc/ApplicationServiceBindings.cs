using Ninject.Modules;
using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.ApplicationServices.Customer;
using SelfOrdering.ApplicationServices.MessageLog;
using SelfOrdering.ApplicationServices.Restaurant;

namespace SelfOrdering.Infra.IoC
{
    public class ApplicationServiceBindings : NinjectModule
    {
        public override void Load()
        {
            //Services
            Bind<IRestaurantApplicationService>().To<RestaurantApplicationService>();
            Bind<ICustomerApplicationService>().To<CustomerApplicationService>();
            Bind<IMessageHandlerApplicationService>().To<MessageHandlerApplicationService>();
        }
    }
}
