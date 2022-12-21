using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblCategorySubAttribute
    {
        public TblCategorySubAttribute()
        {
            TblSubAttEmailCriteria = new HashSet<TblSubAttEmailCriterion>();
        }

        public long Id { get; set; }
        public long ParentCategoryId { get; set; }
        public string Weightage { get; set; }
        public string SubAttribute { get; set; }
        public bool? Comments { get; set; }
        public int? ImagesNo { get; set; }
        public string Email { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedById { get; set; }
        public long? SubCategoryCode { get; set; }
        public bool Mendatory { get; set; }
        public int? MarkingId { get; set; }

        public virtual ICollection<TblSubAttEmailCriterion> TblSubAttEmailCriteria { get; set; }
    }
}
