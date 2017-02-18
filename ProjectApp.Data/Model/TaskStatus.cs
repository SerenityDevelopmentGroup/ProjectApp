using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class TaskStatus
    {
        public TaskStatus()
        {
            Package = new HashSet<Package>();
            ProjectRTsaAggregate = new HashSet<Project>();
            ProjectRTsa = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<Project> ProjectRTsaAggregate { get; set; }
        public virtual ICollection<Project> ProjectRTsa { get; set; }
    }
}
