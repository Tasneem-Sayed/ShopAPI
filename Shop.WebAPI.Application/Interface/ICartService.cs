using Shop.Domain.Enities;
using Shop.WebAPI.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebAPI.Application.Interface
{
   public interface ICartService
    {
      public void AddToCart(int ID);
      public void Dispose();
      public int GetCartId();
      public List<CartItem> GetCartItems();
      public CartItem UpdateProduct(Cart cart);
      public int DeleteProduct(Cart cart);
      public int DeleteProduct(int id);
        IEnumerable<Cart> GetCartItems(CartItems cartItem);
    }
}
