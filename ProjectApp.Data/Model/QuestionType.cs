using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class QuestionType
    {
        public QuestionType()
        {
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Question> Question { get; set; }
    }
}
