﻿namespace SelfOrdering.Domain.Contracts.Services
{
    public interface IDomainService<T> where T : IMongoEntity, IAggregateRoot
    {

    }
}
