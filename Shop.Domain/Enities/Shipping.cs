using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Shipping : BaseEntity
    {
        public Double Totalprice { get; set; }
        public DateTime ShipingDate { get; set; }

        public OrderStatus ShippingStauts { get; set; }
    }
}
