using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class SupplierOperation
    {
        public SupplierOperation()
        {
            Supplier = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string Operation { get; set; }

        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
