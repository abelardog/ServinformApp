using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServinformApp.Domain.Entities
{
    public class InvoiceLineItem : EntityBase
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}