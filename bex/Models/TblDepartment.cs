using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblDepartment
    {
        public int Id { get; set; }
        public string DepartName { get; set; }
        public string DepartmentCode { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? Isdeleted { get; set; }
        public bool? IsActive { get; set; }
    }
}
