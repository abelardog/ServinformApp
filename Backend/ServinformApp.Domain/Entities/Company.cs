using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServinformApp.Domain.Entities
{
    public class Company : EntityBase
    {
       public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}