using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebAPI.Application.Dto
{
   public class CartItems
    {
        public ProductDto product { get; set; }
        public int Quantity { get; set; }
    }
}
