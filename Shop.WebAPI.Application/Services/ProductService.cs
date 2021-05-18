using AutoMapper;
using Shop.Domain.Enities;
using Shop.WebAPI.Application.Dto;
using Shop.WebAPI.Application.Interface;
using Shop.WebAPI.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebAPI.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly ShopContext _context;
        private readonly IMapper mapper;

        public ProductService(ShopContext context, IMapper mapper)
        {
            this._context = context;
            this.mapper = mapper;


        }

        public ProductDto AddProduct(Product product)
        {
            var p = this._context.Add<Product>(product);
            this._context.SaveChanges();
            return mapper.Map< ProductDto > (p.Entity);
        }


        public int DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public int DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ProductDto> GetAllProducts()
        {
            return this._context.Products.Select(x => new ProductDto()
            {
                ProductID = x.ID,
                Name = x.Name,
                Price = x.Price,
                Img = x.Path,
                Description=x.Description,
                CategoryName=x.Category

              
    }).ToList();
        }

        public ProductDto GetProductByID(int ID)
        {
            throw new NotImplementedException();
        }

        public ProductDto SearchProduct(int ID, string name)
        {
            throw new NotImplementedException();
        }

        public ProductDto UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
    }
