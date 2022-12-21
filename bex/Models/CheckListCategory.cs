using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class CheckListCategory
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int CheckListId { get; set; }

        public virtual CheckList CheckList { get; set; }
    }
}
