using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Person
    {
        public Person()
        {
            ActivityLog = new HashSet<ActivityLog>();
            Artwork = new HashSet<Artwork>();
            CompletedTask = new HashSet<CompletedTask>();
            CyclicRoleAssignment = new HashSet<CyclicRoleAssignment>();
            EmailQueue = new HashSet<EmailQueue>();
            PackageNoteRPer = new HashSet<PackageNote>();
            PackageNoteRPerModified = new HashSet<PackageNote>();
            PersonEmailBlock = new HashSet<PersonEmailBlock>();
            PersonEmailLog = new HashSet<PersonEmailLog>();
            PersonMetrics = new HashSet<PersonMetrics>();
            PersonRole = new HashSet<PersonRole>();
            ProjectDeleteLog = new HashSet<ProjectDeleteLog>();
            ProjectNote = new HashSet<ProjectNote>();
            ProjectRoleDefault = new HashSet<ProjectRoleDefault>();
            QaSuspensionRCreatedPer = new HashSet<QaSuspension>();
            QaSuspensionRPqmPer = new HashSet<QaSuspension>();
            RoleCandidates = new HashSet<RoleCandidates>();
            Supplier = new HashSet<Supplier>();
            SupplierInvoiceRPerCreated = new HashSet<SupplierInvoice>();
            SupplierInvoiceRPerUpdated = new HashSet<SupplierInvoice>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? LastActivity { get; set; }
        public DateTime? LastTaskEmail { get; set; }
        public int? RPemId { get; set; }
        public int? RPstId { get; set; }
        public int? RSupId { get; set; }
        public int? RAdrId { get; set; }
        public DateTime? EulaAccepted { get; set; }
        public int RPtaId { get; set; }
        public int? RPreId { get; set; }
        public string AccessToken { get; set; }

        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual ICollection<Artwork> Artwork { get; set; }
        public virtual ICollection<CompletedTask> CompletedTask { get; set; }
        public virtual ICollection<CyclicRoleAssignment> CyclicRoleAssignment { get; set; }
        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual ICollection<PackageNote> PackageNoteRPer { get; set; }
        public virtual ICollection<PackageNote> PackageNoteRPerModified { get; set; }
        public virtual ICollection<PersonEmailBlock> PersonEmailBlock { get; set; }
        public virtual ICollection<PersonEmailLog> PersonEmailLog { get; set; }
        public virtual ICollection<PersonMetrics> PersonMetrics { get; set; }
        public virtual ICollection<PersonRole> PersonRole { get; set; }
        public virtual PersonSearchData PersonSearchData { get; set; }
        public virtual ICollection<ProjectDeleteLog> ProjectDeleteLog { get; set; }
        public virtual ICollection<ProjectNote> ProjectNote { get; set; }
        public virtual ICollection<ProjectRoleDefault> ProjectRoleDefault { get; set; }
        public virtual ICollection<QaSuspension> QaSuspensionRCreatedPer { get; set; }
        public virtual ICollection<QaSuspension> QaSuspensionRPqmPer { get; set; }
        public virtual ICollection<RoleCandidates> RoleCandidates { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<SupplierInvoice> SupplierInvoiceRPerCreated { get; set; }
        public virtual ICollection<SupplierInvoice> SupplierInvoiceRPerUpdated { get; set; }
        public virtual Address RAdr { get; set; }
        public virtual Permission RPem { get; set; }
        public virtual Prepress RPre { get; set; }
        public virtual PersonType RPst { get; set; }
        public virtual PersonStatus RPta { get; set; }
        public virtual Supplier RSup { get; set; }
    }
}
