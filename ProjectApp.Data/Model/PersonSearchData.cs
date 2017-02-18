using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PersonSearchData
    {
        public int RPerId { get; set; }
        public string SearchText { get; set; }

        public virtual Person RPer { get; set; }
    }
}
