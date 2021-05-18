using Microsoft.VisualStudio.Services.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class City : BaseEntity
    {
        public int CountryID { get; set; }

        public virtual Country Country { get; set; }
    }
}
