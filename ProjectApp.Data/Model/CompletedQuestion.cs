using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class CompletedQuestion
    {
        public int Id { get; set; }
        public int? RCtkId { get; set; }
        public int? RAtkId { get; set; }
        public int RQstId { get; set; }
        public int RPerId { get; set; }
        public DateTime Completed { get; set; }
        public string Answer { get; set; }
        public string ReportingAnswer { get; set; }
    }
}
