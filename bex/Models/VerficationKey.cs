using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class VerficationKey
    {
        public int Id { get; set; }
        public string VerificationType { get; set; }
        public string VerificationKey { get; set; }
        public DateTime InsertedDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedByName { get; set; }
    }
}
