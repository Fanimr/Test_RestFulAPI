using API.Domain.DTOs;
using API.Domain.Entities;
using AutoMapper;

namespace API.CrossDependency.Mappings
{
    public class EntityToDTOProfile : Profile
    {
        public EntityToDTOProfile()
        {
            CreateMap<ProductDTO, ProductEntity>()
              .ReverseMap();
            CreateMap<ProductDTOCreateResult, ProductEntity>()
                  .ReverseMap();
            CreateMap<ProductDTOUpdateResult, ProductEntity>()
                  .ReverseMap();
        }
    }
}
