using API.Domain.Entities;
using API.Domain.Models;
using AutoMapper;

namespace API.CrossDependency.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<ProductModel, ProductEntity>()
                 .ReverseMap();
        }
    }
}
