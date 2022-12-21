using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblPrivilege
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int? RoleId { get; set; }
        public bool? RightToAdd { get; set; }
        public bool? RightToView { get; set; }
        public bool? RightToDelete { get; set; }
        public bool? RightToEdit { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? AssignBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifieOn { get; set; }

        public virtual TblPage Page { get; set; }
    }
}
