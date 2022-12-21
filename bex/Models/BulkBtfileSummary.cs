using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class BulkBtfileSummary
    {
        public long Id { get; set; }
        public string FileName { get; set; }
        public string UploadedFileName { get; set; }
        public DateTime? UploadedOn { get; set; }
        public string Status { get; set; }
        public long? UploadedBy { get; set; }
    }
}
