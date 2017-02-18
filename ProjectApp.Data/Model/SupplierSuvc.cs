using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class SupplierSuvc
    {
        public int RSupId { get; set; }
        public string Suvc { get; set; }

        public virtual Supplier RSup { get; set; }
    }
}
