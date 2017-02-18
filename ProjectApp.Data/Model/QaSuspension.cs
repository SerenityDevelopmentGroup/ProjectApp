using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class QaSuspension
    {
        public QaSuspension()
        {
            EmailQueue = new HashSet<EmailQueue>();
            Package = new HashSet<Package>();
        }

        public int Id { get; set; }
        public string Supc { get; set; }
        public int RSupId { get; set; }
        public int RQasId { get; set; }
        public DateTime Created { get; set; }
        public int ReminderPauseDays { get; set; }
        public int NumReminders { get; set; }
        public int RemindersAdded { get; set; }
        public DateTime? LastStatusDate { get; set; }
        public DateTime? Closed { get; set; }
        public string Comments { get; set; }
        public int? RPqmPerId { get; set; }
        public int RCreatedPerId { get; set; }
        public bool NeedsReview { get; set; }
        public DateTime EstimatedCancel { get; set; }
        public DateTime NextReminder { get; set; }

        public virtual ICollection<EmailQueue> EmailQueue { get; set; }
        public virtual ICollection<Package> Package { get; set; }
        public virtual Person RCreatedPer { get; set; }
        public virtual Person RPqmPer { get; set; }
        public virtual QaSuspensionState RQas { get; set; }
        public virtual Supplier RSup { get; set; }
    }
}
