using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ProjectRoleDefault
    {
        public int RPrjId { get; set; }
        public int RRolId { get; set; }
        public int RPerId { get; set; }

        public virtual Person RPer { get; set; }
    }
}
