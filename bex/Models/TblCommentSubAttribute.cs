using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblCommentSubAttribute
    {
        public long Id { get; set; }
        public long CommentId { get; set; }
        public long SubAttributeId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string AomMarking { get; set; }
    }
}
