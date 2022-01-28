using API.Domain.Entities;
using System;
using System.Collections.Generic;

namespace API.Domain.Repository
{
    public interface IProductRepository
    {
        ProductEntity Get(Guid id);
        IEnumerable<ProductEntity> GetAll();
        ProductEntity Post(ProductEntity Product);
        ProductEntity Put(ProductEntity Product);
        bool Delete(Guid id);
    }
}
