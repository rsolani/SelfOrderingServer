using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SelfOrdering.Domain.Contracts.Repositories
{
    public interface IBaseRepository<T> where T : IMongoEntity
    {
        Task<T> GetByIdAsync(ObjectId id);

        Task<IList<T>> GetAllAsync();

        Task InsertAsync(T entity);

        Task<UpdateResult> UpdateAsync(FilterDefinition<T> filterDefinition , UpdateDefinition<T> updateDefinition);

        Task<ReplaceOneResult> ReplaceOneAsync(FilterDefinition<T> filterDefinition, T entity);

        Task<IList<T>> GetByFilterAsync(Expression<Func<T, bool>> expression);

        Task<DeleteResult> DeleteAsync(ObjectId id);
    }
}
