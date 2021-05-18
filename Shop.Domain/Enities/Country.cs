using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{

    public class Country : BaseEntity
    {
        public virtual ICollection<City> Cities { get; set; }
    }
}
