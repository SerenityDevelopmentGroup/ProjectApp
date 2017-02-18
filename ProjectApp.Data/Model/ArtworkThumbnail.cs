using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ArtworkThumbnail
    {
        public int Id { get; set; }
        public int RArtId { get; set; }
        public int RTmbId { get; set; }
        public int PageNumber { get; set; }
        public string FileName { get; set; }
        public DateTime? Created { get; set; }

        public virtual Artwork RArt { get; set; }
        public virtual ThumbnailType RTmb { get; set; }
    }
}
