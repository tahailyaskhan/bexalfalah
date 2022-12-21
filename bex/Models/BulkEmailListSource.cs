using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class BulkEmailListSource
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ProcessingStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UploadFileName { get; set; }
        public int? UploadedBy { get; set; }
    }
}
