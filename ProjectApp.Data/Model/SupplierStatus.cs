using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class SupplierStatus
    {
        public SupplierStatus()
        {
            Supplier = new HashSet<Supplier>();
            SupplierStatusLog = new HashSet<SupplierStatusLog>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<SupplierStatusLog> SupplierStatusLog { get; set; }
    }
}
