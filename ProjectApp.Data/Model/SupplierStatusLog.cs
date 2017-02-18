using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class SupplierStatusLog
    {
        public int Id { get; set; }
        public int? RSupId { get; set; }
        public int? RPkgId { get; set; }
        public int? RRevId { get; set; }
        public DateTime? Created { get; set; }
        public int? RStsId { get; set; }

        public virtual Package RPkg { get; set; }
        public virtual PackageRevision RRev { get; set; }
        public virtual SupplierStatus RSts { get; set; }
        public virtual Supplier RSup { get; set; }
    }
}
