using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServinformApp.Domain.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }
    }
}