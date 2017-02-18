using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class TaskType
    {
        public TaskType()
        {
            Task = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsSystem { get; set; }

        public virtual ICollection<Task> Task { get; set; }
    }
}
