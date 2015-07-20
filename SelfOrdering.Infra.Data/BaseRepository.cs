using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using SelfOrdering.Domain;
using SelfOrdering.Domain.Contracts;
using SelfOrdering.Domain.Contracts.Repositories;

namespace SelfOrdering.Infra.Data
{
    public  class BaseRepository<T> : IBaseRepository<T> where T : MongoEntityBase, IAggregateRoot
    {
        protected readonly DbContext<T> BaseConnectionHandler;
        
        public BaseRepository()
        {
            BaseConnectionHandler = new DbContext<T>(); 
        }

        public async Task<T> GetByIdAsync(ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(x => x.Id, id);
            return await this.BaseConnectionHandler.Collection.Find(filter).FirstOrDefaultAsync();
            
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await this.BaseConnectionHandler.Collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetByFilterAsync(Expression<Func<T, bool>> expression)
        {
            return await this.BaseConnectionHandler.Collection.Find(expression).ToListAsync();
        }

        public async Task<IReadOnlyList<T>> GetByFilterAsync(FilterDefinition<T> filterDefinition)
        {
            return await this.BaseConnectionHandler.Collection.Find(filterDefinition).ToListAsync();
        }


        public async Task InsertAsync(T entity)
        {
            entity.Created = DateTime.Now;
            await this.BaseConnectionHandler.Collection.InsertOneAsync(entity);
        }

        public async Task<UpdateResult> UpdateAsync(FilterDefinition<T> filterDefinition, UpdateDefinition<T> updateDefinition)
        {
            updateDefinition.CurrentDate("Updated");
            return await this.BaseConnectionHandler.Collection.UpdateOneAsync(filterDefinition, updateDefinition);
        }

        public async Task<ReplaceOneResult> ReplaceOneAsync(FilterDefinition<T> filterDefinition, T entity)
        {
            return await this.BaseConnectionHandler.Collection.ReplaceOneAsync(filterDefinition, entity);
        }
        
        public async Task<DeleteResult> DeleteAsync(ObjectId id)
        {
            var filter = Builders<T>.Filter.Eq(x => x.Id, id);
            return await this.BaseConnectionHandler.Collection.DeleteOneAsync(filter);
        }
    }
}