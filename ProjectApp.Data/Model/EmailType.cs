using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class EmailType
    {
        public EmailType()
        {
            EmailQueue = new HashSet<EmailQueue>();
            PersonEmailBlock = new HashSet<PersonEmailBlock>();
            PersonEmailLog = new HashSet<PersonEmailLog>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool? Required { get; set; }
        public bool HasPdr { get; set; }
        public string HtmlTemplate { get; set; }
        public string TextTemplate { get; set; }
        public string TextFooter { get; set; }
        public string HtmlFooter { get; set; }
        public DateTime? Created { get; set; }

        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual ICollection<PersonEmailBlock> PersonEmailBlock { get; set; }
        public virtual ICollection<PersonEmailLog> PersonEmailLog { get; set; }
    }
}
