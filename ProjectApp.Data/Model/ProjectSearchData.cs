using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ProjectSearchData
    {
        public int RPrjId { get; set; }
        public string SearchText { get; set; }
        public string SearchComments { get; set; }

        public virtual Project RPrj { get; set; }
    }
}
