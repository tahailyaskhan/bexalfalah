using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class BulkUploadLog
    {
        public long Id { get; set; }
        public string Role { get; set; }
        public string BranchId { get; set; }
        public string EmailListType { get; set; }
        public string EmailAddress { get; set; }
        public long? UploadedBy { get; set; }
        public DateTime? UploadedOn { get; set; }
        public long? FileId { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}
