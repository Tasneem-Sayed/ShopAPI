using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class Register : Login
    {
        [Compare("Password")]
        public string Confirmpassword { get; set; }
    }
}
