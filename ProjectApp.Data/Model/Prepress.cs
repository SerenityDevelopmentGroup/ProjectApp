using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Prepress
    {
        public Prepress()
        {
            Artwork = new HashSet<Artwork>();
            Person = new HashSet<Person>();
            PrepressSupplier = new HashSet<PrepressSupplier>();
            Project = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Artwork> Artwork { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        public virtual ICollection<PrepressSupplier> PrepressSupplier { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}
