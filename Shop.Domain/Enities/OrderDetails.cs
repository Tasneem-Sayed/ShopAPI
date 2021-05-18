using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class OrderDetails : BaseEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int OrderNumber { get; set; }

        public int Quantityeach { get; set; }
        public double Discount { get; set; }
    }
}
