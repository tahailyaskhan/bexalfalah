using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblUserPasswordHistory
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
