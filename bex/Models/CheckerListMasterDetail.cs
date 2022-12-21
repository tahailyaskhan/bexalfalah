using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class CheckerListMasterDetail
    {
        public int Id { get; set; }
        public int CheckerId { get; set; }
        public int MakerPostId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CheckListInfoMaker { get; set; }
        public string CheckListinfoChecker { get; set; }
        public int? CheckerPostId { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
