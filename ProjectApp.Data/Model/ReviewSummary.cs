using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ReviewSummary
    {
        public int RPkgId { get; set; }
        public int RRevId { get; set; }
        public string Summary { get; set; }
        public DateTime Created { get; set; }

        public virtual Package RPkg { get; set; }
        public virtual PackageRevision RRev { get; set; }
    }
}
