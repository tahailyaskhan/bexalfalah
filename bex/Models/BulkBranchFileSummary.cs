using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class BulkBranchFileSummary
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string UploadedFileName { get; set; }
        public DateTime? UploadedOn { get; set; }
        public string Status { get; set; }
        public long? DuplicateBranchcode { get; set; }
        public long? ValidRegion { get; set; }
        public long? InvalidRegion { get; set; }
        public long? UploadedBy { get; set; }
        public int? ValidlongitudeLatitude { get; set; }
        public int? InValidlongitudeLatitude { get; set; }
        public int? TotalCount { get; set; }
        public string Result { get; set; }
    }
}
