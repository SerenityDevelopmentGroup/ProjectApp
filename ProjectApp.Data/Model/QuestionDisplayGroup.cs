using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class QuestionDisplayGroup
    {
        public QuestionDisplayGroup()
        {
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Heading { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}
