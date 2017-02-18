using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Project
    {
        public Project()
        {
            ActiveTask = new HashSet<ActiveTask>();
            CompletedTask = new HashSet<CompletedTask>();
            CyclicTaskAssignment = new HashSet<CyclicTaskAssignment>();
            EmailQueue = new HashSet<EmailQueue>();
            Package = new HashSet<Package>();
            PersonRole = new HashSet<PersonRole>();
            ProcessAutomation = new HashSet<ProcessAutomation>();
            ProjectNote = new HashSet<ProjectNote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public int RPgtId { get; set; }
        public int RBscId { get; set; }
        public int RSupId { get; set; }
        public bool IsRush { get; set; }
        public int RStaId { get; set; }
        public DateTime StaDate { get; set; }
        public string MetaData { get; set; }
        public string Suvc { get; set; }
        public string SubmissionId { get; set; }
        public int NumberPackages { get; set; }
        public int RTsaId { get; set; }
        public int PercentComplete { get; set; }
        public int RTsaAggregateId { get; set; }
        public bool HasApprChanges { get; set; }
        public bool HasSusPackages { get; set; }
        public DateTime? LastPdrDate { get; set; }
        public string PdrFileName { get; set; }
        public string PdaFileName { get; set; }
        public int? RPreId { get; set; }
        public bool IsCanada { get; set; }

        public virtual ICollection<ActiveTask> ActiveTask { get; set; }
        public virtual ICollection<CompletedTask> CompletedTask { get; set; }
        public virtual ICollection<CyclicTaskAssignment> CyclicTaskAssignment { get; set; }
        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual ICollection<PersonRole> PersonRole { get; set; }
        public virtual ICollection<ProcessAutomation> ProcessAutomation { get; set; }
        public virtual ICollection<ProjectNote> ProjectNote { get; set; }
        public virtual ProjectSearchData ProjectSearchData { get; set; }
        public virtual Bscc RBsc { get; set; }
        public virtual ProjectType RPgt { get; set; }
        public virtual Prepress RPre { get; set; }
        public virtual ProjectStatus RSta { get; set; }
        public virtual Supplier RSup { get; set; }
        public virtual TaskStatus RTsaAggregate { get; set; }
        public virtual TaskStatus RTsa { get; set; }
    }
}
