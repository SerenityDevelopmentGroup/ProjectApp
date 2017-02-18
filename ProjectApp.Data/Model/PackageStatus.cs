using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PackageStatus
    {
        public PackageStatus()
        {
            Package = new HashSet<Package>();
            PackageRevisionRPksCaused = new HashSet<PackageRevision>();
            PackageRevisionRPksClosed = new HashSet<PackageRevision>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<PackageRevision> PackageRevisionRPksCaused { get; set; }
        public virtual ICollection<PackageRevision> PackageRevisionRPksClosed { get; set; }
    }
}
