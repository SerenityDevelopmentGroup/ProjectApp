using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PrepressSupplier
    {
        public int RPreId { get; set; }
        public int RSupId { get; set; }

        public virtual Prepress RPre { get; set; }
        public virtual Supplier RSup { get; set; }
    }
}
