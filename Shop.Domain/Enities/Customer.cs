using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Customer : AuditedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public IList<Address> Addresses { get; set; }
        public IList<Contact> Contacts { get; set; }


    }
}
