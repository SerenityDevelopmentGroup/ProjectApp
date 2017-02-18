using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ErrorLog
    {
        public int Id { get; set; }
        public string Caller { get; set; }
        public int? Line { get; set; }
        public string Message { get; set; }
        public DateTime? Created { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
