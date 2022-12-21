using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class AppLog
    {
        public long Id { get; set; }
        public string DetailLog { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
        public string Error { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public int? CheckListId { get; set; }
    }
}
