using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class CategoryType
    {
        public int Id { get; set; }
        public string CategoryType1 { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsVideoMandatory { get; set; }
        public string Description { get; set; }
    }
}
