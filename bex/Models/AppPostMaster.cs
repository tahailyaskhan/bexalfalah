using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class AppPostMaster
    {
        public long Id { get; set; }
        public string PostId { get; set; }
        public long BranchId { get; set; }
        public string AddRecipent { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedById { get; set; }
        public DateTime PostedOnDate { get; set; }
        public string Directory { get; set; }
        public string MarkingCriteria { get; set; }
    }
}
