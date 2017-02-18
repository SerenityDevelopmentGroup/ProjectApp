using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ProjectStatus
    {
        public ProjectStatus()
        {
            Project = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}
