using API.Domain.Entities;
using System;
using System.Collections.Generic;

namespace API.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Insert(T item);
        T Update(T item);
        bool Delete(Guid id);
        T Select(Guid id);
        IEnumerable<T> Select();
    }
}
