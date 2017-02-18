using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class CyclicRoleAssignment
    {
        public int RPerId { get; set; }
        public int RRolId { get; set; }
        public DateTime Assigned { get; set; }

        public virtual Person RPer { get; set; }
        public virtual Role RRol { get; set; }
    }
}
