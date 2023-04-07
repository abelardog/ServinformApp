using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServinformApp.Domain.Entities
{
    public class Admin : User
    {
        public string Role { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

    }
}