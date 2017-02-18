using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class Bscc
    {
        public Bscc()
        {
            Artwork = new HashSet<Artwork>();
            Project = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCanada { get; set; }
        public int? OldUserGroupId { get; set; }

        public virtual ICollection<Artwork> Artwork { get; set; }
        public virtual ICollection<Project> Project { get; set; }
    }
}
