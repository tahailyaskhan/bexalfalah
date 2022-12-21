using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class AppPostMasterPool
    {
        public int Id { get; set; }
        public int? CheckerId { get; set; }
        public string PostId { get; set; }
        public string CheckerPostId { get; set; }
        public int BranchId { get; set; }
        public string Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CheckListInfoMaker { get; set; }
        public string CheckListinfoChecker { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
