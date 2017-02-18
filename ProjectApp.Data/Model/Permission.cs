using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Permission
    {
        public Permission()
        {
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
