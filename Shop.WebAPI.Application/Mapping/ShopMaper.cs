using Microsoft.VisualStudio.Services.Profile;
using Shop.Domain.Enities;
using Shop.WebAPI.Application.Dto;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebAPI.Application.Mapping
{
    public class ShopMaper : AutoMapper.Profile
    {
        public ShopMaper()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
