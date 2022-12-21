using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblCategoryAttribute
    {
        public long Id { get; set; }
        public int? CkId { get; set; }
        public string Category { get; set; }
        public string GroupEmail { get; set; }
        public string MarkingCriteria { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? Weightage { get; set; }
        public string ImageUrl { get; set; }
        public long? CategoryCode { get; set; }
        public bool Mendatory { get; set; }
        public string Totalscore { get; set; }

        public virtual CheckList Ck { get; set; }
    }
}
