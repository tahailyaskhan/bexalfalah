using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int? InputterType { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public long? InvalidAttempths { get; set; }
        public bool? IsLock { get; set; }
        public bool? PasswordReminderSent { get; set; }
        public bool? PasswordSent { get; set; }
        public int? UserId { get; set; }
        public string IsPortalLogin { get; set; }

        public virtual TblRole Role { get; set; }
    }
}
