using AutoMapper;
using EFCore_Store_Procedured_1.DTOs;
using EFCore_Store_Procedured_1.Entities;

namespace EFCore_Store_Procedured_1.Mappings
{
    public class ProductProfiles:Profile
    {
        public ProductProfiles()
        {
            CreateMap<Product, ProductListDto>()
                .ForMember(x => x.CategoryName,dest=>dest.MapFrom(p=>p.Category.Name))
                .ReverseMap();
            CreateMap<Product, CreatedProductDto>().ReverseMap();
        }
    }
}
