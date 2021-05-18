using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Enities
{
    public class AuditedEntity : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreatedUserID { get; set; }
        public int ModifiedUserID { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public AuditedEntity()
        {

        }
        public AuditedEntity(int ID, string Name) : base(ID, Name)
        {
            this.ModifiedDate = DateTime.Now;
        }
    }
}
