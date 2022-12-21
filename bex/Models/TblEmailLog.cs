using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblEmailLog
    {
        public int Id { get; set; }
        public int? TempId { get; set; }
        public string PostId { get; set; }
        public string ToEmail { get; set; }
        public string Cc { get; set; }
        public string EmailBody { get; set; }
        public string EmailSubject { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? SendOn { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public int CheckListId { get; set; }
    }
}
