using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.WebAPI.Application.Dto
{
    public class ProductDto
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        public double Price { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
    }
}
