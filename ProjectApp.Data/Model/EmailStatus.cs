using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class EmailStatus
    {
        public EmailStatus()
        {
            EmailQueue = new HashSet<EmailQueue>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
    }
}
