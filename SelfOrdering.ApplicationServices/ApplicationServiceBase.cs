using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using SelfOrdering.ApplicationServices.Contracts;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.ApplicationServices
{
    public abstract class ApplicationServiceBase<T> : IApplicationService<T> where T : IMongoEntity, IAggregateRoot
    {

        protected readonly IBaseRepository<T> Repository;
        protected IDomainService<T> DomainService;


        public ApplicationServiceBase(IBaseRepository<T> repository, IDomainService<T> domainService)
        {
            Repository = repository;
            DomainService = domainService;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Repository.GetAllAsync();
        }

        public async Task<T> GetById(ObjectId id)
        {
            return await Repository.GetByIdAsync(id);
        }
    }
}
