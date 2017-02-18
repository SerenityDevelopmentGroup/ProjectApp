using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ProjectType
    {
        public ProjectType()
        {
            Project = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Project> Project { get; set; }
    }
}
