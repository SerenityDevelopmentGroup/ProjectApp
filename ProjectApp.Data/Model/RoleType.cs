using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class RoleType
    {
        public RoleType()
        {
            Role = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Role> Role { get; set; }
    }
}
