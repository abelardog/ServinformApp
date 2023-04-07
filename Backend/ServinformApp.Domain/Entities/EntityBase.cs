using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServinformApp.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}