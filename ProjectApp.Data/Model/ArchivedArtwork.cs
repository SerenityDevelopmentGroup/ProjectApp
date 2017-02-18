using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class ArchivedArtwork
    {
        public int Id { get; set; }
        public int RSupId { get; set; }
        public string FileName { get; set; }
        public string InternalFileName { get; set; }
        public int? RPtyId { get; set; }
        public string Supc { get; set; }
        public int? RBscId { get; set; }
        public bool IsEngaged { get; set; }
        public DateTime? Created { get; set; }
        public string Comments { get; set; }
        public DateTime? EngagedDate { get; set; }
        public int? RPreId { get; set; }
        public int? RPerIdCreated { get; set; }
        public DateTime Archived { get; set; }
    }
}
