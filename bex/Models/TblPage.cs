using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblPage
    {
        public TblPage()
        {
            TblPrivileges = new HashSet<TblPrivilege>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public string DisplayName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public string MethodName { get; set; }

        public virtual ICollection<TblPrivilege> TblPrivileges { get; set; }
    }
}
