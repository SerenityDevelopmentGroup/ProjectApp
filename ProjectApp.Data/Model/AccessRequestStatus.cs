using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class AccessRequestStatus
    {
        public AccessRequestStatus()
        {
            AccessRequest = new HashSet<AccessRequest>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<AccessRequest> AccessRequest { get; set; }
    }
}
