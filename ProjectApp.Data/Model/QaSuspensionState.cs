using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class QaSuspensionState
    {
        public QaSuspensionState()
        {
            QaSuspension = new HashSet<QaSuspension>();
        }

        public int Id { get; set; }
        public string State { get; set; }
        public int ReminderPauseDays { get; set; }
        public int NumReminders { get; set; }

        public virtual ICollection<QaSuspension> QaSuspension { get; set; }
    }
}
