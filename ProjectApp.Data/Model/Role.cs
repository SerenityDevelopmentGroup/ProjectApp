using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Role
    {
        public Role()
        {
            ActiveTask = new HashSet<ActiveTask>();
            CompletedTask = new HashSet<CompletedTask>();
            CyclicRoleAssignment = new HashSet<CyclicRoleAssignment>();
            PersonRole = new HashSet<PersonRole>();
            RoleCandidates = new HashSet<RoleCandidates>();
            Task = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool AcrossRevision { get; set; }
        public int RRtyId { get; set; }
        public string OldRoleLabel { get; set; }
        public bool HasCandidates { get; set; }

        public virtual ICollection<ActiveTask> ActiveTask { get; set; }
        public virtual ICollection<CompletedTask> CompletedTask { get; set; }
        public virtual ICollection<CyclicRoleAssignment> CyclicRoleAssignment { get; set; }
        public virtual ICollection<PersonRole> PersonRole { get; set; }
        public virtual ICollection<RoleCandidates> RoleCandidates { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual RoleType RRty { get; set; }
    }
}
