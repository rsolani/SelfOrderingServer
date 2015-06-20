using Ninject.Modules;
using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.ApplicationServices.Restaurant;

namespace SelfOrdering.Infra.IoC
{
    public class ApplicationServiceBindings : NinjectModule
    {
        public override void Load()
        {
            //Services
            Bind<IRestaurantApplicationService>().To<RestaurantApplicationService>();
        }
    }
}
