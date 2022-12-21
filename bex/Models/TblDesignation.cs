using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblDesignation
    {
        public long Id { get; set; }
        public decimal? DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public decimal? ModifiedBy { get; set; }
        public bool? Region { get; set; }
        public bool? Area { get; set; }
        public bool? Branch { get; set; }
    }
}
