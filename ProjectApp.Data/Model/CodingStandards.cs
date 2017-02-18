using System;
using System.Collections.Generic;

namespace ProjectApp.Data
{
    public partial class CodingStandards
    {
        public int Id { get; set; }
        public string Supc { get; set; }
        public string Pack { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ExternalUpc { get; set; }
        public string InternalUpc { get; set; }
        public string Type { get; set; }
        public string Cube { get; set; }
        public string Container { get; set; }
        public string Portion { get; set; }
        public string PortionSize { get; set; }
        public string UnitsPerCase { get; set; }
        public string MinimumSplit { get; set; }
        public string Category { get; set; }
        public string MajorCategory { get; set; }
        public string IntermediateCategory { get; set; }
        public string MinorCategory { get; set; }
        public string CatchWeightIndicator { get; set; }
        public string SourceVendor { get; set; }
        public string NetWeight { get; set; }
        public string TareWeight { get; set; }
        public string GrossWeight { get; set; }
        public string HazardCode { get; set; }
        public string KosherItem { get; set; }
        public string Storage { get; set; }
        public string StockType { get; set; }
        public string MasterCase { get; set; }
        public string ShipSplitOnly { get; set; }
        public string Cubiscan { get; set; }
        public string NonHazardous { get; set; }
        public string Ti { get; set; }
        public string Hi { get; set; }
        public string TrueVendor { get; set; }
    }
}
