using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.Domain
{
    public abstract class DomainServiceBase<T> : IDomainService<T> where T : IMongoEntity, IAggregateRoot
    {
        protected readonly IBaseRepository<T> Repository;
        protected readonly FilterDefinitionBuilder<T> FilterBuilder;
        protected readonly UpdateDefinitionBuilder<T> UpdateBuilder;

        protected DomainServiceBase(IBaseRepository<T> repository)
        {
            Repository = repository;
            FilterBuilder = new FilterDefinitionBuilder<T>();
            UpdateBuilder = new UpdateDefinitionBuilder<T>();
        }

        public async Task<T> GetById(ObjectId id)
        {
            return await Repository.GetByIdAsync(id);
        }
    }
}
