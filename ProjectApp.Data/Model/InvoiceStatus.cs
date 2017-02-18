using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class InvoiceStatus
    {
        public InvoiceStatus()
        {
            SupplierInvoice = new HashSet<SupplierInvoice>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SupplierInvoice> SupplierInvoice { get; set; }
    }
}
