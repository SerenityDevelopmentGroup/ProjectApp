using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ProcessAutomation
    {
        public ProcessAutomation()
        {
            EmailQueue = new HashSet<EmailQueue>();
        }

        public int Id { get; set; }
        public int RSupId { get; set; }
        public int RPrjId { get; set; }
        public int RPkgId { get; set; }
        public int RTskId { get; set; }
        public int RQstId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Consumed { get; set; }

        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual Package RPkg { get; set; }
        public virtual Project RPrj { get; set; }
        public virtual Question RQst { get; set; }
        public virtual Supplier RSup { get; set; }
        public virtual Task RTsk { get; set; }
    }
}
