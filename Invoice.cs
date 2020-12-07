using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceWorkflow
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public decimal Value { get; set; }
    }
}
