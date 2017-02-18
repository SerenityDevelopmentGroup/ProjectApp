using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ArchivedActiveTask
    {
        public int Id { get; set; }
        public int RPrjId { get; set; }
        public int? RPkgId { get; set; }
        public int RTskId { get; set; }
        public int RRolId { get; set; }
        public int? RRevId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Warn { get; set; }
        public DateTime? Overdue { get; set; }
        public int RPerId { get; set; }
        public DateTime Archived { get; set; }
    }
}
