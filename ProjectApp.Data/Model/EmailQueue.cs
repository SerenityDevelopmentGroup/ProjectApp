using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class EmailQueue
    {
        public int Id { get; set; }
        public int REmlId { get; set; }
        public int? RPrjId { get; set; }
        public int? RPkgId { get; set; }
        public int? RSusId { get; set; }
        public int? RPamId { get; set; }
        public int? RArqId { get; set; }
        public int RPerId { get; set; }
        public int? REmsId { get; set; }
        public DateTime? EmsDate { get; set; }
        public DateTime Created { get; set; }
        public int? RRevId { get; set; }

        public virtual AccessRequest RArq { get; set; }
        public virtual EmailType REml { get; set; }
        public virtual EmailStatus REms { get; set; }
        public virtual ProcessAutomation RPam { get; set; }
        public virtual Person RPer { get; set; }
        public virtual Package RPkg { get; set; }
        public virtual Project RPrj { get; set; }
        public virtual PackageRevision RRev { get; set; }
        public virtual QaSuspension RSus { get; set; }
    }
}
