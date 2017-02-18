using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PackageSuspensionLog
    {
        public int Id { get; set; }
        public int? RPkgId { get; set; }
        public int? RSusId { get; set; }
        public int? RRevId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
        public int RPerCreatedId { get; set; }
        public int? RPerCompletedId { get; set; }
        public int RQasId { get; set; }

        public virtual Package RPkg { get; set; }
    }
}
