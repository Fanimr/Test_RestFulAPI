using API.Domain.DTOs;
using System;
using System.Collections.Generic;

namespace API.Domain.Interfaces.Services.Product
{
    public interface IProductService
    {
        ProductDTO Get(Guid id);
        IEnumerable<ProductDTO> GetAll();
        ProductDTOCreateResult Post(ProductDTOCreate Product);
        ProductDTOUpdateResult Put(ProductDTOUpdate Product);
        bool Delete(Guid id);
    }
}
