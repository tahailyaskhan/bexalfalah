using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblSubAttEmailCriterion
    {
        public int Id { get; set; }
        public long? SubAttId { get; set; }
        public string Value { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual TblCategorySubAttribute SubAtt { get; set; }
    }
}
