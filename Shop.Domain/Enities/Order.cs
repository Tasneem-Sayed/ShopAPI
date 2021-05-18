using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public enum OrderStatus { Pending, Completed, Shipping, Returned, Canceled }
    public class Order : AuditedEntity
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime requiredDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public int CustomerID { get; set; }
        public OrderStatus Status { get; set; }
        public Comment comment { get; set; }


    }
}
