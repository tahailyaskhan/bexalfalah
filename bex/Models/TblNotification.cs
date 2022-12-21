using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblNotification
    {
        public long Id { get; set; }
        public long NotificationId { get; set; }
        public string Message { get; set; }
        public string PostId { get; set; }
        public long BranchId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsSent { get; set; }
        public DateTime? SentOnDate { get; set; }
        public long? MarkAsRed { get; set; }
        public long? MarkAsEmber { get; set; }
        public long? RegionId { get; set; }
    }
}
