using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class DdlLog
    {
        public int Id { get; set; }
        public string LoginName { get; set; }
        public string EventType { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public DateTime Created { get; set; }
    }
}
