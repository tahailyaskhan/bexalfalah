using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bex.Models.MVVM
{
    public class tbl_UserPasswordHistory
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
