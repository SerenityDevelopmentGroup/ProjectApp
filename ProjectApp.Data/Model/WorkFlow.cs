using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class WorkFlow
    {
        public int RTskId { get; set; }
        public int ProcessKey { get; set; }
        public int RTskParentId { get; set; }
        public string Notes { get; set; }

        public virtual Task RTsk { get; set; }
        public virtual Task RTskParent { get; set; }
    }
}
