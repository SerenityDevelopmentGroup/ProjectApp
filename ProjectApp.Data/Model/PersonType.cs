using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PersonType
    {
        public PersonType()
        {
            Person = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string EmailFooterText { get; set; }
        public string EmailFooterHtml { get; set; }

        public virtual ICollection<Person> Person { get; set; }
    }
}
