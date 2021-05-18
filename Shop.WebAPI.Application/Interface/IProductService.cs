using Shop.Domain.Enities;
using Shop.WebAPI.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebAPI.Application.Interface
{
    public interface IProductService
    {
        ProductDto GetProductByID(int ID);
        IList<ProductDto> GetAllProducts();
        ProductDto SearchProduct(int ID, string name);
        ProductDto AddProduct(Product product);
        ProductDto UpdateProduct(Product product);
        int DeleteProduct(Product product);
        int DeleteProduct(int id);

    }
}
