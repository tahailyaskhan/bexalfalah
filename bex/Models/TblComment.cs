using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblComment
    {
        public long Id { get; set; }
        public string Comment { get; set; }
        public DateTime? CreatedOn { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ChecklistId { get; set; }
        public long? AttributeId { get; set; }
        public long? SubAttributeid { get; set; }
    }
}
