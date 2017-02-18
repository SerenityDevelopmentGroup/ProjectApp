using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ArchivedSupportingFile
    {
        public int Id { get; set; }
        public int RArtId { get; set; }
        public string FileName { get; set; }
        public string InternalFileName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Archived { get; set; }
    }
}
