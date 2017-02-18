using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Question
    {
        public Question()
        {
            ProcessAutomation = new HashSet<ProcessAutomation>();
        }

        public int Id { get; set; }
        public int RTskId { get; set; }
        public int RQtyId { get; set; }
        public int? DisplayOrder { get; set; }
        public string Prompt { get; set; }
        public bool IsRequired { get; set; }
        public bool IsUiRequired { get; set; }
        public string ReportingDisplay { get; set; }
        public string PostCompleteAction { get; set; }
        public string DataFetchAction { get; set; }
        public int? RQdgId { get; set; }

        public virtual ICollection<ProcessAutomation> ProcessAutomation { get; set; }
        public virtual QuestionDisplayGroup RQdg { get; set; }
        public virtual QuestionType RQty { get; set; }
        public virtual Task RTsk { get; set; }
    }
}
