using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Artwork
    {
        public Artwork()
        {
            ArtworkThumbnail = new HashSet<ArtworkThumbnail>();
            Package = new HashSet<Package>();
            PackageRevision = new HashSet<PackageRevision>();
            SupportingFile = new HashSet<SupportingFile>();
        }

        public int Id { get; set; }
        public int RSupId { get; set; }
        public string FileName { get; set; }
        public string InternalFileName { get; set; }
        public int? RPtyId { get; set; }
        public string Supc { get; set; }
        public int? RBscId { get; set; }
        public bool IsEngaged { get; set; }
        public DateTime? Created { get; set; }
        public string Comments { get; set; }
        public DateTime? EngagedDate { get; set; }
        public int? RPreId { get; set; }
        public int? RPerIdCreated { get; set; }

        public virtual ICollection<ArtworkThumbnail> ArtworkThumbnail { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<PackageRevision> PackageRevision { get; set; }
        public virtual ICollection<SupportingFile> SupportingFile { get; set; }
        public virtual Bscc RBsc { get; set; }
        public virtual Person RPerIdCreatedNavigation { get; set; }
        public virtual Prepress RPre { get; set; }
        public virtual PackageType RPty { get; set; }
        public virtual Supplier RSup { get; set; }
    }
}
