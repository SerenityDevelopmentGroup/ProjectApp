using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Package
    {
        public Package()
        {
            ActiveTask = new HashSet<ActiveTask>();
            CompletedTask = new HashSet<CompletedTask>();
            CyclicTaskAssignment = new HashSet<CyclicTaskAssignment>();
            EmailQueue = new HashSet<EmailQueue>();
            PackageNote = new HashSet<PackageNote>();
            PackageRevision = new HashSet<PackageRevision>();
            PackageStatusLog1 = new HashSet<PackageStatusLog1>();
            PackageSuspensionLog = new HashSet<PackageSuspensionLog>();
            PersonRole = new HashSet<PersonRole>();
            ProcessAutomation = new HashSet<ProcessAutomation>();
            ReviewSummary = new HashSet<ReviewSummary>();
            SupplierStatusLog = new HashSet<SupplierStatusLog>();
        }

        public int Id { get; set; }
        public int RPtyId { get; set; }
        public int RPrjId { get; set; }
        public int RPksId { get; set; }
        public DateTime PksDate { get; set; }
        public DateTime Created { get; set; }
        public bool HasRework { get; set; }
        public string Supc { get; set; }
        public int RTsaId { get; set; }
        public DateTime? Completed { get; set; }
        public int? RRevLatestId { get; set; }
        public int PercentComplete { get; set; }
        public int AmountReviewers { get; set; }
        public int? RArtLatestId { get; set; }
        public bool HasApprChanges { get; set; }
        public int? OldPackageId { get; set; }
        public int? OldProjectId { get; set; }
        public int? RSusId { get; set; }
        public DateTime? LastPdrDate { get; set; }
        public string PdrFileName { get; set; }

        public virtual ICollection<ActiveTask> ActiveTask { get; set; }
        public virtual ICollection<CompletedTask> CompletedTask { get; set; }
        public virtual ICollection<CyclicTaskAssignment> CyclicTaskAssignment { get; set; }
        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual ICollection<PackageNote> PackageNote { get; set; }
        public virtual ICollection<PackageRevision> PackageRevision { get; set; }
        public virtual ICollection<PackageStatusLog1> PackageStatusLog1 { get; set; }
        public virtual ICollection<PackageSuspensionLog> PackageSuspensionLog { get; set; }
        public virtual ICollection<PersonRole> PersonRole { get; set; }
        public virtual ICollection<ProcessAutomation> ProcessAutomation { get; set; }
        public virtual ICollection<ReviewSummary> ReviewSummary { get; set; }
        public virtual ICollection<SupplierStatusLog> SupplierStatusLog { get; set; }
        public virtual Artwork RArtLatest { get; set; }
        public virtual PackageStatus RPks { get; set; }
        public virtual Project RPrj { get; set; }
        public virtual PackageType RPty { get; set; }
        public virtual QaSuspension RSus { get; set; }
        public virtual TaskStatus RTsa { get; set; }
    }
}
