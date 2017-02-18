using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PackageStatusLog1
    {
        public int Id { get; set; }
        public int? RPkgId { get; set; }
        public int? RPksId { get; set; }
        public int? RRevId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }

        public virtual Package RPkg { get; set; }
    }
}
