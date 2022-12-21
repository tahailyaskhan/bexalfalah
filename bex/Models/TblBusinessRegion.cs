using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class TblBusinessRegion
    {
        public decimal Id { get; set; }
        public decimal? RegionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedOn { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public decimal? ModifiedBy { get; set; }
    }
}
