using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblRight
    {
        public int Id { get; set; }
        public string Rights { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
