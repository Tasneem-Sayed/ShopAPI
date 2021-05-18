using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Payment : BaseEntity
    {
        public int CustomerNumber { get; set; }
        public int CheckNumber { get; set; }
        public double Amount { get; set; }

    }
}
