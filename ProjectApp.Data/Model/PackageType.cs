using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PackageType
    {
        public PackageType()
        {
            Artwork = new HashSet<Artwork>();
            Package = new HashSet<Package>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string OldPackageType { get; set; }

        public virtual ICollection<Artwork> Artwork { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}
