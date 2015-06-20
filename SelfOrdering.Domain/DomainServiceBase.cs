using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;
using SelfOrdering.Domain.Contracts.Services;

namespace SelfOrdering.Domain
{
    public class DomainServiceBase<T> : IDomainService<T> where T : IMongoEntity, IAggregateRoot
    {
        protected IBaseRepository<T> Repository;
        protected FilterDefinitionBuilder<T> FilterBuilder;
        protected UpdateDefinitionBuilder<T> UpdateBuilder;

        public DomainServiceBase(IBaseRepository<T> repository)
        {
            Repository = repository;
            FilterBuilder = new FilterDefinitionBuilder<T>();
            UpdateBuilder = new UpdateDefinitionBuilder<T>();
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
