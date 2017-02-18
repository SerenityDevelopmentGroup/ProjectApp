using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class SupportingFile
    {
        public int Id { get; set; }
        public int RArtId { get; set; }
        public string FileName { get; set; }
        public string InternalFileName { get; set; }
        public DateTime Created { get; set; }

        public virtual Artwork RArt { get; set; }
    }
}
