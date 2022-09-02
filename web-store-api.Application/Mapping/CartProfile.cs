using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web_store_api.Application.DTOs.Cart;
using web_store_api.Domain.Entities;

namespace web_store_api.Application.Mapping
{
    public class CartProfile : Profile
    {
        public CartProfile()
        {
            CreateMap<CreateCartDto, Cart>();
            CreateMap<Cart, ReadCartDto>();
            CreateMap<UpdateCartDto, Cart>();
        }
    }
}
