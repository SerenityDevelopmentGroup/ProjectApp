using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ProjectDeleteLog
    {
        public int Id { get; set; }
        public int? RPerId { get; set; }
        public int? OldProjectId { get; set; }
        public DateTime? Completed { get; set; }
        public int? OldPackageId { get; set; }

        public virtual Person RPer { get; set; }
    }
}
