using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblMakerCheckerNotification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int CheckListId { get; set; }
        public int? NotificationId { get; set; }
        public string NotificationMessage { get; set; }
        public int BranchId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSent { get; set; }
        public int? CheckerId { get; set; }
        public int? MakerId { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
