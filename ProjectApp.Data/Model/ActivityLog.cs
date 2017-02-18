using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ActivityLog
    {
        public int Id { get; set; }
        public int RPerId { get; set; }
        public int RActId { get; set; }
        public int? ReferenceId1 { get; set; }
        public int? ReferenceId2 { get; set; }
        public int? ReferenceId3 { get; set; }
        public int? ReferenceId4 { get; set; }
        public int? ReferenceId5 { get; set; }
        public int? ReferenceId6 { get; set; }
        public int? ReferenceId7 { get; set; }
        public int? ReferenceId8 { get; set; }
        public int? ReferenceId9 { get; set; }
        public int? ReferenceId10 { get; set; }
        public string LogText { get; set; }
        public DateTime Created { get; set; }

        public virtual ActivityType RAct { get; set; }
        public virtual Person RPer { get; set; }
    }
}
