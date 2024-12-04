using AutoMapper;
using BurguerMania.Application.Dtos.Category;
using BurguerMania.Application.Dtos.Order;
using BurguerMania.Application.Dtos.Product;
using BurguerMania.Application.Dtos.User;
using BurguerMania.Domain.Entities;

namespace BurguerMania.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRequest, User>();
            CreateMap<User, UserResponse>();

            CreateMap<OrderRequest, Order>();
            CreateMap<Order, OrderResponse>();

            CreateMap<ProductRequest, Product>()
                .ForMember(dest => dest.PathImage, opt => opt.Ignore());
            CreateMap<Product, ProductResponse>();

            CreateMap<CategoryRequest, Category>()
                .ForMember(dest => dest.PathImage, opt => opt.Ignore());
            CreateMap<Category, CategoryResponse>();
        }
    }
}