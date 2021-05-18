using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class CartItem : Cart
    {
 
        public string ItemID { get; set; }
        public int CartID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Product Product { get; set; }
    }
}
