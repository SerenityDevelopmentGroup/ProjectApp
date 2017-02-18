using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ThumbnailType
    {
        public ThumbnailType()
        {
            ArtworkThumbnail = new HashSet<ArtworkThumbnail>();
        }

        public int Id { get; set; }
        public int Size { get; set; }

        public virtual ICollection<ArtworkThumbnail> ArtworkThumbnail { get; set; }
    }
}
