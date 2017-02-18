using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PackageRevision
    {
        public PackageRevision()
        {
            ActiveTask = new HashSet<ActiveTask>();
            CompletedTask = new HashSet<CompletedTask>();
            EmailQueue = new HashSet<EmailQueue>();
            ReviewSummary = new HashSet<ReviewSummary>();
            SupplierStatusLog = new HashSet<SupplierStatusLog>();
        }

        public int Id { get; set; }
        public int RPkgId { get; set; }
        public int Revision { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
        public int RPksCausedId { get; set; }
        public int RArtId { get; set; }
        public int? RPksClosedId { get; set; }

        public virtual ICollection<ActiveTask> ActiveTask { get; set; }
        public virtual ICollection<CompletedTask> CompletedTask { get; set; }
        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual ICollection<ReviewSummary> ReviewSummary { get; set; }
        public virtual ICollection<SupplierStatusLog> SupplierStatusLog { get; set; }
        public virtual Artwork RArt { get; set; }
        public virtual Package RPkg { get; set; }
        public virtual PackageStatus RPksCaused { get; set; }
        public virtual PackageStatus RPksClosed { get; set; }
    }
}
