using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblUpdateEntryLog
    {
        public long Id { get; set; }
        public string Method { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public long? ModifiedById { get; set; }
        public long? CheckUpdate { get; set; }
    }
}
