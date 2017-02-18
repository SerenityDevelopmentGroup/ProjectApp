using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class PersonMetrics
    {
        public int Id { get; set; }
        public int RPerId { get; set; }
        public int? OpenTasks { get; set; }
        public int? TaskLongestOpen { get; set; }
        public int? TaskClosedCount { get; set; }
        public int? TaskAvgTurnTime { get; set; }
        public string TaskAvgVsThreshold { get; set; }
        public int? PackageAssignedOpen { get; set; }
        public int? PackageAssignedClosed { get; set; }
        public int? ArtworkPending { get; set; }
        public int? ArtworkTotal { get; set; }
        public int? ArtworkAvgPend { get; set; }
        public int? PackageTotalSupsended { get; set; }
        public int? PackageCurrentSuspended { get; set; }
        public int? PackageAvgSuspension { get; set; }
        public int? PackageAvgTurnTime { get; set; }
        public string PackageAvgPctTarget { get; set; }
        public DateTime Created { get; set; }

        public virtual Person RPer { get; set; }
    }
}
