using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class MobileAppRegistration
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public long DesignationId { get; set; }
        public int UserTypeId { get; set; }
        public long? AreaId { get; set; }
        public int? BranchId { get; set; }
        public long? RegionId { get; set; }
        public long? UserId { get; set; }
        public string DeviceId { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
        public bool? EmailSentApp { get; set; }
        public bool? EmailSentRegApp { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public string Ischeck { get; set; }
    }
}
