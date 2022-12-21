using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class BulkBracnhesEmailTrailLog
    {
        public int Id { get; set; }
        public string BrCode { get; set; }
        public string BrName { get; set; }
        public string BrArea { get; set; }
        public string BrRegion { get; set; }
        public string BrLatitude { get; set; }
        public string BrLongitude { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Status { get; set; }
        public int? FileId { get; set; }
    }
}
