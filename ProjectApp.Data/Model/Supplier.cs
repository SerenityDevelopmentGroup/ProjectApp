using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Supplier
    {
        public Supplier()
        {
            Artwork = new HashSet<Artwork>();
            Person = new HashSet<Person>();
            PrepressSupplier = new HashSet<PrepressSupplier>();
            ProcessAutomation = new HashSet<ProcessAutomation>();
            Project = new HashSet<Project>();
            QaSuspension = new HashSet<QaSuspension>();
            RoleCandidates = new HashSet<RoleCandidates>();
            SupplierInvoice = new HashSet<SupplierInvoice>();
            SupplierStatusLog = new HashSet<SupplierStatusLog>();
            SupplierSuvc = new HashSet<SupplierSuvc>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? QaDbFeePaidDate { get; set; }
        public int? OldUserGroupId { get; set; }
        public int? Oldid { get; set; }
        public int? RSupParentId { get; set; }
        public int? Cost { get; set; }
        public int? RAdrId { get; set; }
        public int? RStsId { get; set; }
        public int? RPerContactId { get; set; }
        public int? SyscoOwned { get; set; }
        public int? RSbaId { get; set; }
        public int? RStyId { get; set; }

        public virtual ICollection<Artwork> Artwork { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<PrepressSupplier> PrepressSupplier { get; set; }
        public virtual ICollection<ProcessAutomation> ProcessAutomation { get; set; }
        public virtual ICollection<Project> Project { get; set; }
        public virtual ICollection<QaSuspension> QaSuspension { get; set; }
        public virtual ICollection<RoleCandidates> RoleCandidates { get; set; }
        public virtual ICollection<SupplierInvoice> SupplierInvoice { get; set; }
        public virtual ICollection<SupplierStatusLog> SupplierStatusLog { get; set; }
        public virtual ICollection<SupplierSuvc> SupplierSuvc { get; set; }
        public virtual Address RAdr { get; set; }
        public virtual Person RPerContact { get; set; }
        public virtual SupplierOperation RSba { get; set; }
        public virtual SupplierStatus RSts { get; set; }
        public virtual SupplierType RSty { get; set; }
        public virtual Supplier RSupParent { get; set; }
        public virtual ICollection<Supplier> InverseRSupParent { get; set; }
    }
}
