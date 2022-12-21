using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblBranchObservarrionSummary
    {
        public long Id { get; set; }
        public int? BranchId { get; set; }
        public string RedMarked { get; set; }
        public string EmberMarked { get; set; }
        public string ObservationType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public string Year { get; set; }
    }
}
