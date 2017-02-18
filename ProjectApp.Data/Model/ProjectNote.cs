using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ProjectNote
    {
        public int Id { get; set; }
        public int RPrjId { get; set; }
        public int RPerId { get; set; }
        public DateTime Created { get; set; }
        public string Note { get; set; }
        public int? OldProjectId { get; set; }
        public int? IsPrivate { get; set; }

        public virtual Person RPer { get; set; }
        public virtual Project RPrj { get; set; }
    }
}
