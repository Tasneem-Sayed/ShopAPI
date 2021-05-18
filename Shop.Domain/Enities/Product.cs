using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Product : BaseEntity
    {

        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public string Path { get; set; }
        // public Brand Brand { get; set; }
        // public IList<Image> Images { get; set; }
    }
}
