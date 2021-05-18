using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class BaseEntity
    {

        public int ID { get; set; }
        public string Name { get; set; }


        public BaseEntity()
        {

        }
        public BaseEntity(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}

