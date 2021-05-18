using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public enum ContactType { Social, Phone, LandLine, HotLine, Email }
    public class Contact : BaseEntity
    {
        [EmailAddress]
        [Required]
        public ContactType contactType { get; set; }
        public string Note { get; set; }
        public string Icon { get; set; }
    }
}
