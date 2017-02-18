using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PersonEmailBlock
    {
        public int RPerId { get; set; }
        public int REmlId { get; set; }

        public virtual EmailType REml { get; set; }
        public virtual Person RPer { get; set; }
    }
}
