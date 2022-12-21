using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblPriLoungeScore
    {
        public long Id { get; set; }
        public int? Checklistid { get; set; }
        public int? Attributeid { get; set; }
        public decimal? TotalScore { get; set; }
        public decimal? Score { get; set; }
        public string Postid { get; set; }
        public DateTime? Posteddate { get; set; }
    }
}
