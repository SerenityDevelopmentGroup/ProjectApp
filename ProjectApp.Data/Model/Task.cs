using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Task
    {
        public Task()
        {
            ActiveTask = new HashSet<ActiveTask>();
            CompletedTask = new HashSet<CompletedTask>();
            CyclicTaskAssignment = new HashSet<CyclicTaskAssignment>();
            ProcessAutomation = new HashSet<ProcessAutomation>();
            Question = new HashSet<Question>();
            WorkFlowRTsk = new HashSet<WorkFlow>();
            WorkFlowRTskParent = new HashSet<WorkFlow>();
        }

        public int Id { get; set; }
        public int RRolId { get; set; }
        public int RTtyId { get; set; }
        public string Name { get; set; }
        public int DaysToComplete { get; set; }
        public int RushDaysToComplete { get; set; }
        public int? DaysToWarn { get; set; }
        public int? RushDaysToWarn { get; set; }
        public string PostCompleteAction { get; set; }

        public virtual ICollection<ActiveTask> ActiveTask { get; set; }
        public virtual ICollection<CompletedTask> CompletedTask { get; set; }
        public virtual ICollection<CyclicTaskAssignment> CyclicTaskAssignment { get; set; }
        public virtual ICollection<ProcessAutomation> ProcessAutomation { get; set; }
        public virtual ICollection<Question> Question { get; set; }
        public virtual ICollection<WorkFlow> WorkFlowRTsk { get; set; }
        public virtual ICollection<WorkFlow> WorkFlowRTskParent { get; set; }
        public virtual Role RRol { get; set; }
        public virtual TaskType RTty { get; set; }
    }
}
