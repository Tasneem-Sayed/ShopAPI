using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Comment : BaseEntity
    {
        public string body { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
    }
}
