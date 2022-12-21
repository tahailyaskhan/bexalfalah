using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblEmailSenderConfig
    {
        public int Id { get; set; }
        public int TempId { get; set; }
        public string ToEmail { get; set; }
        public string EmailBody { get; set; }
        public string EmailSubject { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string PostId { get; set; }
        public bool? IsLock { get; set; }
        public int? UserId { get; set; }
        public int? CheckListId { get; set; }
        public bool? IsChecker { get; set; }
    }
}
