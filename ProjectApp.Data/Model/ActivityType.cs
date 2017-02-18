using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            ActivityLog = new HashSet<ActivityLog>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ReferenceIdColumns { get; set; }

        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
    }
}
