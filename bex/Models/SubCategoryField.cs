using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class SubCategoryField
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long SubCategoryId { get; set; }
        public string Comment { get; set; }
        public string Rating { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
