using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblNotificationUpdateIssueLog
    {
        public long Id { get; set; }
        public string PostId { get; set; }
        public long BranchId { get; set; }
        public long SubCategoryId { get; set; }
        public long? ResolvedById { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public string ResolvedComment { get; set; }
        public long? EndorsedId { get; set; }
        public DateTime? EndorsedDate { get; set; }
        public string EndorsedComment { get; set; }
    }
}
