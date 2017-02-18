using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class RoleCandidates
    {
        public int RPerId { get; set; }
        public int RRolId { get; set; }
        public int? RSupId { get; set; }

        public virtual Person RPer { get; set; }
        public virtual Role RRol { get; set; }
        public virtual Supplier RSup { get; set; }
    }
}
