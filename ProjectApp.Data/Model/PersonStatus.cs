using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PersonStatus
    {
        public PersonStatus()
        {
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
