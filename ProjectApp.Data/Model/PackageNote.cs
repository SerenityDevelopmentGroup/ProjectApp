using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PackageNote
    {
        public int Id { get; set; }
        public int RPkgId { get; set; }
        public int? RPerId { get; set; }
        public bool? IsPrivate { get; set; }
        public string Note { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int? RPerModifiedId { get; set; }
        public int? RRevId { get; set; }

        public virtual Person RPer { get; set; }
        public virtual Person RPerModified { get; set; }
        public virtual Package RPkg { get; set; }
    }
}
