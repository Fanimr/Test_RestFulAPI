using AutoMapper;
using API.Domain.DTOs;
using API.Domain.Models;

namespace API.CrossDependency.Mappings
{
    public class DTOToModelProfile : Profile
    {
        public DTOToModelProfile()
        {
            CreateMap<ProductModel, ProductDTO>()
                .ReverseMap();

            CreateMap<ProductModel, ProductDTOCreate>()
                    .ReverseMap();

            CreateMap<ProductModel, ProductDTOUpdate>()
                    .ReverseMap();
        }
    }
}
