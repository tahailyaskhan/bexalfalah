using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class AddOrRemoveEmailTrail
    {
        public int Id { get; set; }
        public int? Role { get; set; }
        public string EmailListType { get; set; }
        public string BranchCode { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? Datetime { get; set; }
        public int? ModifiedBy { get; set; }
        public string Operationtype { get; set; }
    }
}
