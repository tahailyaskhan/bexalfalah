using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class CheckList
    {
        public CheckList()
        {
            CheckListCategories = new HashSet<CheckListCategory>();
            TblCategoryAttributes = new HashSet<TblCategoryAttribute>();
            TblEmailTemplates = new HashSet<TblEmailTemplate>();
        }

        public int Id { get; set; }
        public string CheckListName { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public bool VideoMendatory { get; set; }
        public string Approvalrequired { get; set; }

        public virtual ICollection<CheckListCategory> CheckListCategories { get; set; }
        public virtual ICollection<TblCategoryAttribute> TblCategoryAttributes { get; set; }
        public virtual ICollection<TblEmailTemplate> TblEmailTemplates { get; set; }
    }
}
