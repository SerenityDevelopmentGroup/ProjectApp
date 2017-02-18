using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class SupplierType
    {
        public SupplierType()
        {
            Supplier = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
