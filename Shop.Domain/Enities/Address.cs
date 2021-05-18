using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Address : BaseEntity
    {
        public int CityID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public Address()
        {

        }

        public Address(int ID, string Name, string Line1, string Line2) : base(ID, Name)
        {
            this.Line1 = Line1;
            this.Line2 = Line2;
        }

    }
}
