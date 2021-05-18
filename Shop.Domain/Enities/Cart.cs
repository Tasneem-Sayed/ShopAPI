using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Cart : BaseEntity
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        //   public int CustomerID { get; set; }
        public int Quantity { get; set; }

        public string Path { get; set; }
        public double Price { get; set; }


    }
}
