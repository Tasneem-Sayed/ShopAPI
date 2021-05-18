using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Upload : BaseEntity
    {

        //  public int Id { get; set; }
        // public string FileName { get; set; }
        public string ContentType { get; set; }
        public decimal Size { get; set; }
        public int UserId { get; set; }

    }
}
