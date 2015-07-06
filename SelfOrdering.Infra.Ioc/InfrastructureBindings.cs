using Ninject.Modules;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Infra.Data;

namespace SelfOrdering.Infra.IoC
{
    public class InfrastructureBindings : NinjectModule
    {
        public override void Load()
        {
            //Repositories
            Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
        }
    }
}
