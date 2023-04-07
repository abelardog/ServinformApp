using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServinformApp.Domain.Entities
{
    public class Invoice : EntityBase
    {
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        
        public virtual ICollection<InvoiceLineItem> LineItems { get; set; }
    }
}