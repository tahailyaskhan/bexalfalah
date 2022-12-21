using System;
using System.Collections.Generic;

#nullable disable

namespace bex.Models
{
    public partial class BulkuploadBtmorningHuddle
    {
        public int Id { get; set; }
        public string Branchcode { get; set; }
        public string Checklistname { get; set; }
        public int? SubAttrId { get; set; }
        public string Ytd { get; set; }
        public DateTime? UploadedOn { get; set; }
        public string Result { get; set; }
    }
}
