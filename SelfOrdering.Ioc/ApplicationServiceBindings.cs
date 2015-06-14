using Ninject.Modules;
using SelfOrdering.ApplicationServices;
using SelfOrdering.ApplicationServices.Contracts;

namespace SelfOrdering.IoC
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
