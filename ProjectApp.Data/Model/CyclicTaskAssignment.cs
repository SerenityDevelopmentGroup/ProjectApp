using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class CyclicTaskAssignment
    {
        public int Id { get; set; }
        public int RTskId { get; set; }
        public int RPrjId { get; set; }
        public int? RPkgId { get; set; }
        public DateTime NextActive { get; set; }

        public virtual Package RPkg { get; set; }
        public virtual Project RPrj { get; set; }
        public virtual Task RTsk { get; set; }
    }
}
