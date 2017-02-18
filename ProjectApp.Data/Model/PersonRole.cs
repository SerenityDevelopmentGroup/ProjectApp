using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PersonRole
    {
        public int Id { get; set; }
        public int RPrjId { get; set; }
        public int? RPkgId { get; set; }
        public int? RRevId { get; set; }
        public int RPerId { get; set; }
        public int RRolId { get; set; }
        public DateTime? Created { get; set; }

        public virtual Person RPer { get; set; }
        public virtual Package RPkg { get; set; }
        public virtual Project RPrj { get; set; }
        public virtual Role RRol { get; set; }
    }
}
