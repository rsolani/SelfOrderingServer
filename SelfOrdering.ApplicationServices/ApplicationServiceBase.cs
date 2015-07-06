using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;

namespace SelfOrdering.ApplicationServices
{
    public abstract class ApplicationServiceBase<T> : IApplicationService where T : IMongoEntity, IAggregateRoot
    {
        protected readonly IBaseRepository<T> Repository;

        protected ApplicationServiceBase(IBaseRepository<T> repository)
        {
            Repository = repository; 
        }
    }
}
